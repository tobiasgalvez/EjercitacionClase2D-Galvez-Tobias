using System;
using BibliotecaDeClases;
using System.Collections.Generic;

namespace Ejercicio_02___Se_acabó_la_comida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Producto> papasFritas = new Stack<Producto>();
            Stack<Producto> cocaCola = new Stack<Producto>();
            Stack<Producto> biznike = new Stack<Producto>();

            papasFritas.Push(new Producto("Papas fritas", 150.50f));
            papasFritas.Push(new Producto("Papas fritas", 150.50f));
            papasFritas.Push(new Producto("Papas fritas", 150.50f));

            cocaCola.Push(new Producto("Coca-Cola", 200));
            cocaCola.Push(new Producto("Coca-Cola", 200));
            cocaCola.Push(new Producto("Coca-Cola", 200));

            biznike.Push(new Producto("Biznike", 87.50f));
            biznike.Push(new Producto("Biznike", 87.50f));
            biznike.Push(new Producto("Biznike", 87.50f));

            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            maquinaExpendedora.Add(1, papasFritas);
            maquinaExpendedora.Add(2, cocaCola);
            maquinaExpendedora.Add(3, biznike);


            int opcionIngresada;
            string seguir = "s";

           
            do
            {

                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    Console.WriteLine($"{item.Key} --- {item.Value}");
                }

                Console.WriteLine("Elija el numero del producto que quiere: ");
                if (int.TryParse(Console.ReadLine(), out opcionIngresada) && maquinaExpendedora.ContainsKey(opcionIngresada))
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
