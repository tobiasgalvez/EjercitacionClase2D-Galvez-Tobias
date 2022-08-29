using System;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string montoARetirarIngresadoString;
            float montoARetirarIngresadoParseado;

            string montoADepositarIngresadoString;
            float montoADepositarIngresadoParseado;

            string opcionIngresadaString;
            int opcionIngresadaParseado;

            string seguir;

            Cuenta cuenta1 = new Cuenta("HolaBuenDia" , (float)150000.75);

            do
            {
                Console.Clear();

                Console.WriteLine(
                            "1.Mostrar datos de la cuenta\n" +
                            "2.Ingresar monto para acreditar a la cuenta\n" +
                            "3.Retirar monto para debitar de la cuenta\n" +
                            "Ingrese una opcion:");
            opcionIngresadaString = Console.ReadLine();
            while((int.TryParse(opcionIngresadaString, out opcionIngresadaParseado) != true || (opcionIngresadaParseado <1 ) && opcionIngresadaParseado >3))
                {
                Console.WriteLine("ERROR. ¡Opcion Invalida! Reingrese :");
                opcionIngresadaString = Console.ReadLine();
            }
            

            switch(opcionIngresadaParseado)
            {
                case 1:
                    Console.WriteLine($"{cuenta1.Mostrar()}");
                    break;
                case 2:
                    Console.WriteLine($"Saldo actual: {cuenta1.cantidad}");
                    Console.WriteLine("Ingrese monto a depositar : ");
                    montoADepositarIngresadoString = Console.ReadLine();
                    while ((float.TryParse(montoADepositarIngresadoString, out montoADepositarIngresadoParseado) != true))
                    {
                        Console.WriteLine("ERROR. ¡Reingrese monto! :");
                        montoARetirarIngresadoString = Console.ReadLine();

                    }
                        Console.WriteLine($"Saldo anterior: {cuenta1.cantidad}");
                        cuenta1.Ingresar(montoADepositarIngresadoParseado);
                        Console.WriteLine($"Saldo actual: {cuenta1.cantidad}");
                     break;

                case 3:
                    Console.WriteLine($"Saldo actual: {cuenta1.cantidad}");
                    Console.WriteLine("Ingrese monto a retirar: ");
                    montoARetirarIngresadoString = Console.ReadLine();
                    while ((float.TryParse(montoARetirarIngresadoString, out montoARetirarIngresadoParseado) != true) || montoARetirarIngresadoParseado > cuenta1.cantidad)
                    {
                        Console.WriteLine("ERROR. ¡Reingrese monto! :");
                        montoARetirarIngresadoString = Console.ReadLine();

                    }
                    Console.WriteLine($"Saldo anterior: {cuenta1.cantidad}");
                    cuenta1.Retirar(montoARetirarIngresadoParseado);
                    Console.WriteLine($"Saldo actual: {cuenta1.cantidad}");
                    break;

            }

                Console.WriteLine("Desea continuar? (si/no):");
                seguir = Console.ReadLine();
                while (seguir != "si" && seguir != "no")
                {
                    Console.WriteLine("ERROR. Ingrese si/no: ");
                    seguir = Console.ReadLine();

                }
            } while (seguir == "si");


            Console.WriteLine("Gracias por utilizar nuestro programa!!!");

                 
        }
    }
}
