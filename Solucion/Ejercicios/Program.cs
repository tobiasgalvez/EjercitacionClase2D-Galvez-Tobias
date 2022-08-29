using System;

namespace EjercitacionEnClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");

            //string nombre;

            //nombre = "Tobias";


            //string edadIngresada = Console.ReadLine();

            ////int edad = int.Parse(edadIngresada);

            //int edad;

            //bool resultado = int.TryParse(edadIngresada, out edad); //devuelve 0 si no lo pudo convertir o el número ingresado si pudo 

            ////Console.WriteLine("su edad es " + edad);

            ////Console.WriteLine(nombre);

            //Console.WriteLine($"Se pudo convertir? : {resultado}");

            //Console.WriteLine($"su edad es {edad}");


            //if (resultado)
            //{
            //    Console.WriteLine("Hola {0}, su edad es {1}", nombre, edad);// {0} y {1} son las posiciones

            //}
            //else
            //{
            //    Console.WriteLine("Dato invalido");
            //}


            //float precioConComa = 45.75f;

            ////conversion explicita
            //int entero = (int)precioConComa;

            ////conversion implicita
            //float flotante = entero;


            string[] nombres = new string[5];

            nombres[0] = "Tobias";
            nombres[1] = "Juan";
            nombres[2] = "Chantal";

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            string[] paises = { "Brasil", "Perú", "Chile" };

            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }
        }
    }
}
