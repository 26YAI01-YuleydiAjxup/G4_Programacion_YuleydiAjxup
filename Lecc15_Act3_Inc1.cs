using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc15_Act3_Inc1
{
    internal class Lecc15_Act3_Inc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione ENTER para iniciar el cálculo de los 20 múltiplos de 7...");
            Console.ReadLine();

            int suma = 0;
            int pares = 0;

            for (int i = 1; i <= 20; i++)
            {
                int m = i * 7;
                suma += m;

                Console.Write("Múltiplo {0}: {1}", i, m);
                if (m % 2 == 0)
                {
                    pares++;
                    Console.WriteLine(" [PAR]");
                }
                else
                {
                    Console.WriteLine(" [IMPAR]");
                }
            }

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine("Suma de múltiplos: " + suma);
            Console.WriteLine("Total de pares: " + pares);
            Console.ReadKey();
        }
    }
}
