using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            double precio, total;
            int cantidad;

            

            //try... catch

            try
            {
                Console.WriteLine("Cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Precio: ");
                precio = Convert.ToDouble(Console.ReadLine());

                total = cantidad * precio;

                Console.WriteLine("El total es: " + total);
            }
            catch(Exception error)
            {
                Console.WriteLine("Ha ocurrido un error " + error.Message);
            }
            //Otros tipos de Exception: FormatException y DivideByZeroException
            Console.ReadKey();
        }
    }
}
