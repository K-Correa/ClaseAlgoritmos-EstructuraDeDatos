using System;
using System.Linq;

namespace Ejercicio_4._1._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida 10 nombres y los memorice(pista: esta vez se trata
            de un array de "string"). Después deberá pedir que se teclee un nombre y dirá si se encuentra o no entre
            los 10 que se han tecleado antes.Volverá a pedir otro nombre y a decir si se encuentra entre ellos, y así
            sucesivamente hasta que se teclee "fin".*/

            string[] names =new string [10];
            string optionUser = "";
            string searchingName = "";


            for (int i = 1; i<names.Length + 1; i++)
            {
                Console.Write("Nombre {0}:", i);
                names[i] = Console.ReadLine();

                Console.Write("Presione enter para continuar / escriba fin para detener la peticion!");
                optionUser = Console.ReadLine();
                if (optionUser == "fin")
                    break;
            }

            Console.Write("Que nombre desea buscar? ");
            searchingName = Console.ReadLine();

            int index = Array.IndexOf(names, searchingName);
            Console.WriteLine($"El nombre {searchingName} se encuentra en la posicion {index}");
                
        }
    }
}
