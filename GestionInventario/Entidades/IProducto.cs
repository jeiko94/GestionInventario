
namespace GestionInventario.Entidades
{
    public interface IProducto
    {
        int Id { get; set; }
        string Nombre { get; set; }
        decimal Precio { get; set; }
        void MostrarInformacion();
    }
}
