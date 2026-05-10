using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc10_Act2_Inc2
{
    internal class Lecc10_Act2_Inc2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número mayor a 2: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("\nNúmeros pares entre 2 y {0}:", n);
                // Iniciamos en 2 y sumamos 2 en cada vuelta (i += 2)
                for (int i = 2; i <= n; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número entero válido.");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
