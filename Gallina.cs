using System;
namespace Tarea
{
    class Gallina:Aves, IVolador
    {
        public Gallina(string nombre, string color):base(nombre, color)
        {
            //atributos heredados
        }
        //Polimorfismo por interface
        public void Volar()
        {
            Console.WriteLine("Vuela");
        }
        public void Imprimir_datos()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("------------");
        }
    }
}