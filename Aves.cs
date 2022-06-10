using System;
namespace Tarea
{
    class Aves
    {
        public string Nombre{set; get;}
        public string Color{set; get;}

        public Aves (string nombre, string color)
        {
            this.Nombre = nombre;
            this.Color = color;
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