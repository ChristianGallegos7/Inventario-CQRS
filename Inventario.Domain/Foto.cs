namespace Inventario.Domain
{
    public class Foto : BaseEntity
    {
        public string? Url { get; set; }

        public Guid ProductoId { get; set; }

        public virtual Producto? Producto { get; set; }
    }
}
