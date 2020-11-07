using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[] vector1 = new int[15];
            //double[] vector2 = new double[15];

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine("Digite el valor para el vector en la posicion" + (i + 1));
            //    vector1[i] = int.Parse(Console.ReadLine());
            //    vector2[i] = Math.Pow(vector1[i], 2);
            //    vector1.Append
            //}
            ////impresion de los vectores
            //for (int i = 0; i < 15; i++)
            //{//apertura
            //    if (i == 0) { Console.WriteLine("Vector 1 (original)"); }
            //    Console.WriteLine(vector1[i]);

            //}//cierre
            //for (int i = 0; i < 15; i++)
            //{//apertura
            //    if (i == 0) { Console.WriteLine("Vector 2 elevado a la 2(arreglo resultante) "); }
            //    Console.WriteLine(vector2[i]);

            //}//cierre

            double[] vector = { 1, 2, 3, 4, 5 };
            //int[] vector2 = new int[vector.Length];


            //vector.CopyTo(vector2, 0);
            for (int i = 0; i < vector.Length; i++)
            {
                int pow = (int)Math.Pow(vector[i], 2);
                Console.WriteLine(pow);
            }
            


            Console.ReadKey();
            //int[] numeros = { 200, 150, 100, 50, 300 };

            //int suma = 0;
            //for (int i = 0; i < +numeros.Length; i++)
            //{
            //    suma += numeros[i];




            //    //Console.WriteLine($"La suma del Array es: {suma}");
            //}
            //double promedio = suma / numeros.Length ;
            //Console.WriteLine(promedio);

            //for(int i = 0; i<numeros.Length; i++)
            //{
            //    if (numeros[i] > promedio)
            //        Console.WriteLine(numeros[i]);

            //}

            //Console.WriteLine(suma);
            //for (int i = 0; i<= numeros.Length; i++)
            //{
            //    if (numeros[i] > suma)
            //        Console.WriteLine(i);
            //}
            //  suma = suma / numeros.Length;







            //for (int year = 1994; year <= 2014; year++)
            //{
            //    if (DateTime.IsLeapYear(year))
            //    {
            //        Console.WriteLine("{0} is a leap year.", year);
            //        DateTime leapDay = new DateTime(year, 2, 29);
            //        DateTime nextYear = leapDay.AddYears(1);
            //        Console.WriteLine("   One year from {0} is {1}.",
            //                          leapDay.ToString("d"),
            //                          nextYear.ToString("d"));
            //    }
            //}

        }
    }
}
