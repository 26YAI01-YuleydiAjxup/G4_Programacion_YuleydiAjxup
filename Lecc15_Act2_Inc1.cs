using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc15_Act2_Inc1
{
    internal class Lecc15_Act2_Inc1
    {
        static void Main(string[] args)
        {
            int contadorPrimos = 0;
            int sumaPrimos = 0;
            string respuesta;

            Console.WriteLine("======= CONTADOR DE PRIMOS =======");

            do
            {
                Console.Write("\nIngrese un número: ");
                int num = int.Parse(Console.ReadLine());
                int divisores = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0) divisores++;
                }

                if (divisores == 2)
                {
                    Console.WriteLine("Es primo.");
                    contadorPrimos++;
                    sumaPrimos += num;
                }
                else
                {
                    Console.WriteLine("No es primo.");
                }

                Console.Write("¿Otro número? (s/n): ");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "s");

            Console.WriteLine("\nPrimos encontrados: {0}", contadorPrimos);
            Console.WriteLine("Suma total: {0}", sumaPrimos);
            Console.ReadKey();
        }
    }
}
