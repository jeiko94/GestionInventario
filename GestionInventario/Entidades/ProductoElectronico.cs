
namespace GestionInventario.Entidades
{
    public class ProductoElectronico: ProductoBase
    {
        public int GarantiaMes { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio}, Garantia: {GarantiaMes} meses");
        }
    }
}
