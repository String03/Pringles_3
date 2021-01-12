using Pringles.Contracts.Repositories;
using Pringles.EE;
using System.Linq;

namespace Pringles.DAL
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {
        public Autor BuscarAutorMasVendido()
        {
            try
            {
                string query = @"SELECT autor.* 
                FROM   autor autor 
                       INNER JOIN (SELECT au.id, 
                                          Count(*) cantidad_autor 
                                   FROM   detalleorden do 
                                          INNER JOIN libro lib 
                                                  ON do.libro_fk = lib.id 
												   INNER JOIN AutorLibro al
												  ON lib.id = al.libro_fk
                                          INNER JOIN autor au 
                                                  ON al.autor_fk = au.id 
                                   GROUP  BY au.id) autor_cantidad 
                               ON autor.id = autor_cantidad.id 
                ORDER  BY autor_cantidad.cantidad_autor DESC ";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public Autor BuscarAutorMasVendido(Cliente cliente)
        {
            try
            {
                string query = $@"SELECT autor.*
                FROM   autor autor
                       INNER JOIN(SELECT au.id,
                                          Count(*) cantidad_autor
                                   FROM detalleorden do
                    INNER JOIN libro lib
                            ON do.libro_fk = lib.id

                            INNER JOIN AutorLibro al
                            ON lib.id = al.libro_fk
                                          INNER JOIN autor au
                                                  ON al.autor_fk = au.id
                                              inner join Orden o
                                                    on o.id = do.orden_fk
                                            WHERE o.cliente_fk = { cliente.Id}
                GROUP BY au.id) autor_cantidad
           ON autor.id = autor_cantidad.id
                ORDER BY autor_cantidad.cantidad_autor DESC";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public Autor BuscarAutorMasVendidoPorProveedor()
        {
            try
            {
                string query = @"SELECT autor.* 
                FROM   autor autor 
                       INNER JOIN (SELECT au.id, 
                                          Count(*) cantidad_autor 
                                   FROM   detallecompra dc 
                                          INNER JOIN libro lib 
                                                  ON dc.libro_fk = lib.id 
                                          INNER JOIN autorlibro al
                                                  ON al.libro_fk = lib.id
                                            
                                          INNER JOIN autor au 
                                                  ON al.autor_fk = au.id 
                                   GROUP  BY au.id) autor_cantidad 
                               ON autor.id = autor_cantidad.id 
                ORDER  BY autor_cantidad.cantidad_autor DESC ";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch 
            {

                return null;
            }
        }

        public Autor BuscarAutorMasVendidoPorProveedor(Proveedor proveedor)
        {
            try
            {
                string query = $@"SELECT autor.*
                FROM   autor autor
                       INNER JOIN(SELECT au.id,
                                          Count(*) cantidad_autor
                                   FROM detallecompra dc
                                          INNER JOIN libro lib
                                                  ON dc.libro_fk = lib.id

                                                  INNER JOIN AutorLibro al

                                                  ON lib.id = al.libro_fk
                                          INNER JOIN autor au
                                                  ON al.autor_fk = au.id
                                              inner join Compra c
                                                    on c.id = dc.compras_fk
                                            WHERE c.proveedor_fk = { proveedor.Id}
                GROUP BY au.id) autor_cantidad
           ON autor.id = autor_cantidad.id
                ORDER BY autor_cantidad.cantidad_autor DESC";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch 
            {

                return null;
            }
        }
    }
}
