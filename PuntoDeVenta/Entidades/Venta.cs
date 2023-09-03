namespace PuntoDeVenta.Entidades
{
    public class Venta
    {
        public int Folio { get; set; }
        public List<VentaDetalle> Conceptos { get; set; } = new List<VentaDetalle>();
        public decimal SubTotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
    }
}
