using PuntoDeVenta.Entidades;

namespace PuntoDeVenta.Servicios
{
    public static class VentaServicios
    {
        public static decimal ObtenerImporte(VentaDetalle concepto) 
        {
            return concepto.Cantidad * concepto.Producto.PrecioUnitario;
        }

        public static decimal ObtenerIVAConcepto(VentaDetalle concepto)
        {
            return concepto.Cantidad * (concepto.Producto.PrecioUnitario * .16m);
        }

        public static decimal ObtenerSubTotal(Venta venta)
        {
            decimal subtotal = 0;
            foreach(VentaDetalle concepto in venta.Conceptos) 
            {
                subtotal += ObtenerImporte(concepto); 
            }
            return subtotal;
        }

        public static decimal ObtenerIVAGeneral(Venta venta)
        {
            decimal iva = 0;
            foreach (VentaDetalle concepto in venta.Conceptos)
            {
                iva += ObtenerIVAConcepto(concepto);
            }
            return iva;
        }

        public static decimal ObtenerTotal(Venta venta)
        {
            return ObtenerSubTotal(venta) + ObtenerIVAGeneral(venta);
        }
    }


}
