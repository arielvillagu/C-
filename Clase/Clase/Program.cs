using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            ventana calculadora = new ventana();

            calculadora.Cerrar();

            Console.ReadKey();
        }
    }


    class ventana
    {
        //Atributos
        //public int ancho;
        private int ancho=15,altura=20;
        //static int ancho;
        //protected int ancho;
        private string color = "Rojo";

        //Metodos

        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerro!..");
        }

        private void Minimizar()
        {
            Console.WriteLine("La ventana se minimizo!..");
        }

        public void Maximizar()
        {
            Console.WriteLine("La ventana se agrando");
        }
    }
}
