using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc24_Act3_Inc2
{
    internal class Lecc24_Act3_Inc2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= CUENTA REGRESIVA =======");
            Console.Write("Ingrese un número entero inicial: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int suma = 0;
                Console.WriteLine("\nIniciando secuencia:");

                for (int i = n; i >= 1; i--)
                {
                    Console.WriteLine(i);
                    suma += i;
                }

                Console.WriteLine("--------------------------------");
                Console.WriteLine("La suma es: {0}", suma);
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número válido.");
            }

            Console.ReadKey();
        }
    }
}
