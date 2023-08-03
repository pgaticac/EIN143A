using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte unByte = 10;
            int unInt = 32000;
            string unString = "123a";

            //unInt = unByte;
            unByte = (byte)unInt;
            // unInt = int.Parse(unString);
           bool exito = int.TryParse(unString, out unInt);

            if (exito)
            {
                Console.WriteLine("Parseo exitoso");
            }
            else
            {
                Console.WriteLine("Parseo fallido");
            }

            Console.WriteLine("El valor de la variable int es: " + unInt);
            Console.WriteLine("El valor de la variable byte es: " + unByte);
           
            /*--------------------------------*/
            int n1, n2, res;

            Console.Write("Ingresa un número: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("\nIngresa otro número: ");
            int.TryParse(Console.ReadLine(), out n2);

            res = n1 + n2;

            Console.WriteLine("La suma de los números es: " + res);

                                 
            Console.ReadKey();
        }
    }
}
