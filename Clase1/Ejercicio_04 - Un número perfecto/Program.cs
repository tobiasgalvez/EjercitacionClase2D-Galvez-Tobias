using System;

namespace Ejercicio_04___Un_número_perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos=0;
            int i=1;
            int[] arrayNumerosPerfectos = new int[4];
            int sumaDeDivisores = 0;


            do
            {

                sumaDeDivisores = 0;
                i++;
               // Console.WriteLine("Valor de i {0}" , i);

                for(int j=1; j<=i-1; j++)
                {
                    if(i%j==0)
                    {
                        sumaDeDivisores = sumaDeDivisores + j;//ejemplo: si 'i' vale 6 , entra 3 veces (6%1==0 ; 6%2==0; 6%3==0) y la suma de sus divisores (1+2+3) es igual a 6
                        //Console.WriteLine("suma de divisores: {0}" , sumaDeDivisores);
                    }

                }
                    if(sumaDeDivisores == i)//si es un numero perfecto... 
                    {
                        arrayNumerosPerfectos[contadorNumerosPerfectos] = i; //copio el numero perfecto en el array 
                        contadorNumerosPerfectos++;//incremento el contador de numeros perfectos
                   // Console.WriteLine("hola");
                    }
                    
            } while (contadorNumerosPerfectos != 4);//el do while itera mientras haya menos de 4 numeros perfectos. Cuando hay 4, termina

           

            

            

            Console.WriteLine("Los 4 primeros numeros perfectos son:");
            for(int k=0; k<arrayNumerosPerfectos.Length; k++)
            {
                Console.WriteLine($"{arrayNumerosPerfectos[k]}");// muestro los 4 numeros perfectos que están contenidos en el array
            }


        }
    }
}
