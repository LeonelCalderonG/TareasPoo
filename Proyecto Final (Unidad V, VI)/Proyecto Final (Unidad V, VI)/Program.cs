using System;
using System.IO;
using System.Collections.Generic;
namespace Proyecto_Final__Unidad_V__VI_

// Crea una clase llamada Producto y otra ProductoDB la cual lea y escriba objetos tipo Producto a un archivo,
// similar a lo visto en clase.
{
    class Producto
    {
        public string Codigo;
        public string Descripcion;
        public Decimal Precio;
        public int Departamento;
        public int Likes;

        public Producto(string Codigo, string Descripcion, Decimal Precio, int Departamento, int Likes)
        {
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.Departamento = Departamento;
            this.Likes = Likes;
        }
    }

    class ProductoDB
    {
        public static void Save(string path, List<Producto> Productos)
        {
            StreamWriter txtOut = new StreamWriter(new FileStream(path, FileMode.Create
                , FileAccess.Write));
            foreach (Producto Product in Productos)
            {
                txtOut.Write(Product.Codigo + "|");
                txtOut.Write(Product.Descripcion + "|");
                txtOut.Write(Product.Precio + "|");
                txtOut.Write(Product.Departamento + "|");
                txtOut.WriteLine(Product.Likes);
            }
            txtOut.Close();
        }
    }

    class Program
    {
        static void Main()
        {
            {
                List<Producto> Productos = new List<Producto>();
                Productos.Add(new Producto("165", "Es un buen producto.", 35, 104, 45));
                Productos.Add(new Producto("221", "Un producto algo interesante", 23, 301, 21));
                Productos.Add(new Producto("587", "El producto tiene fallas", 14, 402, 0));
                ProductoDB.Save("ProductosDelProyecto.txt", Productos);
                ProductoDB.Save("ProductosDelProyecto.bin", Productos);

                try
                {
                    using (StreamReader Read = File.OpenText(@"H:\GitHub\TareasPoo\Proyecto Final (Unidad V, VI)\Proyecto Final (Unidad V, VI)\bin\Debug\ProductosDelProyecto.txt"))
                    {
                        while (!Read.EndOfStream)
                        {
                            string R = Read.ReadLine();
                            Console.WriteLine(R);
                        }
                    }
                }
                catch (AggregateException)
                {
                    Console.WriteLine("Error en la ejecucion");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Metodo no valido");
                }
                catch (EndOfStreamException)
                {
                    Console.WriteLine("Error en la Lectura del archivo");
                }
                catch (FileLoadException)
                {
                    Console.WriteLine("Carga fallida");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Archivo no encontrado");
                }
                catch (InsufficientMemoryException)
                {
                    Console.WriteLine("Memoria llena");
                }
                catch (InvalidDataException)
                {
                    Console.WriteLine("Dato no valido");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Operacion no valida");
                }
                catch (IOException)
                {
                    Console.WriteLine("Error de Input/Output");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Dato desconocido");
                }
                catch (MissingMethodException)
                {
                    Console.WriteLine("No existe el metodo");
                }
                catch (NotFiniteNumberException)
                {
                    Console.WriteLine("Numero no valido");
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Proceso cancelado");
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("No hay memoria");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error de desborde");
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine("Almacenamiento de desborde");
                }
                catch (SystemException)
                {
                    Console.WriteLine("Error de sistema");
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
    

