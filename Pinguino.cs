using System;
namespace Tarea
{
    class Pinguino:Aves, INadador
    {
        public Pinguino(string nombre, string color):base(nombre, color)
        {
            //atributos heredados
        }
        //Polimorfismo por interface
        public void Nadar()
        {
            Console.WriteLine("Nada");
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