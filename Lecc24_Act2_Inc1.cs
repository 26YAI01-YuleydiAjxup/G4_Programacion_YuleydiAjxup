using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc24_Act2_Inc1
{
    internal class Lecc24_Act2_Inc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= GENERADOR DE 20 MÚLTIPLOS =======");
            Console.Write("Ingrese un número para calcular sus múltiplos: ");

            // Interacción y validación de entrada
            if (int.TryParse(Console.ReadLine(), out int baseNum))
            {
                Console.WriteLine("\nCalculando los primeros 20 múltiplos de {0}...", baseNum);
                Console.WriteLine("---------------------------------------");

                for (int i = 1; i <= 20; i++)
                {
                    int multiplo = baseNum * i;
                    Console.WriteLine("Múltiplo {0}: {1}", i, multiplo);
                }

                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("Error: Por favor, ingrese un número entero válido.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
