using System;

namespace Ejercicio_05___Tirame_un_centro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresadoParseado;
            int numeroInicial = 1;
            int sumaNumerosAnteriores = 0;
            int sumaNumerosPosteriores = 1;

            string listaNumerosAnteriores="";
            string listaNumerosPosteriores="";

            Console.WriteLine("Ingrese un numero (mayor a 1): ");
            numeroIngresadoString = Console.ReadLine();
            while ((int.TryParse(numeroIngresadoString, out numeroIngresadoParseado) != true || numeroIngresadoParseado < 1))
            {
                Console.WriteLine("ERROR. ¡Opcion Invalida! Reingrese :");
                numeroIngresadoString = Console.ReadLine();
            }
            do
            {
                for(int i = 0; i < numeroInicial; i++)
                {
                    sumaNumerosAnteriores += i;
                    listaNumerosAnteriores += i + " | ";
                }
                for(int i=numeroInicial+1; i< numeroInicial * 2; i++)
                {
                    if(sumaNumerosAnteriores == sumaNumerosPosteriores)
                    {
                        Console.WriteLine($"{numeroInicial} es un centro numérico");
                        Console.WriteLine($"Lista de numeros anteriores al centro numerico: {listaNumerosAnteriores}");
                        Console.WriteLine($"Lista de numeros posteriores al centro numerico: {listaNumerosPosteriores}");
                        break;
                    }
                    else
                    {
                        sumaNumerosPosteriores += i;
                        listaNumerosPosteriores += i + " | ";
                        
                    }
                }

                numeroInicial = numeroInicial + 1;
                sumaNumerosAnteriores = 0;
                sumaNumerosPosteriores = 0;
                listaNumerosAnteriores = " ";
                listaNumerosPosteriores = " ";
            } while (numeroInicial < numeroIngresadoParseado + 1);

        }
    }
}
