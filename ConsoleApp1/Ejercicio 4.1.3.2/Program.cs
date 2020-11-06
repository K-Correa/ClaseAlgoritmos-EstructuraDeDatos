using System;
using System.Reflection.PortableExecutable;

namespace Ejercicio_4._1._3._2
{
    class Program
    {
        /*Crea un programa que pregunte al usuario cuántos números enteros va a
        introducir(por ejemplo, 10), le pida todos esos números, los guarde en un array y finalmente calcule y
        muestre la media de esos números.*/
        static void Main(string[] args)
        {
            int pedidos;
            double sumAritmetica = 0.0;
            Console.Write("Indique la longitud del vector: ");
            pedidos = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[pedidos];

            for (int i = 0; i <= pedidos - 1; i++)
            {
                Console.Write($"Ingrese el {i + 1} numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                sumAritmetica = sumAritmetica + numeros[i];

            }
            sumAritmetica = sumAritmetica / numeros.Length;
            Console.WriteLine(sumAritmetica);

        }
    }
}
