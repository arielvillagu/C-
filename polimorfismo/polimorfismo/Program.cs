using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            figuraRectangulo rectangulo = new figuraRectangulo();

            rectangulo.Area(34,56);

            figuraTriangulo triangulo = new figuraTriangulo();

            triangulo.Area(34,56);

            Console.ReadKey();
        }
    }
}
