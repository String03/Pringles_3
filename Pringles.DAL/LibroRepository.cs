using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Pringles.DAL
{
    public class LibroRepository : Repository<Libro>, ILibroRepository
    {

        public IEnumerable<Libro> BuscarLibros(string genero, string autor)
        {
            if (string.IsNullOrEmpty(genero) && string.IsNullOrEmpty(autor))
                return new List<Libro>();

            string query = CrearQueryGeneroAutor(genero, autor);
            IDictionary<string, object> parametros = CrearParametros(genero, autor);

            var resultado = ExecuteSelectStatement(query, parametros);

            if (resultado.Count() == 0)
                return resultado;

            foreach (var libro in resultado)
            {
                libro.Autores = BuscarAutoresLibro(libro).ToList();
                libro.Genero = BuscarGenero(libro);
                libro.Proveedor = BuscarProveedor(libro);
            }

            return resultado;
        }

        public IEnumerable<Libro> BuscarLibros()
        {

            var resultado = GetAll();

            if (resultado.Count() == 0)
                return resultado;

            foreach (var libro in resultado)
            {
                libro.Autores = BuscarAutoresLibro(libro).ToList();
                libro.Genero = BuscarGenero(libro);
                libro.Proveedor = BuscarProveedor(libro);
            }

            return resultado;
        }

        private Proveedor BuscarProveedor(Libro libro)
        {
            string query = "SELECT * FROM PROVEEDOR WHERE ID = @PROVEEDOR_ID";
            IDictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@PROVEEDOR_ID", libro.Proveedor_FK);
            return ExecuteSelectStatement<Proveedor>(query, parametros).FirstOrDefault();
        }

        public Libro BuscarLibroPorISBN(string isbn)
        {
            try
            {
                string query = "SELECT * FROM LIBRO WHERE ISBN = @ISBN";
                IDictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@ISBN", isbn);

                var resultado = ExecuteSelectStatement(query, parametros).FirstOrDefault();
                resultado.Autores = BuscarAutoresLibro(resultado).ToList();
                resultado.Genero = BuscarGenero(resultado);
                return resultado;
            }
            catch
            {
                return null;
            }
        }

        protected virtual IEnumerable<Autor> BuscarAutoresLibro(Libro libro)
        {
            string query = "SELECT * FROM AUTOR WHERE ID IN (SELECT  autor_fk FROM AutorLibro WHERE libro_fk = @LIBRO_FK)";
            IDictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@LIBRO_FK", libro.Id);
            return ExecuteSelectStatement<Autor>(query, parametros);
        }

        protected Genero BuscarGenero(Libro libro)
        {
            string query = "SELECT * FROM GENERO WHERE ID = @GENERO_ID";
            IDictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@GENERO_ID", libro.Genero_Fk);
            return ExecuteSelectStatement<Genero>(query, parametros).FirstOrDefault();
        }

        protected virtual string CrearQueryGeneroAutor(string genero, string autor)
        {
            string query = @"SELECT DISTINCT L.* 
                FROM   LIBRO L 
                INNER JOIN AutorLibro al ON L.ID = al.LIBRO_FK
                WHERE  1 = 1 ";

            query += @"AND (";

            if (!string.IsNullOrEmpty(autor))
                query += @"al.AUTOR_FK IN ( SELECT ID FROM   AUTOR WHERE  Upper(NOMBRES) LIKE Upper('%'  + @NOMBRE + '%') OR     Upper(APELLIDO) LIKE Upper('%' + @APELLIDO + '%') OR     Upper(NOMBRES + ' ' + APELLIDO) LIKE Upper('%' + @NOMBRE_COMPLETO + '%')";
            else
                query += " 1 = 1 ";

            query += @"AND ";

            if (!string.IsNullOrEmpty(genero))
                query += @"L.GENERO_FK IN ( SELECT ID FROM   GENERO WHERE  Upper(NOMBRE) LIKE Upper('%' + @NOMBRE_GENERO + '%')";
            else
                query += " 1 = 1";

            query += @"))";

            // Correccion para que cuando esten ambos se genere que query correctamente.
            if (!string.IsNullOrEmpty(autor) && !string.IsNullOrEmpty(genero))
                query += ")";

            return query;
        }

        protected virtual IDictionary<string, object> CrearParametros(string genero, string autor)
        {
            IDictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(genero))
                parametros.Add("@NOMBRE_GENERO", genero);

            if (!string.IsNullOrEmpty(autor))
            {
                parametros.Add("@NOMBRE", autor);
                parametros.Add("@APELLIDO", autor);
                parametros.Add("@NOMBRE_COMPLETO", autor);
            }

            return parametros;
        }

        public override IQueryable<Libro> GetAll()
        {
            var resultado = base.GetAll().Where(l => l.Activo);

            foreach (var libro in resultado)
            {
                libro.Autores = BuscarAutoresLibro(libro).ToList();
                libro.Genero = BuscarGenero(libro);
            }

            return resultado;
        }

        public IEnumerable<Libro> BuscarLibrosCriterio()
        {
            string query = "SELECT * FROM Libro WHERE CANTIDAD_STOCK <= ISNULL(CRITERIO_ACABA, 0)";
            return ExecuteSelectStatement(query);
        }

        public override void Update(Libro entity)
        {
            var libro = BuscarLibroPorISBN(entity.Isbn);
            ActualizarLibroTransaccional(entity, libro);
        }

        public override void Delete(Libro entity)
        {
            entity.Activo = false;
            Update(entity);
        }

        public override void Save(Libro entity)
        {
            var libro = BuscarLibroPorISBN(entity.Isbn);

            if (libro == null)
            {
                GuardarLibroTransaccional(entity);
            }
            else
            {
                ActualizarLibroTransaccional(entity, libro);
            }
        }

        private void ActualizarLibroTransaccional(Libro entity, Libro libro)
        {
            entity.Activo = true;
            entity.Id = libro.Id;

            using (var cnx = GetConnection())
            {
                cnx.Open();

                using (var trx = cnx.BeginTransaction())
                {
                    IDbCommand cmdLibro = cnx.CreateCommand();
                    cmdLibro.CommandText = CreateUpdateQuery(entity);
                    cmdLibro.Transaction = trx;
                    cmdLibro.ExecuteNonQuery();

                    IDbCommand cmdAutorLibroDelete = cnx.CreateCommand();
                    cmdAutorLibroDelete.CommandText = $"DELETE FROM AutorLibro WHERE LIBRO_FK = {entity.Id}";
                    cmdAutorLibroDelete.Transaction = trx;
                    cmdAutorLibroDelete.ExecuteNonQuery();

                    IEnumerable<AutorLibro> autorLibro = entity.Autores.Select(al => new AutorLibro
                    {
                        Autor_Fk = al.Id,
                        Libro_Fk = entity.Id
                    });

                    foreach (var item in autorLibro)
                    {
                        IDbCommand cmdAutorLibro = cnx.CreateCommand();
                        cmdAutorLibro.CommandText = CreateInsertQuery(item);
                        cmdAutorLibro.Transaction = trx;
                        cmdAutorLibro.ExecuteNonQuery();
                    }

                    trx.Commit();
                }
            }
        }

        private void GuardarLibroTransaccional(Libro entity)
        {
            using (var cnx = GetConnection())
            {
                cnx.Open();
                using (var trx = cnx.BeginTransaction())
                {
                    IDbCommand cmdOrden = cnx.CreateCommand();
                    cmdOrden.CommandText = CreateInsertQueryOutputId(entity);
                    cmdOrden.Transaction = trx;

                    int idLibro = Convert.ToInt32(cmdOrden.ExecuteScalar());

                    IEnumerable<AutorLibro> autorLibro = entity.Autores.Select(al => new AutorLibro
                    {
                        Autor_Fk = al.Id,
                        Libro_Fk = idLibro
                    });

                    foreach (var item in autorLibro)
                    {
                        IDbCommand cmdAutorLibro = cnx.CreateCommand();
                        cmdAutorLibro.CommandText = CreateInsertQuery(item);
                        cmdAutorLibro.Transaction = trx;
                        cmdAutorLibro.ExecuteNonQuery();
                    }

                    trx.Commit();
                }
            }
        }

        public IEnumerable<ConsultaLibroMasCompraDTO> BuscarLibroMasCompradoPorProveedor()
        {
            string query = CrearQueryLibroMasComprado();
            var execute = ExecuteSelectStatement<ConsultaLibroMasCompraDTO>(query);

            return execute.AsEnumerable();
        }

        private string CrearQueryLibroMasComprado()
        {
            string query = @"SELECT pro.id as proveedor_fk, pro.razon_social,li.titulo,li.id, MAX (det.cantidad) as cantidad FROM PROVEEDOR pro
            INNER JOIN COMPRA com 
            ON pro.id = com.proveedor_fk
            INNER JOIN DETALLECOMPRA det
            ON com.id = det.compras_fk
            INNER JOIN LIBRO li
            ON det.libro_fk = li.id
            GROUP BY pro.razon_social,li.titulo,li.id,pro.id";

            return query;
        }

        public IEnumerable<MayorCompraDTO> MayorCompraProveedor()
        {
            string query = CrearQueryMayorCompra();
            var execute = ExecuteSelectStatement<MayorCompraDTO>(query);
            return execute.AsEnumerable();
        }

        private string CrearQueryMayorCompra()
        {
            string query = @"SELECT li.titulo, li.proveedor_fk, SUM(det.cantidad) cantidad FROM DetalleCompra det
            INNER JOIN LIBRO li
            on li.id = det.libro_fk
            GROUP BY li.titulo, li.proveedor_fk
            ORDER BY 2 desc";

            return query;
        }

        public IEnumerable<MenorPrecioDTO> MenorPrecioProveedores()
        {
            string query = CrearQueryMenorPrecio();
            var execute = ExecuteSelectStatement<MenorPrecioDTO>(query);
            return execute.AsEnumerable();
        }

        private string CrearQueryMenorPrecio()
        {
            string query = @"SELECT DISTINCT li.titulo,pro.razon_social, MIN(det.precio_unitario) precio FROM DetalleCompra det
            INNER JOIN Libro li
            ON det.libro_fk = li.id
            INNER JOIN Proveedor pro
            ON li.proveedor_fk = pro.id
            GROUP BY
            li.titulo,pro.razon_social";
            return query;
        }

        public IEnumerable<ComprasPendientesDTO> BuscarComprasPendientes()
        {
            string query = CrearQueryComprasPendientes();
            var execute = ExecuteSelectStatement<ComprasPendientesDTO>(query);
            return execute.AsEnumerable();
        }

        private string CrearQueryComprasPendientes()
        {
            string query = @"SELECT li.titulo,pro.razon_social,com.id FROM Libro li
            INNER JOIN DetalleCompra det
            ON li.id = det.libro_fk
            INNER JOIN Compra com
            ON com.id = det.compras_fk
            INNER JOIN Proveedor pro
            ON pro.id = li.proveedor_fk
            WHERE com.recibido = 0";
            return query;
        }
    }
}
