using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
        private int valor;
        public string color;

        public Dado(int valor, string co)
        {
            this.valor = valor;
            color = co;
        }

        public Dado()
        {
            valor = 0;
            color = "";
        }
    }

    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            aleatorio = aleatorio.Next(1, 6);
            Dado uno = new Dado(aleatorio, color);
            Dado dos = new Dado(aleatorio, color);
            Dado tres = new Dado(aleatorio, color);
        }
    }
}

