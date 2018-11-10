using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //while

            bool encender = false;

            /*while(encender)
            {
                Console.WriteLine("Hola a todos!...");
            }*/
            do
            {
                Console.WriteLine("Hola a todos!...");
            } while (encender);
            Console.ReadKey();
        }
    }
}
