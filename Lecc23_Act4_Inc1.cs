using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc23_Act4_Inc1
{
    internal class Lecc23_Act4_Inc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= GENERADOR DE TABLAS DE MULTIPLICAR =======");
            Console.Write("Ingrese el número que desea multiplicar: ");

            // Leemos la entrada del usuario y validamos que sea un número
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("\nTabla del {0}:", numero);
                Console.WriteLine("--------------------------");

                // El ciclo va del 1 al 10 para generar la tabla estándar
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    // Mostramos el formato: N x i = R
                    Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
                }

                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("Error: Por favor, ingrese un número entero válido.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
