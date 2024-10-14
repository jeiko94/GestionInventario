
namespace GestionInventario.Entidades
{
    public class ProductoAlimenticio: ProductoBase
    {
        public DateTime FechaCaducidad { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio}, Caduca: {FechaCaducidad.ToShortDateString()}");
        }
    }
}
