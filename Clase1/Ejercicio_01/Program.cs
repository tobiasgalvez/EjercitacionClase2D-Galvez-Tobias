using System;

namespace Ejercicio_01
{
    internal class Program
    {

        /*
         Consigna
        Ingresar 5 números por consola, guardándolos en una variable escalar. 
        Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/


        static void Main(string[] args)
        {
            string numeroStr;
            int numero=0;
            bool res;

            int max = 0;
            int min = 0;

            int acum = 0;

            float promedio = 0f;

            for(int i= 0; i<5; i++)
            {
               Console.WriteLine("Ingrese un numero: ");
               numeroStr = Console.ReadLine();
               res = int.TryParse(numeroStr, out numero);

               if (res == true)
                {
                    acum += numero;

                    if(i == 0)
                    {
                        min = numero;
                        max = numero;
                    }
                    else
                    {
                        if(max < numero)
                        {
                            max = numero;
                        }
                        if(min > numero)
                        {
                            min = numero;
                        }
                    }
                }
            }

            promedio = (float)(acum / 5);

            Console.WriteLine($"Valor máximo = {max} --- Valor mínimo = {min} --- Promedio = {promedio} ");
            //Console.WriteLine($"Valor mínimo = {min}");
            //Console.WriteLine($"Promedio ={promedio}");

        }
    }
}
