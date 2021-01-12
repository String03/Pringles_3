using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pringles.Contracts.TextBuilders;
using Pringles.DAL.TextBuilders;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Tests
{
    [TestClass]
    public class FacturaTest
    {
        [TestMethod]
        public void CrearFacturaTest()
        {
            IEnumerable<DetalleOrden> articulos = new List<DetalleOrden>
            {
                new DetalleOrden
                {
                    Libro = new Libro
                    {
                        Titulo = "Libro1 con nombre muy largo"
                    },
                    Descuento = null,
                    Cantidad = 1,
                    Precio_Unitario = 10.00m
                },
                new DetalleOrden
                {
                    Libro = new Libro
                    {
                        Titulo = "Libro2"
                    },
                    Descuento = null,
                    Cantidad = 3,
                    Precio_Unitario = 20.00m
                },
                new DetalleOrden
                {
                    Libro = new Libro
                    {
                        Titulo = "Libro3"
                    },
                    Descuento = 50,
                    Cantidad = 1,
                    Precio_Unitario = 7.00m
                }
            };
            IGeneradorFactura generadorFactura = new GeneradorFactura();

            string factura = generadorFactura.CrearFactura(articulos);
            Assert.IsNotNull(factura);
        }
    }
}
