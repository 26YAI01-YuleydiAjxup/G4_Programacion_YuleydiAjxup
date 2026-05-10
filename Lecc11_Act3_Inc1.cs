using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc11_Act3_Inc1
{
    internal class Lecc11_Act3_Inc1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int menor = Math.Min(n1, n2);
            int mayor = Math.Max(n1, n2);
            int suma = 0;
            int i = menor;

            // Usamos Do-While para recorrer el rango
            do
            {
                suma += i;
                i++;
            } while (i <= mayor);

            Console.WriteLine("La suma de los números entre {0} y {1} es: {2}", menor, mayor, suma);
            Console.ReadKey();
        }
    }
}
