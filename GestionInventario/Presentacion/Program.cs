using GestionInventario.Entidades;
using GestionInventario.Negocio;

namespace GestionInventario.Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductoServicio productoServicio = new ProductoServicio();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Sistema de gestión de inventario");
                Console.WriteLine("1. Agregar producto alimenticio");
                Console.WriteLine("2. Agregar producto electronico");
                Console.WriteLine("3. Listar productos");
                Console.WriteLine("4. Eliminar productos");
                Console.WriteLine("5. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        AgregarProductoAlimenticio(productoServicio);
                        break;
                    case 2:
                        AgregarProductoElectronido(productoServicio);
                        break;
                    case 3:
                        ListarProducto(productoServicio);
                        break;
                    case 4:
                        EliminarProductos(productoServicio);
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción invalida.");
                        break;
                }
            }
        }

        static void AgregarProductoAlimenticio(IProductoServicio productoServicio)
        {
            ProductoAlimenticio producto = new ProductoAlimenticio();

            Console.WriteLine("Ingrese el ID: ");
            producto.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre: ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el precio: ");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de caducidad (dd/mm/yyyy): ");
            producto.FechaCaducidad = DateTime.Parse(Console.ReadLine());

            productoServicio.AgregarProducto(producto);
            Console.WriteLine("Producto agregado exitosamente.");
        }

        static void AgregarProductoElectronido(IProductoServicio productoServicio)
        {
            ProductoElectronico producto = new ProductoElectronico();

            Console.WriteLine("Ingrese el ID: ");
            producto.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre: ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el precio: ");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la garantia en meses: ");
            producto.GarantiaMes = int.Parse(Console.ReadLine());

            productoServicio.AgregarProducto(producto);
            Console.WriteLine("Producto agregado exitosamente.");
        }

        static void ListarProducto(IProductoServicio productoServicio)
        {
            var productos = productoServicio.ObtenerProductos();

            if (productos.Count == 0)
            {
                Console.WriteLine("No hya productos en el inventario");
                return;
            }

            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }

        static void EliminarProductos(IProductoServicio productoServicio)
        {
            ProductoElectronico electronico = new ProductoElectronico();
            ProductoAlimenticio alimenticio = new ProductoAlimenticio();

            Console.WriteLine("Ingresa el ID del producto a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            if (electronico.Id == 0 || alimenticio.Id == 0)
            {
                Console.WriteLine("El producto no se encuentra en el inventario.");
            }
            else
            {
                productoServicio.EliminarProducto(id);
                Console.WriteLine("Producto eliminado con exito");
            }
                
        }
    }
}