using System;

namespace Ejercicio_4._1._2._1
{
    class Program
    { /*Un programa que almacene en una tabla el número de días que tiene cada
        mes (supongamos que es un año no bisiesto), pida al usuario que le indique un mes (1=enero,
        12=diciembre) y muestre en pantalla el número de días que tiene ese mes.*/
        static void Main(string[] args)
        {
            int Mes;

            Console.Write("Indica un mes: ");
            Mes = Convert.ToInt32(Console.ReadLine());

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            int[] diasMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (Mes <= 12 && Mes >= 1)
            {
                Console.WriteLine($"{meses[Mes - 1] } tiene {diasMeses[Mes - 1]} dias!");
            }
            else
                Console.WriteLine("Ingrese un mes valido");

        }
    }
}
