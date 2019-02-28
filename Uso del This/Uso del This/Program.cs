using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_del_This
{
    class Animales
    {
        //Declaracion de variables.
        private string nombre;

        //Uso de constructor.
        public Animales(string nombre)
        {
            this.nombre = nombre;
        }

        public void Imprime()
        {
            Console.WriteLine("Animal: {0}", nombre);
        }
    }
    class Program
    {
        static void Main()
        {
            Animales a = new Animales("Perro");
            Animales b = new Animales("Gato");
            Animales c = new Animales("Pez");
            Animales d = new Animales("Ave");
            Animales e = new Animales("Ardilla");
            a.Imprime();
            b.Imprime();
            c.Imprime();
            d.Imprime();
            e.Imprime();
            Console.ReadKey();
            Console.WriteLine("Exiting...");
        }
    }
}
