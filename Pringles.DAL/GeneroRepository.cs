using Pringles.Contracts.Repositories;
using Pringles.EE;
using System.Linq;

namespace Pringles.DAL
{
    public class GeneroRepository : Repository<Genero>, IGeneroRepository
    {
        public Genero BuscarGeneroMasVendido()
        {
            try
            {
                string query = @"SELECT genero.*
                    FROM   genero genero 
                           INNER JOIN (SELECT gen.id, 
                                              Count(*) cantidad_genero
                                       FROM   detalleorden do 
                                              INNER JOIN libro lib 
                                                      ON do.libro_fk = lib.id 
                                              INNER JOIN Genero gen
                                                      ON lib.genero_fk = gen.id
                                       GROUP  BY gen.id) genero_cantidad 
                                   ON genero.id = genero_cantidad.id 
                    ORDER  BY genero_cantidad.cantidad_genero DESC ";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public Genero BuscarGeneroMasVendido(Cliente cliente)
        {
            try
            {
                string query = $@"SELECT genero.*
                    FROM   genero genero 
                           INNER JOIN (SELECT gen.id, 
                                              Count(*) cantidad_genero
                                       FROM   detalleorden do 
                                              INNER JOIN libro lib 
                                                      ON do.libro_fk = lib.id 
                                              INNER JOIN Genero gen
                                                      ON lib.genero_fk = gen.id
                                              inner join Orden o
                                                    on o.id = do.orden_fk
                                            WHERE o.cliente_fk = {cliente.Id}
                                       GROUP  BY gen.id) genero_cantidad 
                                   ON genero.id = genero_cantidad.id 
                    ORDER  BY genero_cantidad.cantidad_genero DESC ";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public Genero BuscarGeneroMasVendidoPorProveedor()
        {
            try
            {
                string query = @"SELECT genero.*
                    FROM   genero genero 
                           INNER JOIN (SELECT gen.id, 
                                              Count(*) cantidad_genero
                                       FROM   detallecompra dc 
                                              INNER JOIN libro lib 
                                                      ON dc.libro_fk = lib.id 
                                              INNER JOIN Genero gen
                                                      ON lib.genero_fk = gen.id
                                       GROUP  BY gen.id) genero_cantidad 
                                   ON genero.id = genero_cantidad.id 
                    ORDER  BY genero_cantidad.cantidad_genero DESC ";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch 
            {

                return null;
            }
        }

        public Genero BuscarGeneroMasVendidoPorProveedor(Proveedor proveedor)
        {
            try
            {
                string query = $@"SELECT genero.*
                    FROM   genero genero 
                           INNER JOIN (SELECT gen.id, 
                                              Count(*) cantidad_genero
                                       FROM   detallecompra dc 
                                              INNER JOIN libro lib 
                                                      ON dc.libro_fk = lib.id 
                                              INNER JOIN Genero gen
                                                      ON lib.genero_fk = gen.id
                                              inner join Compra c
                                                    on c.id = dc.compras_fk
                                            WHERE c.proveedor_fk = {proveedor.Id}
                                       GROUP  BY gen.id) genero_cantidad 
                                   ON genero.id = genero_cantidad.id 
                    ORDER  BY genero_cantidad.cantidad_genero DESC ";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch 
            {

                return null;
            }
        }
    }
}
