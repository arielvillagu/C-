using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresAsignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores asignacion

            byte edad = 20;

            //edad = Convert.ToByte(edad + 10);

            edad += 10;

            Console.WriteLine("Tu edad es : " + edad);

            Console.ReadKey();
        }
    }
}
