using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            decimal result = Calculate(num1, num2, operation);
            Console.WriteLine(result);

        }

        private static decimal Calculate(decimal num1, decimal num2, string operation)
        {
            if (operation == "/")
            {
                return Devide(num1, num2);
            }
        }

        private static decimal Devide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
