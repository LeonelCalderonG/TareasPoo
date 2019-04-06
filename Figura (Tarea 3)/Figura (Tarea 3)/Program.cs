using System;
using System.Collections.Generic;

namespace Figura__Tarea_3_
{
    //Se crea la Clase Vector2D, lo cual será las "Coordenadas" para dibujar las figuras.
    class Vector2D
    {
        public int x, y;
        public Vector2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", x, y);
        }
    }

    //Creación de la Clase Color, esta clase permitirá darle color a las figuras que serán dibujadas.

    class Color
    {
        public enum Name { red, blue, white, green, black, none }
        public int R, G, B, I;
        public Color.Name colorName;
        public Color(int r, int g, int b, int i = 1)
        {
            R = r;
            G = g;
            B = b;
            I = i;
            this.colorName = Color.Name.none;
        }

        public Color(Color.Name name)
        {
            colorName = name;
            if (name == Color.Name.white)
            {
                R = 255; G = 0; B = 0; I = 1;
            }
            else
            {
                R = 0; G = 0; B = 255; I = 1;
            }
        }
    }

    //Creación de la Clase Figura con la función de poder dibujar las figuras en el programa.

    class Figura
    {
        public Vector2D position;
        public string fill, border;
        public Figura() : this(new Vector2D(20, 20)) { }
        public Figura(Vector2D pos)
        {
            position = pos;
            fill = "Red";
            border = "White";
        }

        public virtual void Dibuja() { }
    }

    //Creación de las Clases Derivadas por medio de la Clase Padre (Figura).

    class Circulo : Figura
    {
        private int radio;

        //Uso de Base, la explicación de porque se utiliza "Base" es que para realizar figuras 
        //desde las Clases Derivadas se necesita un atributo necesario que pertenece a la Clase Padre
        //lo cual nos permite dibujar las figuras que queremos crear por medio de las clases 
        //que se estan creando y lo que necesitaremos para realizar esto es la posición en las que se 
        //dibujarán las figuras. En pocas palabras, "Base:" quiere decir la Clase Padre hereda: "Atributos"
        //y la clase que esta recibiendo esta herencia lo podemos encontrar cuando creamos el nombre de
        //la Clase Derivada que en esta ocasión se tratará de un Círculo.

        public Circulo(Vector2D pos, int radio) : base(pos)
        {
            this.radio = radio;
        }

        public Circulo() : base()
        {
            this.radio = 10;
        }

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Círculo en {0} de color {1}"
                , position, fill);
        }
    }

    class Rectangulo : Figura
    {
        public Rectangulo(Vector2D pos) : base(pos) { }
        public Rectangulo() : base() { }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Rectángulo en {0}, de color {1}" +
               "", position, fill);
        }
    }

    class Cuadrado : Figura
    {
        public Cuadrado(Vector2D pos) : base(pos) { }
        public Cuadrado() : base() { }
        public override void Dibuja()
        {
            Console.WriteLine("\n" + "Creación de la figura Cuadrado en {0}, con relleno de" +
                " color: {1}", position, fill);
        }
    }

    class Program
    {
        static void Main()
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(50, 50)));
            figuras.Add(new Cuadrado(new Vector2D(100, 100)));
            foreach (Figura f in figuras)
            {
                f.Dibuja();
            }
            Console.ReadKey();
        }
    }
}
