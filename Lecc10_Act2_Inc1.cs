using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc10_Act2_Inc1
{
    internal class Lecc10_Act2_Inc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= LOS PRIMEROS 20 MÚLTIPLOS DE 4 =======");

            // El ciclo for va del 1 al 20 para obtener los 20 resultados
            for (int i = 1; i <= 20; i++)
            {
                int multiplo = i * 4;
                Console.WriteLine("Múltiplo {0}: {1}", i, multiplo);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

