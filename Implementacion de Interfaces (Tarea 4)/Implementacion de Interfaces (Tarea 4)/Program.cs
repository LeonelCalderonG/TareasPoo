using System;
using System.Collections.Generic;

namespace Implementacion_de_Interfaces__Tarea_4_
{
    interface IMusico
    {
        void Nombre();
    }

    class Bajista : IMusico
    {
       public void Nombre()
        {
            Console.WriteLine("Hola, Yo uso el Bajo");
        }
    }

    class Guitarrista : IMusico
    {
        public void Nombre()
        {
            Console.WriteLine("Hola, Yo uso la Guitarra");
        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<String, IMusico> music = new Dictionary<string, IMusico>();
            music.Add("Flea", new Bajista());
            music.Add("Santana", new Guitarrista());
            IMusico contenido;
            music.TryGetValue("Flea", out contenido);
            Console.WriteLine(contenido);
            Console.ReadKey();
        }
    }
}
