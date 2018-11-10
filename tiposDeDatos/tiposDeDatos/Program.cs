using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 - 255
            byte variable = 230;

            //Enteras - Va desde -2147,483,648 al 2147,483,647
            int variableInt = 2147483647;

            //Double - Tipo flotante
            double variableDouble = 56.78;

            //Booleano - es True o False
            bool variableBool = true;

            //Character - Un caracter
            char variableChar = 'C';

            //String - Varios caracteres
            String variableString = "Es una cadena";

            //Dynamic - Adivina que tipo de dato es, se adapta. Pero aveces asigna mas espacio
            dynamic variableDynamic = 23;

            Console.WriteLine("El valor de la variable es " + variable);
            Console.WriteLine("El valor de la variable es " + variableInt);
            Console.WriteLine("El valor de la variable es " + variableDouble);
            Console.WriteLine("El valor de la variable es " + variableBool);
            Console.WriteLine("El valor de la variable es " + variableChar);
            Console.WriteLine("El valor de la variable es " + variableString);
            Console.WriteLine("El valor de la variable es " + variableDynamic);
            Console.ReadKey();

        }
    }
}
