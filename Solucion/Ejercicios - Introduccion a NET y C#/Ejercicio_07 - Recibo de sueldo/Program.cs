using System;

namespace Ejercicio_07___Recibo_de_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string horaIngresadaString;
            int horaIngresadaParseada;

            string nombreIngresado;

            string antiguedadIngresadaString;
            int antiguedadIngresadaParseada;

            string cantidadHorasTrabajadasString;
            int cantidadHorasTrabajadasParseada;

            int montoACobrar = 0;

            int montoTotalACobrarEnBruto = 0;
            float montoTotalACobrarNeto = 0;

            string seguir = "si";

            do
            {
                Console.WriteLine("Ingrese Hora: ");
                horaIngresadaString = Console.ReadLine();
                while ((int.TryParse(horaIngresadaString, out horaIngresadaParseada) != true) || horaIngresadaParseada <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar hora! :");
                    horaIngresadaString = Console.ReadLine();

                }

                Console.WriteLine("Ingrese nombre de empleado: ");
                nombreIngresado = Console.ReadLine();


                Console.WriteLine("Ingrese antiguedad (en años): ");
               antiguedadIngresadaString = Console.ReadLine();
                while ((int.TryParse(antiguedadIngresadaString, out antiguedadIngresadaParseada) != true) || antiguedadIngresadaParseada <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar antiguedad! :");
                    antiguedadIngresadaString = Console.ReadLine();

                }

                Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
                cantidadHorasTrabajadasString = Console.ReadLine();
                while ((int.TryParse(cantidadHorasTrabajadasString, out cantidadHorasTrabajadasParseada) != true) || cantidadHorasTrabajadasParseada <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar cantidad de horas trabajadas! :");
                    cantidadHorasTrabajadasString = Console.ReadLine();

                }


                montoACobrar = horaIngresadaParseada * cantidadHorasTrabajadasParseada;

                montoTotalACobrarEnBruto = montoACobrar + (cantidadHorasTrabajadasParseada * 150);

                montoTotalACobrarNeto = ((float)(montoTotalACobrarEnBruto - (montoTotalACobrarEnBruto * 0.13)));

                Console.WriteLine($"Nombre: {nombreIngresado}");
                Console.WriteLine($"Antigüedad: {antiguedadIngresadaParseada}");
                Console.WriteLine($"Valor hora: {horaIngresadaParseada}");
                Console.WriteLine($"Total a cobrar en bruto: {montoTotalACobrarEnBruto}");
                Console.WriteLine($"Total a cobrar neto: {montoTotalACobrarNeto}");


                Console.WriteLine("Desea seguir ingresando empleados? (si/salir):");
                seguir = Console.ReadLine();
                while (seguir != "si" && seguir != "salir")
                {
                    Console.WriteLine("ERROR. Ingrese si/salir: ");
                    seguir = Console.ReadLine();

                }




            } while (seguir == "si");
            
        }
    }
}
