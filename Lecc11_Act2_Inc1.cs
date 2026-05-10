using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc11_Act2_Inc1
{
    internal class Lecc11_Act2_Inc1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;
            int i = n;

            if (n >= 0)
            {
                do
                {
                    if (n == 0) break;
                    factorial *= i;
                    i--;
                } while (i > 0);
                Console.WriteLine("El factorial de {0} es: {1}", n, factorial);
            }
            Console.ReadKey();
        }
    }
}
