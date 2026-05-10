using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc11_Act2_Inc2
{
    internal class Lecc11_Act2_Inc2
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numero;

            Console.WriteLine("======= DETECTOR DE NÚMEROS IMPARES =======");

            do
            {
                Console.Write("\nIngrese un número para verificar: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero % 2 != 0)
                    {
                        Console.WriteLine("El número {0} es IMPAR.", numero);
                    }
                    else
                    {
                        Console.WriteLine("El número {0} es PAR.", numero);
                    }
                }

                Console.Write("¿Desea ingresar otro número? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s"); // Se repite mientras el usuario diga que sí

            Console.WriteLine("\nPrograma finalizado. ¡Suerte en tu parcial!");
            Console.ReadKey();
        }
    }
}
