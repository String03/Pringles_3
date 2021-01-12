using Pringles.Contracts.UnitsOfWorks;
using Pringles.EE;
using Pringles.Utilities.Factories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL.UnitsOfWorks
{
    public class CompraUnitOfWork : ICompraUnitOfWork
    {
        public void RealizarCompra(Compra compra, IEnumerable<DetalleCompra> detallesCompra)
        {
            //Se establece la conexión
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                using (IDbTransaction trx = connection.BeginTransaction())
                {
                    try
                    {
                        //Este IDbCommand es para Compra
                        IDbCommand cmdCompra = connection.CreateCommand();
                        cmdCompra.CommandText = CrearQueryInsertarOrden(compra);
                        cmdCompra.Transaction = trx;
                        IDbDataParameter[] parametrosCompra = ParametrosInsertarCompra(compra, cmdCompra);
                        foreach (var p in parametrosCompra)
                            cmdCompra.Parameters.Add(p);

                        //ExecuteScalar ejecuta query sabiendo que va a devolver un resultado
                        //Ejecuta insert de compra y se retorna id de registros insertados
                        int idOrden = Convert.ToInt32(cmdCompra.ExecuteScalar());

                        foreach (var articulo in detallesCompra)
                        {
                            //Este IDbCommand es para detalleCompra
                            IDbCommand cmdArticulo = connection.CreateCommand();
                            cmdArticulo.CommandText = CrearQueryInsertarDetalleCompra(cmdArticulo);
                            cmdArticulo.Transaction = trx;

                            IDbDataParameter[] parametrosDetalleCompra = CrearParametrosDetalleCompra(idOrden, articulo, cmdArticulo);

                            foreach (var p in parametrosDetalleCompra)
                                cmdArticulo.Parameters.Add(p);

                            cmdArticulo.ExecuteNonQuery();

                            // ACTUALIZAR HISTORIAL COMPRA.
                            IDbCommand cmdActualizarHistorial = connection.CreateCommand();
                            cmdActualizarHistorial.CommandText = CrearQueryHistorialCompra();
                            cmdActualizarHistorial.Transaction = trx;

                            var idLibroHistorial = cmdActualizarHistorial.CreateParameter();
                            idLibroHistorial.ParameterName = "@LIBRO_FK";
                            idLibroHistorial.Value = articulo.Libro_Fk;

                            var montoCompra = cmdActualizarHistorial.CreateParameter();
                            montoCompra.ParameterName = "@PRECIO_UNITARIO";
                            montoCompra.Value = articulo.Precio_Unitario;

                            var cantidadCompra = cmdActualizarHistorial.CreateParameter();
                            cantidadCompra.ParameterName = "@CANTIDAD";
                            cantidadCompra.Value = articulo.Cantidad;

                            cmdActualizarHistorial.Parameters.Add(idLibroHistorial);
                            cmdActualizarHistorial.Parameters.Add(montoCompra);
                            cmdActualizarHistorial.Parameters.Add(cantidadCompra);

                            cmdActualizarHistorial.ExecuteNonQuery();

                            // ACTUALIZAR STOCK.
                            IDbCommand cmdActualizarStock = connection.CreateCommand();
                            cmdActualizarStock.CommandText = CrearQueryActualizarStock();
                            cmdActualizarStock.Transaction = trx;

                            var idLibroParam = cmdActualizarStock.CreateParameter();
                            idLibroParam.ParameterName = "@ID";
                            idLibroParam.Value = articulo.Libro_Fk;

                            var stockNuevoLibroParam = cmdActualizarStock.CreateParameter();
                            stockNuevoLibroParam.ParameterName = "@CANTIDAD_STOCK";
                            stockNuevoLibroParam.Value = articulo.Libro.Cantidad_Stock + articulo.Cantidad;

                            cmdActualizarStock.Parameters.Add(idLibroParam);
                            cmdActualizarStock.Parameters.Add(stockNuevoLibroParam);

                            cmdActualizarStock.ExecuteNonQuery();
                        }

                        trx.Commit();
                    }
                    catch (Exception ex)
                    {
                        trx.Rollback();
                        throw ex;
                    }
                }
            }
        }

        private string CrearQueryActualizarStock()
        {
            string query = @"UPDATE LIBRO SET CANTIDAD_STOCK = @CANTIDAD_STOCK WHERE ID = @ID";
            return query;
        }

        private string CrearQueryHistorialCompra()
        {
            string query = @"INSERT INTO [dbo].[HistorialCompraVentaLibro]
                   ([libro_fk]
                   ,[precio_unitario_compra]
                   ,[cantidad_comprada]
                   ,[fecha_compra])
             VALUES
                   (@LIBRO_FK, @PRECIO_UNITARIO, @CANTIDAD, GETDATE()) ";
            return query;
        }

        /// <summary>
        /// Prepara los parámetros para insertar detalleCompra
        /// </summary>
        /// <param name="idCompra"></param>
        /// <param name="articulo"></param>
        /// <param name="cmdArticulo"></param>
        /// <returns></returns>
        private IDbDataParameter[] CrearParametrosDetalleCompra(int idCompra, DetalleCompra articulo, IDbCommand cmdArticulo)
        {
            IDbDataParameter[] parameters;
            var p1 = cmdArticulo.CreateParameter();
            var p2 = cmdArticulo.CreateParameter();
            var p3 = cmdArticulo.CreateParameter();
            var p4 = cmdArticulo.CreateParameter();
         
            //Se necesita porque ese registro es un lote, pertenecen a un registro
            p1.ParameterName = "@COMPRAS_FK";
            p1.Value = idCompra;

            p2.ParameterName = "@LIBRO_FK";
            p2.Value = articulo.Libro_Fk;

            p3.ParameterName = "@PRECIO_UNITARIO";
            p3.Value = articulo.Precio_Unitario;
                      

            p4.ParameterName = "@CANTIDAD";
            p4.Value = articulo.Cantidad;

          

            parameters = new IDbDataParameter[] { p1, p2, p3, p4};
            return parameters;
        }

        private string CrearQueryInsertarDetalleCompra(IDbCommand cmdArticulo)
        {
            string query = @"INSERT INTO[dbo].[DetalleCompra]
                       ([compras_fk]
                       ,[libro_fk]
                       ,[precio_unitario]
                       ,[cantidad])
                 VALUES
                       (@COMPRAS_FK
                       ,@LIBRO_FK
                       ,@PRECIO_UNITARIO
                       ,@CANTIDAD)";
            return query;
        }

        /// <summary>
        /// Prepara los parámetros para compra de artículos
        /// </summary>
        /// <param name="compra"></param>
        /// <param name="cmdCompra"></param>
        /// <returns></returns>
        private IDbDataParameter[] ParametrosInsertarCompra(Compra compra, IDbCommand cmdCompra)
        {
            //Se crean parámetros como en el mapeo, solo que estos son estáticos
            var p1 = cmdCompra.CreateParameter();
            var p2 = cmdCompra.CreateParameter();
            var p3 = cmdCompra.CreateParameter();
          
            //Clave
            p1.ParameterName = "@PROVEEDOR_FK";
            //Valor
            p1.Value = compra.Proveedor_Fk;

            p2.ParameterName = "@USUARIO_FK";
            p2.Value = compra.Usuario_Fk;

            p3.ParameterName = "@FECHA_REG";
            p3.Value = compra.fecha_reg;

           
            //Quiero que me prepare los parámetros
            return new IDbDataParameter[] { p1, p2, p3 };
        }

        private string CrearQueryInsertarOrden(Compra compra)
        {
            string query = @"INSERT INTO[dbo].[Compra]
                       ([proveedor_fk]
                       ,[usuario_fk]
                       ,[fecha_reg])
                 OUTPUT INSERTED.ID
                 VALUES
                       (@PROVEEDOR_FK
                       ,@USUARIO_FK
                       ,@FECHA_REG)";
            return query;
        }

        private IDbConnection GetConnection()
        {
            return ConnectionFactory.CreatePringlesMainConnection();
        }
    }
}
