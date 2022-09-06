using System;
using System.Collections.Generic;

namespace Ejercicio_01___La_maquina_expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();

          

            Dictionary < int, Producto > maquinaExpendedora = new Dictionary<int, Producto > ();


            int opcionIngresada;
            string seguir = "s";

            /* maquinaExpendedora.Add(1, "Doritos");
             maquinaExpendedora.Add(2, "Coca-Cola");
             maquinaExpendedora.Add(3, "Sprite");
             maquinaExpendedora.Add(4, "Lays");
             maquinaExpendedora.Add(5, "Cindor");
             maquinaExpendedora.Add(6, "Terrabusi");
             maquinaExpendedora.Add(7, "Capitan del espacio");
             maquinaExpendedora.Add(8, "Fulbito");
             maquinaExpendedora.Add(9, "Surtido Bagley");
             maquinaExpendedora.Add(10, "Biznike");
            */

            maquinaExpendedora.Add(1, new Producto("Doritos", 125.5f));
            maquinaExpendedora.Add(2, new Producto("Coca-Cola", 160.60f));
            maquinaExpendedora.Add(3, new Producto("Sprite", 150.45f));
            maquinaExpendedora.Add(4, new Producto("Lays", 180));
            maquinaExpendedora.Add(5, new Producto("Cindor", 230.25f));
            maquinaExpendedora.Add(6, new Producto("Terrabusi", 330));
            maquinaExpendedora.Add(7, new Producto("Capitan del espacio", 95));
            maquinaExpendedora.Add(8, new Producto("Fulbito", 60.50f));
            maquinaExpendedora.Add(9, new Producto("Surtido Bagley", 300));
            maquinaExpendedora.Add(10, new Producto("Biznike", 80));
            /* do
             {

             foreach (KeyValuePair<int, string> item in maquinaExpendedora)
             {
                 Console.WriteLine($"{item.Key} --- {item.Value}");
             }

             Console.WriteLine("Elija el numero del producto que quiere: ");
             if(int.TryParse(Console.ReadLine(), out opcionIngresada))
             {
                 Console.WriteLine($"Usted recibió el producto: {maquinaExpendedora[opcionIngresada]}");
             }
             maquinaExpendedora.Remove(opcionIngresada);

             foreach (KeyValuePair<int, string> item in maquinaExpendedora)
             {
                 Console.WriteLine($"{item.Key} --- {item.Value}");
             }

                 Console.WriteLine("Desea seguir? (s/n):");
                 seguir = Console.ReadLine();
                 while (seguir != "s" && seguir != "n")
                 {
                     Console.WriteLine("ERROR. Ingrese s/n: ");
                     seguir = Console.ReadLine();

                 }

             } while (seguir == "s");

             */

            do
            { 

            foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
            {
                Console.WriteLine($"{item.Key} --- {item.Value.Nombre} ${item.Value.Precio}");
            }

            Console.WriteLine("Elija el numero del producto que quiere: ");
            if (int.TryParse(Console.ReadLine(), out opcionIngresada) && maquinaExpendedora.ContainsKey(opcionIngresada)
            {
                Console.WriteLine($"Usted recibió el producto: {maquinaExpendedora[opcionIngresada].Nombre}");
            }
            maquinaExpendedora.Remove(opcionIngresada);

            foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
            {
                Console.WriteLine($"{item.Key} --- {item.Value.Nombre} ${item.Value.Precio}");
            }

            Console.WriteLine("Desea seguir? (s/n):");
            seguir = Console.ReadLine();
            while (seguir != "s" && seguir != "n")
            {
                Console.WriteLine("ERROR. Ingrese s/n: ");
                seguir = Console.ReadLine();

            }

        } while (seguir == "s");

        }
    }
}
