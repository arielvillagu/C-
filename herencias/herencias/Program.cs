﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseHija herencia = new ClaseHija();

            herencia.Saludar();
            herencia.Despedirse();
            Console.ReadKey();
        }
    }
}
