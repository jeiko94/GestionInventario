using GestionInventario.Entidades;

namespace GestionInventario.Negocio
{
    public interface IProductoServicio
    {
        void AgregarProducto(IProducto producto);
        void EliminarProducto(int id);
        List<IProducto> ObtenerProductos();
    }
}
