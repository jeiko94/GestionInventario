
namespace GestionInventario.Entidades
{
    public abstract class ProductoBase: IProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public abstract void MostrarInformacion();
    }
}
