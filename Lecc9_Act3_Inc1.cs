using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc9_Act3_Inc1
{
    internal class Lecc9_Act3_Inc1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número mayor a 20: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Números impares entre 20 y " + n + ":");
            // Iniciamos en 20 y evaluamos cada número hasta llegar a n
            for (int i = 20; i <= n; i++)
            {
                if (i % 2 != 0) // Si el residuo de la división entre 2 no es 0, es impar
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
