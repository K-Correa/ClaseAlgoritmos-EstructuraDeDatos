using System;

namespace Ejercicio_4._1._3._3
{
    class Program
    {
        /*Un programa que pida al usuario 10 reales de doble precisión, calcule su
            media y luego muestre los que están por encima de la media.
         */
        static void Main(string[] args)
        {
            int n;
            double suma = 0.0;
            Console.Write("Indique la longitud del vector: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write($"Ingrese el {i + 1} numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma = suma + numeros[i];

            }
            double promedio = suma / numeros.Length;
            Console.WriteLine($"\nLa media es: {promedio}");

            Console.WriteLine("\t Elementos mayores a la media.");
            for (int i = 0; i<numeros.Length; i++)
            {
                
                if (promedio < numeros[i])
                    Console.WriteLine($"\n {numeros[i]} ");
            }

            
           
        }
    }
}
