using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc15_Act2_Inc2
{
    internal class Lecc15_Act2_Inc2
    {
        static void Main(string[] args)
        {
            int contador100 = 0;
            int sumaTotal = 0;
            int billete = -1; // Inicializamos con un valor que no sea 0

            Console.WriteLine("--- Clasificador de Billetes ---");
            Console.WriteLine("(Escriba 0 para terminar el fajo)");

            for (int i = 1; i <= 1000; i++)
            {
                Console.Write("Billete {0}: ", i);

                // Validamos que sea un número para evitar errores de ejecución
                if (int.TryParse(Console.ReadLine(), out billete))
                {
                    if (billete == 0)
                    {
                        Console.WriteLine("Finalizando conteo por usuario...");
                        break; // Esto sale del ciclo FOR inmediatamente
                    }

                    if (billete == 100)
                    {
                        contador100++;
                        sumaTotal += 100;
                    }
                }
            }

            Console.WriteLine("\n--- RESULTADOS FINALES ---");
            Console.WriteLine("Cantidad de billetes de $100: {0}", contador100);
            Console.WriteLine("Monto acumulado: ${0}", sumaTotal);
            Console.ReadKey();
        }
    }
}
