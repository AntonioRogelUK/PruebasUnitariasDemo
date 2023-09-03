namespace PuntoDeVenta.MSTest
{
    [TestClass]
    public class VentasServiciosMSTest
    {
        [TestMethod]
        public void ObtenerImporte_ImporteCorrecto()
        {
            VentaDetalle concepto = new VentaDetalle
            {
                Cantidad = 5,
                Producto = new Producto
                {
                    PrecioUnitario = 5
                }
            };

            decimal importe = VentaServicios.ObtenerImporte(concepto);

            Assert.AreEqual(25, importe);
        }

        [TestMethod]
        public void ObtenerIVAConcepto_IVACorrecto()
        {
            VentaDetalle concepto = new VentaDetalle
            {
                Cantidad = 5,
                Producto = new Producto
                {
                    PrecioUnitario = 5
                }
            };

            decimal iva = VentaServicios.ObtenerIVAConcepto(concepto);

            Assert.AreEqual(4, iva);
        }

        [TestMethod]
        public void ObtenerSubTotal_SubTotalCorrecto()
        {
            Venta venta = new Venta()
            {
                Conceptos = new List<VentaDetalle>
                {
                    new VentaDetalle
                    {
                        Cantidad = 5,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    }
                },
            };

            decimal subtotal = VentaServicios.ObtenerSubTotal(venta);

            Assert.AreEqual(25, subtotal);
        }

        [TestMethod]
        public void ObtenerSubTotal_DosProductos_SubTotalCorrecto()
        {
            Venta venta = new Venta()
            {
                Conceptos = new List<VentaDetalle>
                {
                    new VentaDetalle
                    {
                        Cantidad = 5,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    },
                    new VentaDetalle
                    {
                        Cantidad = 10,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    },
                },
            };

            decimal subtotal = VentaServicios.ObtenerSubTotal(venta);

            Assert.AreEqual(75, subtotal);
        }

        [TestMethod]
        public void ObtenerIVAGeneral_IVAGeneralCorrecto()
        {
            Venta venta = new Venta()
            {
                Conceptos = new List<VentaDetalle>
                {
                    new VentaDetalle
                    {
                        Cantidad = 5,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    }
                },
            };

            decimal iva = VentaServicios.ObtenerIVAGeneral(venta);

            Assert.AreEqual(4, iva);
        }

        [TestMethod]
        public void ObtenerIVAGeneral_DosProductos_IVAGeneralCorrecto()
        {
            Venta venta = new Venta()
            {
                Conceptos = new List<VentaDetalle>
                {
                    new VentaDetalle
                    {
                        Cantidad = 5,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    },
                    new VentaDetalle
                    {
                        Cantidad = 10,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    },
                },
            };

            decimal iva = VentaServicios.ObtenerIVAGeneral(venta);

            Assert.AreEqual(12, iva);
        }

        [TestMethod]
        public void ObtenerTotal_TotalCorrecto()
        {
            Venta venta = new Venta()
            {
                Conceptos = new List<VentaDetalle>
                {
                    new VentaDetalle
                    {
                        Cantidad = 5,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    }
                },
            };

            decimal total = VentaServicios.ObtenerTotal(venta);

            Assert.AreEqual(29, total);
        }

        [TestMethod]
        public void ObtenerTotal_DosProductos_TotalCorrecto()
        {
            Venta venta = new Venta()
            {
                Conceptos = new List<VentaDetalle>
                {
                    new VentaDetalle
                    {
                        Cantidad = 5,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    },
                    new VentaDetalle
                    {
                        Cantidad = 10,
                        Producto = new Producto
                        {
                            PrecioUnitario = 5
                        }
                    },
                },
            };

            decimal total = VentaServicios.ObtenerTotal(venta);

            Assert.AreEqual(87, total);
        }
    }
}
