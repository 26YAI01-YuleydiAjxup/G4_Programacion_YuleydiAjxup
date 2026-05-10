using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc11_Act3_Inc2
{
    internal class Lecc11_Act3_Inc2
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero;

            Console.WriteLine("======= SUMA INTERACTIVA (Escribe 9 para salir) =======");

            do
            {
                Console.Write("Ingrese un número para sumar: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 9)
                {
                    suma += numero;
                    Console.WriteLine("Suma actual: {0}", suma);
                }

            } while (numero != 9);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Proceso terminado. Suma total final: {0}", suma);
            Console.WriteLine("-------------------------------------------");
            Console.ReadKey();
        }
    }
}
