using System;
using System.Runtime.CompilerServices;

namespace Ejercicio_4._1._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que prepare espacio para guardar un máximo de 100 nombres.
            El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, momento
            en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han
            introducido.*/


            string[] names = new string[100];
            //string optionUser = "";
            //string searchingName = "";


            for (int i = 1; i < names.Length + 1; i++)
            {
                Console.Write("Nombre {0}:", i);
                names[i] = Console.ReadLine();

                Console.WriteLine("Presione enter 2 veces para detener la peticion!");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    continue; 
                }
            }
            
            Console.WriteLine("\t Nombres introducidos al momento... ");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            //Console.Write("Que nombre desea buscar? ");
            //searchingName = Console.ReadLine();

            //int index = Array.IndexOf(names, searchingName);
            //Console.WriteLine($"El nombre {searchingName} se encuentra en la posicion {index}");
        }
    }
}
