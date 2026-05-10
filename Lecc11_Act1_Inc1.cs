using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc11_Act1_Inc1
{
    internal class Lecc11_Act1_Inc1
    {
        static void Main(string[] args)
        {
            int cupoMaximo = 200;
            int ocupados = 0;
            int ingresados;

            Console.WriteLine("======= CONTROL DE ESTACIONAMIENTO =======");

            do
            {
                Console.WriteLine("\nCajones disponibles: {0}", cupoMaximo - ocupados);
                Console.Write("Ingrese la cantidad de autos que desean entrar: ");

                if (int.TryParse(Console.ReadLine(), out ingresados))
                {
                    if (ocupados + ingresados <= cupoMaximo)
                    {
                        ocupados += ingresados;
                        Console.WriteLine("Ingreso permitido.");
                    }
                    else
                    {
                        Console.WriteLine("Capacidad insuficiente. Solo quedan {0} espacios.", cupoMaximo - ocupados);
                    }
                }
            } while (ocupados < cupoMaximo);

            Console.WriteLine("\n*******************************************");
            Console.WriteLine("¡CUPO COMPLETO! Estacionamiento lleno.");
            Console.WriteLine("*******************************************");
            Console.ReadKey();
        }
    }
}
