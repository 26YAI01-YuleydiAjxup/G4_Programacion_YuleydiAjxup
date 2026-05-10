using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc24_Act3_Inc1
{
    internal class Lecc24_Act3_Inc1
    {
        static void Main(string[] args)
        {
            int acumuladorSuma = 0;

            Console.WriteLine("Analizando números primos del 1 al 50...");

            for (int num = 1; num <= 50; num++)
            {
                int divisores = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0) divisores++;
                }

                if (divisores == 2)
                {
                    Console.WriteLine("Primo: {0}", num);
                    acumuladorSuma += num;
                }
            }

            Console.WriteLine("\nSuma acumulada final: {0}", acumuladorSuma);
            Console.ReadKey();
        }
    }
}
