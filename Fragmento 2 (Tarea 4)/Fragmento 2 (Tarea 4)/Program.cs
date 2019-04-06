using System;
using System.Collections.Generic;

namespace Fragmento_2__Tarea_4_
{
    abstract class Musico
    {
        public string nombre;
        public Musico(string n)
        {
            nombre = n;
        }

        public virtual string Display()
        {
            return nombre;
        }
    }

    class Bajista : Musico
    {
        public string instrumento;
        public Bajista(string n, string i) : base(n)
        {
            this.instrumento = i;
        }

        public override string Display()
        {
            return "Hola, yo uso el Bajo";
        }
    }

    class Guitarrista : Musico
    {
        public string instrumento;
        public Guitarrista(string n, string i) : base(n)
        {
            instrumento = i;
        }
        public override string Display()
        {
            return "Hola, yo uso la Guitarra";
        }
    }

    class Program
    {
        static void Main()
        {
            Bajista b = new Bajista("Flea", "Bajista");
            Guitarrista g = new Guitarrista("Santana", "Guitarrista");
            List<Musico> musicos = new List<Musico>();
            musicos.Add(b);
            musicos.Add(g);

            foreach (Musico m in musicos)
            {
                Console.WriteLine(m.Display());
            }
            Console.ReadKey();
        }
    }
}
