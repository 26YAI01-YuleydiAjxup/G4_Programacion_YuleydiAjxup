using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc9_Act2
{
    internal class Lecc9_Act2
    {
        static void Main(string[] args)
        {
            int monedasTotales = 0;
            int nuevasMonedas = 0;
            const int META_MONEDAS = 350;

            Console.WriteLine("======= NIVEL 5: BLOQUEADO =======");
            Console.WriteLine("Necesitas {0} monedas para entrar.", META_MONEDAS);

            // El ciclo se repite mientras las monedas sean menores a 350 [cite: 12, 18]
            while (monedasTotales < META_MONEDAS)
            {
                Console.WriteLine("\nMonedas actuales: {0}", monedasTotales);
                Console.WriteLine("Faltan {0} monedas.", META_MONEDAS - monedasTotales);
                Console.Write("¿Cuántas monedas recolectaste en esta partida?: ");

                if (int.TryParse(Console.ReadLine(), out nuevasMonedas))
                {
                    monedasTotales += nuevasMonedas;
                }
                else
                {
                    Console.WriteLine("Error: Ingresa un número válido.");
                }
            }

            Console.WriteLine("\n**********************************");
            Console.WriteLine("¡FELICIDADES! Tienes {0} monedas.", monedasTotales);
            Console.WriteLine("¡NIVEL 5 DESBLOQUEADO!");
            Console.WriteLine("**********************************");

            Console.ReadKey();
        }
    }
}
