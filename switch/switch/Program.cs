using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {

            //Switch

            byte dia;
            string diaString;
            Console.WriteLine("Dame un dia: ");
            dia = Convert.ToByte(Console.ReadLine());
            
            switch(dia)
            {
                case 1: Console.WriteLine("Haz elegido el Lunes"); break;
                case 2: Console.WriteLine("Haz elegido el Martes"); break;
                case 3: Console.WriteLine("Haz elegido el Miercoles"); break;
                case 4: Console.WriteLine("Haz elegido el Jueves"); break;
                case 5: Console.WriteLine("Haz elegido el Viernes"); break;
                case 6: Console.WriteLine("Haz elegido el Sabado"); break;
                case 7: Console.WriteLine("Haz elegido el Domingo"); break;
                default: Console.WriteLine("No es un dia"); break;
            }

            //switch acepta cadenas
            Console.WriteLine("Dame un dia: ");
            diaString = Console.ReadLine();
            switch(diaString)
            {
                case "Lunes": Console.WriteLine("Haz elegido el Lunes"); break;
                case "Martes": Console.WriteLine("Haz elegido el Martes"); break;
                case "Miercoles": Console.WriteLine("Haz elegido el Miercoles"); break;
                case "Jueves": Console.WriteLine("Haz elegido el Jueves"); break;
                case "Viernes": Console.WriteLine("Haz elegido el Viernes"); break;
                case "Sabado": Console.WriteLine("Haz elegido el Sabado"); break;
                case "Domingo": Console.WriteLine("Haz elegido el Domingo"); break;
                default: Console.WriteLine("No es un dia"); break;
            }

            Console.ReadKey();

        }
    }
}
