using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritmeticos + - * /

            int num = 6, num2 = 5;

            Console.WriteLine("El resultado de la suma es: " + (num + num2));
            Console.WriteLine("El resultado de la resta es: " + (num - num2));
            Console.WriteLine("El resultado de la multiplicacion es: " + (num * num2));
            Console.WriteLine("El resultado de la division es: " + (num / num2));
            Console.WriteLine("El resto es: " + (num % num2));

            double numero, pot, resultado;

            Console.WriteLine("Digite el numero que quiere elevar: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la potencia que quiere elevar: ");
            pot = Convert.ToDouble(Console.ReadLine());

            //Pow eleva
            resultado = Math.Pow(numero, pot);

            Console.WriteLine("El resultado es: " + resultado);

            //Sqrt es la raiz cuadrada
            Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(49));

            Console.ReadKey();
            
        }
    }
}
