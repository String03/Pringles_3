using Pringles.Contracts.Repositories;
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
    public class VentaUnitOfWork : IVentaUnitOfWork 
    {
        public void RealizarVenta(Orden orden, IEnumerable<DetalleOrden> detallesOrden, RegistroCaja registroCaja)
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                using (IDbTransaction trx = connection.BeginTransaction())
                {
                    try
                    {
                        IDbCommand cmdOrden = connection.CreateCommand();
                        cmdOrden.CommandText = CrearQueryInsertarOrden(orden);
                        cmdOrden.Transaction = trx;
                        IDbDataParameter[] parametrosOrden = ParametrosInsertarOrden(orden, cmdOrden);
                        foreach (var p in parametrosOrden)
                            cmdOrden.Parameters.Add(p);

                        int idOrden = Convert.ToInt32(cmdOrden.ExecuteScalar());
                        orden.Id = idOrden;

                        foreach (var articulo in detallesOrden)
                        {
                            IDbCommand cmdArticulo = connection.CreateCommand();
                            cmdArticulo.CommandText = CrearQueryInsertarDetalleOrden(cmdArticulo);
                            cmdArticulo.Transaction = trx;

                            IDbDataParameter[] parametrosDetalleOrden = CrearParametrosDetalleOrden(idOrden, articulo, registroCaja, cmdArticulo);

                            foreach (var p in parametrosDetalleOrden)
                                cmdArticulo.Parameters.Add(p);

                            cmdArticulo.ExecuteNonQuery();

                            // ACTUALIZAR HISTORIAL VENTA.
                            IDbCommand cmdActualizarHistorial = connection.CreateCommand();
                            cmdActualizarHistorial.CommandText = CrearQueryHistorialVenta();
                            cmdActualizarHistorial.Transaction = trx;

                            var idLibroHistorial = cmdActualizarHistorial.CreateParameter();
                            idLibroHistorial.ParameterName = "@LIBRO_FK";
                            idLibroHistorial.Value = articulo.Libro_Fk;

                            var montoVenta = cmdActualizarHistorial.CreateParameter();
                            montoVenta.ParameterName = "@PRECIO_UNITARIO";
                            montoVenta.Value = articulo.Precio_Unitario;

                            var cantidadVenta = cmdActualizarHistorial.CreateParameter();
                            cantidadVenta.ParameterName = "@CANTIDAD";
                            cantidadVenta.Value = articulo.Cantidad;

                            cmdActualizarHistorial.Parameters.Add(idLibroHistorial);
                            cmdActualizarHistorial.Parameters.Add(montoVenta);
                            cmdActualizarHistorial.Parameters.Add(cantidadVenta);

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
                            stockNuevoLibroParam.Value = articulo.Libro.Cantidad_Stock - articulo.Cantidad;

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

        private string CrearQueryHistorialVenta()
        {
            string query = @"INSERT INTO [dbo].[HistorialCompraVentaLibro]
                   ([libro_fk]
                   ,[precio_unitario_venta]
                   ,[cantidad_comprada]
                   ,[fecha_compra])
             VALUES
                   (@LIBRO_FK, @PRECIO_UNITARIO, @CANTIDAD, GETDATE()) ";
            return query;
        }

        private string CrearQueryActualizarStock()
        {
            string query = @"UPDATE LIBRO SET CANTIDAD_STOCK = @CANTIDAD_STOCK WHERE ID = @ID";
            return query;
        }

        private static IDbDataParameter[] CrearParametrosDetalleOrden(int idOrden, DetalleOrden articulo, RegistroCaja registroCaja, IDbCommand cmdArticulo)
        {
            IDbDataParameter[] parameters;
            var p1 = cmdArticulo.CreateParameter();
            var p2 = cmdArticulo.CreateParameter();
            var p3 = cmdArticulo.CreateParameter();
            var p4 = cmdArticulo.CreateParameter();
            var p5 = cmdArticulo.CreateParameter();
            var p6 = cmdArticulo.CreateParameter();
            var p7 = cmdArticulo.CreateParameter();

            p1.ParameterName = "@ORDEN_FK";
            p1.Value = idOrden;

            p2.ParameterName = "@LIBRO_FK";
            p2.Value = articulo.Libro_Fk;

            p3.ParameterName = "@PRECIO_UNITARIO";
            p3.Value = articulo.Precio_Unitario;

            p4.ParameterName = "@DESCUENTO";
            p4.Value = (object)articulo.Descuento ?? DBNull.Value;

            p5.ParameterName = "@CANTIDAD";
            p5.Value = articulo.Cantidad;

            p6.ParameterName = "@DETALLE_DESCUENTO_FK";
            p6.Value = (object)articulo.Detalle_Descuento_Fk ?? DBNull.Value;

            p7.ParameterName = "@REGISTRO_CAJA_FK";
            p7.Value = registroCaja.Id;

            parameters = new IDbDataParameter[] { p1, p2, p3, p4, p5, p6, p7 };
            return parameters;
        }

        private string CrearQueryInsertarDetalleOrden(IDbCommand cmdArticulo)
        {
            string query = @"INSERT INTO [dbo].[DetalleOrden]
                   ([orden_fk]
                   ,[libro_fk]
                   ,[precio_unitario]
                   ,[descuento]
                   ,[cantidad]
                   ,[detalle_descuento_fk]
                   ,[registro_caja_fk])
             VALUES
                   (@ORDEN_FK
                   ,@LIBRO_FK
                   ,@PRECIO_UNITARIO
                   ,@DESCUENTO
                   ,@CANTIDAD
                   ,@DETALLE_DESCUENTO_FK
                   ,@REGISTRO_CAJA_FK) ";
            return query;
        }

        private static IDbDataParameter[] ParametrosInsertarOrden(Orden orden, IDbCommand cmdOrden)
        {
            var p1 = cmdOrden.CreateParameter();
            var p2 = cmdOrden.CreateParameter();
            var p3 = cmdOrden.CreateParameter();
            var p4 = cmdOrden.CreateParameter();
            var p5 = cmdOrden.CreateParameter();
            var p6 = cmdOrden.CreateParameter();
            var p7 = cmdOrden.CreateParameter();
            var p8 = cmdOrden.CreateParameter();

            p1.ParameterName = "@CLIENTE_FK";
            p1.Value = (object)orden.Cliente_Fk ?? DBNull.Value;

            p2.ParameterName = "@PAGO_EFECTIVO";
            p2.Value = orden.Pago_Efectivo;

            p3.ParameterName = "@PAGO_TARJETA";
            p3.Value = orden.Pago_Tarjeta;

            p4.ParameterName = "@MONTO_PAGO_EFECTIVO";
            p4.Value = orden.Monto_Pago_Efectivo;

            p5.ParameterName = "@MONTO_PAGO_TARJETA";
            p5.Value = orden.Monto_Pago_Tarjeta;

            p6.ParameterName = "@CAJA_FK";
            p6.Value = orden.Caja_Fk;

            p7.ParameterName = "@USUARIO_FK";
            p7.Value = orden.Usuario_Fk;

            p8.ParameterName = "@CAMBIO_DINERO ";
            p8.Value = orden.Cambio_Dinero;

            return new IDbDataParameter[] { p1, p2, p3, p4, p5, p6, p7, p8 };
        }

        private string CrearQueryInsertarOrden(Orden orden)
        {
            string query = @"INSERT INTO[dbo].[Orden]
                   ([cliente_fk]
                   ,[pago_efectivo]
                   ,[pago_tarjeta]
                   ,[monto_pago_efectivo]
                   ,[monto_pago_tarjeta]
                   ,[caja_fk]
                   ,[usuario_fk]
                   ,[cambio_dinero])
             OUTPUT INSERTED.ID
             VALUES
                   (@CLIENTE_FK
                   ,@PAGO_EFECTIVO
                   ,@PAGO_TARJETA
                   ,@MONTO_PAGO_EFECTIVO
                   ,@MONTO_PAGO_TARJETA
                   ,@CAJA_FK
                   ,@USUARIO_FK
                   ,@CAMBIO_DINERO) ";
            return query;
        }

        protected virtual IDbConnection GetConnection()
        {
            return ConnectionFactory.CreatePringlesMainConnection();
        }
    }
}
