using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//using System.IO; Archivos

namespace archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear archivo
            /*TextWriter archivo;

            archivo = new StreamWriter("archivo.txt");

            string mensaje;

            mensaje = Console.ReadLine();

            archivo.WriteLine(mensaje);

            archivo.Close();

            Console.Clear();

            Console.WriteLine("Se ha guardado el archivo...");
            */

            /*TextReader leerArchivo;

            leerArchivo = new StreamReader("archivo.txt");

            //Console.WriteLine(leerArchivo.ReadLine());
            Console.WriteLine(leerArchivo.ReadToEnd());

            leerArchivo.Close();*/

            StreamWriter archivo = File.AppendText("archivo.txt");

            string mensaje;

            mensaje = Console.ReadLine();

            archivo.WriteLine("\n"+mensaje);

            archivo.Close();

            Console.ReadKey();
        }
    }
}
