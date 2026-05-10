using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc10_Act3_Inc1
{
    internal class Lecc10_Act3_Inc1
    {
        static void Main(string[] args)
        {
            int sumaTotal = 0;
            int numeroIngresado;

            Console.WriteLine("======= SUMA DE NÚMEROS PRIMOS INGRESADOS =======");
            Console.WriteLine("El rango es del 1 al 22.");

            // El ciclo se repite para permitir el ingreso de números en el rango
            for (int i = 1; i <= 22; i++)
            {
                Console.Write("{0}. Ingrese un número: ", i);
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    int divisores = 0;
                    // Verificamos si el número ingresado es primo
                    for (int j = 1; j <= numeroIngresado; j++)
                    {
                        if (numeroIngresado % j == 0)
                        {
                            divisores++;
                        }
                    }

                    if (divisores == 2)
                    {
                        sumaTotal += numeroIngresado;
                        Console.WriteLine(" {0} es primo. Suma actual: {1}", numeroIngresado, sumaTotal);
                    }
                    else
                    {
                        Console.WriteLine(" {0} no es primo. No se suma.", numeroIngresado);
                    }
                }
            }

            Console.WriteLine("\nSuma final de números primos: " + sumaTotal);
            Console.ReadKey();
        }
    }
}
