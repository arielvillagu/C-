using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //For simple

            for (int i=1; i<=5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            char letra;
            for (letra = 'a'; letra <= 'z'; letra++)
            {
                Console.WriteLine(letra);
            }
            Console.ReadKey();

            //For anidado

            for(int b=1; b<=5;b++)
            {
                for(int y = 1; y <=5; y++)
                {
                    Console.WriteLine("Hola a todos");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            //Foreach
            string nombre = "learnwtutorials";

            foreach(char letra2 in nombre)
            {
                Console.Write(" " + letra2 + " ");
            }
            Console.ReadKey();
        }
    }
}
