using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc15_Act1_Inc1
{
    internal class Lecc15_Act1_Inc1
    {
        static void Main(string[] args)
        {
            int totalDinero = 0;
            int cantAdultos = 0;
            int cantNinos = 0;
            int opcion;

            Console.WriteLine("======= SISTEMA DE VENTAS: RUEDA DE LA FORTUNA =======");

            do
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Vender boleto Adulto ($15)");
                Console.WriteLine("2. Vender boleto Niño ($10)");
                Console.WriteLine("3. Cerrar caja y ver reporte");
                Console.Write("Opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            totalDinero += 15;
                            cantAdultos++;
                            Console.WriteLine("Venta exitosa: Adulto");
                            break;
                        case 2:
                            totalDinero += 10;
                            cantNinos++;
                            Console.WriteLine("Venta exitosa: Niño");
                            break;
                        case 3:
                            Console.WriteLine("Generando reporte...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
            } while (opcion != 3);

            Console.WriteLine("\n*******************************************");
            Console.WriteLine("             REPORTE DEL SUPERVISOR        ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Boletos Adulto vendidos: {0}", cantAdultos);
            Console.WriteLine("Boletos Niño vendidos:   {0}", cantNinos);
            Console.WriteLine("Total de boletos:        {0}", cantAdultos + cantNinos);
            Console.WriteLine("TOTAL COBRADO:           ${0}", totalDinero);
            Console.WriteLine("*******************************************");

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
