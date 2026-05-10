using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc9_Act4_Inc1
{
    internal class Lecc9_Act4_Inc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= TABLAS DE MULTIPLICAR =======");
            Console.Write("Ingrese el número de la tabla que desea ver: ");
            if (int.TryParse(Console.ReadLine(), out int tabla))
            {
                Console.WriteLine("\nTabla del {0}:", tabla);
                // El ciclo for se repite exactamente 10 veces
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = tabla * i;
                    Console.WriteLine("{0} x {1} = {2}", tabla, i, resultado);
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número entero válido.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
