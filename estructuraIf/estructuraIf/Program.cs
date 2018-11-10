using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuraIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estructura if

            byte juan = 20, pedro = 19, jorge=25;

            if (juan > pedro)
            {
                Console.WriteLine("Juan es mayor que pedro");
                if(jorge > juan)
                {
                    Console.WriteLine("Jorge es el mayor de todos");
                }
            }
            else if(juan < pedro)
            {
                Console.WriteLine("Juan es menor de Pedro");
            }
            else
            {
                Console.WriteLine("Tienen la misma edad");
            }
            Console.ReadKey();
        }
    }
}
