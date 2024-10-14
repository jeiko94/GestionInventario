
using GestionInventario.Entidades;

namespace GestionInventario.Negocio
{
    public class ProductoServicio : IProductoServicio
    {
        private List<IProducto> productos = new List<IProducto>();

        public void AgregarProducto(IProducto producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }

        public  List<IProducto> ObtenerProductos()
        {
            return productos;
        }
    }
}
