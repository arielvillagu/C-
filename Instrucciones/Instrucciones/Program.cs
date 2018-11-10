using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
// using System.Threading; Agrege esa libreria para usar una funcion llamada sleep
namespace Instrucciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //break

            /*for(int i=1;i<=10;i++)
            {
                Thread.Sleep(800);
                Console.WriteLine(i);
                if(i==5)
                {
                    break;
                }
            }*/

            //Continue
            /*for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(800);
                if (i == 8)
                {
                    //Me saltea el 8
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine(i);
            }*/
            
            //Goto
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(800);
                if (i == 8)
                {
                    goto liquidacion;
                }
                Console.WriteLine(i);
            }

        liquidacion:
            Console.WriteLine("Se envio al departamento de contabilidad... ");
            Console.ReadKey();
        }
    }
}
