using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class figuraTriangulo : figuraRectangulo
    {
        public void Area(int Base, int Altura, int radio)
        {
            Console.WriteLine("El area del triangulo es: " + (Base * Altura) / 2);
        }
    }
}
