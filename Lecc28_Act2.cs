using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc28_Act2
{
    internal class Lecc28_Act2
    {
        static void Main(string[] args)
        {
            int cantBoletos = 0;
            int totalCobrado = 0;
            int opcion = -1;

            Console.WriteLine("======= SISTEMA DE VENTAS - FERIA =======");
            Console.WriteLine("Opciones: [1] Niño $10 | [2] Adulto $15 | [0] Salir");

            while (opcion != 0)
            {
                Console.Write("\nIngrese opción de boleto: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            cantBoletos++;
                            totalCobrado += 10;
                            Console.WriteLine("Venta: NIÑO registrada.");
                            break;
                        case 2:
                            cantBoletos++;
                            totalCobrado += 15;
                            Console.WriteLine("Venta: ADULTO registrada.");
                            break;
                        case 0:
                            Console.WriteLine("Finalizando jornada...");
                            break;
                        default:
                            Console.WriteLine("¡Opción inválida!");
                            break;
                    }

                    // Mostrar resultados en cada repetición según lo solicitado
                    Console.WriteLine("--> Boletos vendidos: {0}", cantBoletos);
                    Console.WriteLine("--> Total cobrado: ${0}", totalCobrado);
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese solo números (1, 2 o 0).");
                }
            }

            Console.WriteLine("\n=======================================");
            Console.WriteLine("REPORTE PARA EL SUPERVISOR");
            Console.WriteLine("Boletos Totales: " + cantBoletos);
            Console.WriteLine("Monto Recaudado: $" + totalCobrado);
            Console.WriteLine("=======================================");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
