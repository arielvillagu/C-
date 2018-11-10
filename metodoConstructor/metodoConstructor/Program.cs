using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ventana calculadora = new ventana();
            calculadora.Mostrar();
            Console.ReadKey();
        }
    }
    class ventana
    {
        //Atributos

        private int ancho, altura;
        private string color;

        //Esto lo va a cargar primero que todo. Inicializa valores. Constructor
        public ventana()
        {
            ancho = 15;
            altura = 20;
            color = "Rojo";
            Console.WriteLine("Funciona!");
        }

        public void Mostrar()
        {
            Console.WriteLine("La dimension de la ventana es: " + ancho + "x" + altura +  " Y su color es: " + color);
        }
        ~ventana()
        {
            System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos");
        }
    }
}
