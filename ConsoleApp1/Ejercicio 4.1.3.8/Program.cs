using System;
using System.Linq;
using System.Reflection;

namespace Ejercicio_4._1._3._8
{
    class Program
    {
        /* Un programa que reserve espacio para un vector de 3 componentes, pida al
            usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y muestre su módulo (raíz cuadrada de
            la suma de sus componentes al cuadrado). */
        static void Main(string[] args)
        {
            double[] arrayNums = new double[3];
            double numberSquared = 0,module;
            double sum = 0;

            for (int i = 0; i <= arrayNums.Length - 1; i++)
            {
                Console.Write($"{i + 1}Ingrese un numero: ");
                arrayNums[i] = Convert.ToDouble(Console.ReadLine());

                numberSquared = Math.Pow(arrayNums[i], 2);
                sum = sum + numberSquared;


            }
            module = Math.Sqrt(sum);
            Console.WriteLine("El modulo es {0:f3}",module);
           

          

        }
    }
}
