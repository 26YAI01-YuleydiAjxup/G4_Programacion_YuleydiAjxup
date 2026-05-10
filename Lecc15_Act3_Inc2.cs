using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc15_Act3_Inc2
{
    internal class Lecc15_Act3_Inc2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Desea iniciar el análisis del 300 al 1? (s/n)");
            string res = Console.ReadLine().ToLower();

            if (res == "s")
            {
                int contPrimos = 0;
                int sumaPares = 0;

                for (int n = 300; n >= 1; n--)
                {
                    // Sumar pares
                    if (n % 2 == 0) sumaPares += n;

                    // Contar primos
                    int d = 0;
                    for (int j = 1; j <= n; j++)
                    {
                        if (n % j == 0) d++;
                    }
                    if (d == 2) contPrimos++;
                }

                Console.WriteLine("\n*** ANÁLISIS COMPLETADO ***");
                Console.WriteLine("Primos contados: {0}", contPrimos);
                Console.WriteLine("Suma de pares: {0}", sumaPares);
            }
            else
            {
                Console.WriteLine("Análisis omitido.");
            }
            Console.ReadKey();
        }
    }
}
