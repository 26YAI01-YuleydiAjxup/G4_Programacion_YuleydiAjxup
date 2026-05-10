using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc10_Act1_Inc1
{
    internal class Lecc10_Act1_Inc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Cuponera *******");
            Console.WriteLine();

            // Iniciamos el ciclo 'for' desde 1 hasta 8
            // i++ incrementa el valor de 1 en 1 en cada iteración
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Presione una tecla para marcar el sello número: {0}", i);

                Console.ReadKey(true);

                Console.WriteLine("¡Sello {0}! marcado...", i);
                Console.WriteLine("____________________________________");
                Console.WriteLine();
            }

            // Mensaje final al completar la iteración definida
            Console.WriteLine("¡Felicidades! has completado los 8 sellos.");
            Console.WriteLine("¡CORTE DE PELO GRATIS!");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
