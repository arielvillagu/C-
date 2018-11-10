using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            //Operadores relacionales < > = != <= >= ==

            double peso;

            Console.WriteLine("Digita tu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            if(peso > 100)
            {
                Console.WriteLine("Tu peso es normal");
            }
            if (peso <= 100)
            {
                Console.WriteLine("Tu peso es bajo");
            }
            if (peso == 100)
            {
                Console.WriteLine("Tu peso es el mismo");
            }

            //Operadores logicos && ||
            byte edad;
            Console.WriteLine("Digita tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            if (peso > 100 && edad >= 15)
            {
                Console.WriteLine("Tu peso es &&");
            }
            if (peso > 100 || edad >= 15)
            {
                Console.WriteLine("Tu peso es ||");
            }
            Console.ReadKey();
        }
    }
}
