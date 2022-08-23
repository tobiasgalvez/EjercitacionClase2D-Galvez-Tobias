using System;


/*Consigna
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: 
"ERROR. ¡Reingresar número!".*/

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
           

            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = Console.ReadLine();

            while((int.TryParse(numeroIngresado, out numero) != true))
            {
                Console.WriteLine("ERROR. ¡Reingresar número! :");
                numeroIngresado = Console.ReadLine();
                
            }
           
        }
    }
}
