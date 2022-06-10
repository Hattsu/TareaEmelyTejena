using System;
namespace Tarea
{
    class Program
    {
        public static void Main(string[] args)
        {
            Condor condor = new Condor("Condor-Juan", "Negro");
            condor.Imprimir_datos();
            condor.Volar();

            Gallina gallina = new Gallina("Gallina-Maria", "Café");
            gallina.Imprimir_datos();
            gallina.Volar();

            Pinguino pinguino= new Pinguino("Pinguino-Pepe", "Negro");
            pinguino.Imprimir_datos();
            pinguino.Nadar();

            Pato pato = new Pato("Pato-Roco", "Blanco");
            pato.Imprimir_datos();
            pato.Nadar();
        }
    }
}
