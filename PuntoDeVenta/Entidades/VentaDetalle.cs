namespace PuntoDeVenta.Entidades
{
    public class VentaDetalle
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; } = new Producto();
        public decimal Importe { get ; set; }
    }
}
