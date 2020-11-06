using System;
using System.Linq;

namespace Ejercicio_4._1._3._1
{
    class Program
    { /*Crea un programa que pida al usuario 6 números enteros cortos y luego los
        muestre en orden inverso (pista: usa un array para almacenarlos y "for" para mostrarlos).*/
        static void Main(string[] args)
        {
            int[] numeros = { 0, 2, 3, 4, 5 };

            for(int i = 0; i<= numeros.Length; i++)
            {
                Console.WriteLine($"Array ordenado: {i}");

            }
            Console.WriteLine("\t");
            for (int j = numeros.Length; j >= 0; j--)
            {
                Console.WriteLine($"Array inverso: {j}");
            }
        }
    }
}
