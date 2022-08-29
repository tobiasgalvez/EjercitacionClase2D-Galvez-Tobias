using System;

namespace Ejercicio_06___Años_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioDeInicio;
            int anioDeFin;

            Console.WriteLine("Ingrese año de inicio: ");
            anioDeInicio = Convert.ToInt32(Console.ReadLine());

            while(anioDeInicio < 0)
            {
                Console.WriteLine("ERROR. Ingrese año de inicio válido: ");
                anioDeInicio = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Ingrese año de fin: ");
            anioDeFin = Convert.ToInt32(Console.ReadLine());

            while (anioDeFin < 0 || anioDeFin <= anioDeInicio)
            {
                Console.WriteLine("ERROR. Ingrese año de fin válido: ");
                anioDeFin = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Los años bisiestos entre {anioDeInicio} y {anioDeFin} son: ");
            for(int i=anioDeInicio;i<=anioDeFin;i++)
            {
                if(i % 4 == 0)
                {
                    Console.Write($"{i}, ");
                }
                else
                {
                    if(i % 100 == 0 && i % 400 == 0)
                    Console.Write($"{i}, ");

                }
            }


        }
    }
}
