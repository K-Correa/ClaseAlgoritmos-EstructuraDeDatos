using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 200, 150, 100, 50, 300 };
            
            int suma = 0;
            for (int i = 0; i < +numeros.Length; i++)
            {
                suma += numeros[i];
                

                        

                //Console.WriteLine($"La suma del Array es: {suma}");
            }
            double promedio = suma / numeros.Length ;
            Console.WriteLine(promedio);
            
            for(int i = 0; i<numeros.Length; i++)
            {
                if (numeros[i] > promedio)
                    Console.WriteLine(numeros[i]);

            }

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
