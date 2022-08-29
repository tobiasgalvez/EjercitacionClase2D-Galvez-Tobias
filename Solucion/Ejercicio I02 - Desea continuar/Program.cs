using System;

namespace Ejercicio_I02___Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresadoParseado;
            string seguir;

            do
            {
                Console.WriteLine("Ingrese un numero: ");

                numeroIngresadoString = Console.ReadLine();

                while ((int.TryParse(numeroIngresadoString, out numeroIngresadoParseado) != true))
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! :");
                    numeroIngresadoString = Console.ReadLine();

                }

                Console.WriteLine("¿Desea continuar? (S/N): ");
                seguir = Console.ReadLine();

                seguir = seguir.ToUpper();


                while (seguir != "S" && seguir != "N")
                {
                    Console.WriteLine("ERROR. Ingrese (S/N): ");
                    seguir = Console.ReadLine();
                    seguir = seguir.ToUpper();    
                }


            } while (Validador.ValidarRespuesta(seguir) == true);
        }
    }
}
