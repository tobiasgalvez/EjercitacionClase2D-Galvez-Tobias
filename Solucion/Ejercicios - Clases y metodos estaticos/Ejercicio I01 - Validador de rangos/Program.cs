using System;

namespace Ejercicio_I01___Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresadoParseado;
            int numeroMaximoIngresado=0;
            int numeroMinimoIngresado=0;
            int acumuladorNumerosIngresados = 0;
            float promedioDeNumerosIngresados=0;


            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                numeroIngresadoString = Console.ReadLine();

                while ((int.TryParse(numeroIngresadoString, out numeroIngresadoParseado) != true) || Validador.Validar(numeroIngresadoParseado, -100, 100) != true)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! :");
                    numeroIngresadoString = Console.ReadLine();

                }

                if(i==0||numeroIngresadoParseado > numeroMaximoIngresado)
                    numeroMaximoIngresado = numeroIngresadoParseado;

                if(i == 0 || numeroIngresadoParseado < numeroMinimoIngresado)
                    numeroMinimoIngresado = numeroIngresadoParseado;

                acumuladorNumerosIngresados += numeroIngresadoParseado;
                

            }

            promedioDeNumerosIngresados = (float)acumuladorNumerosIngresados / 10;


            Console.WriteLine($"Valor minimo ingresado: {numeroMinimoIngresado}");
            Console.WriteLine($"Valor maximo ingresado: {numeroMaximoIngresado}");
            Console.WriteLine($"Promedio de numeros ingresados: {promedioDeNumerosIngresados}");


        }
    }
}
