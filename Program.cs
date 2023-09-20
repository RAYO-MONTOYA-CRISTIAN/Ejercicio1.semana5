using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            for (int i = 0; i < (num2); i++)
            {
                resultado += (num1);
            }

            Console.WriteLine("El producto es: " + resultado);
            Console.ReadKey();



        }
    }
}
