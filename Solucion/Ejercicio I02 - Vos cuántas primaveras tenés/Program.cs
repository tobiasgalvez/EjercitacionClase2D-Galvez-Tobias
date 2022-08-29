using System;

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];

            personas[0] = new Persona("Tobias", "10/10/2002", 44521134);
            personas[1] = new Persona("Lola", "12/01/2009", 56754432);
            personas[2] = new Persona("Chantal", "17/04/2000" , 42543231);

            for(int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine($"{personas[i].nombre} {personas[i].EsMayorDeEdad()}");

            }

            Console.WriteLine("Datos de las personas");
            for(int i=0; i< personas.Length; i++)
            {
                Console.WriteLine($"{personas[i].Mostrar()}");
            }
        }
    }
}
