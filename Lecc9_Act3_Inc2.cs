using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc9_Act3_Inc2
{
    internal class Lecc9_Act3_Inc2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para verificar si es primo: ");
            int numero = int.Parse(Console.ReadLine());
            int contadorDivisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contadorDivisores++;
                }
            }

            if (contadorDivisores == 2) // Solo es primo si tiene exactamente 2 divisores (1 y él mismo)
            {
                Console.WriteLine("El número {0} es primo.", numero);
            }
            else
            {
                Console.WriteLine("El número {0} no es primo.", numero);
            }
            Console.ReadKey();
        }
    }
}
