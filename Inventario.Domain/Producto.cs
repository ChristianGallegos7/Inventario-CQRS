namespace Inventario.Domain
{
    public class Producto : BaseEntity
    {

        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public string? CodigoBarras {  get; set; }

        public decimal PrecioVenta { get; set; }

        public decimal CostoCompra { get; set; }

        public int StockActual { get; set; }

        public int StockMinimo { get; set; }

        public Guid CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    
        public virtual ICollection<Foto>? Fotos { get; set; } = new List<Foto>();

    }
}
