using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("============Calculate the product of two numbers==========");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Please enter two number below:");
            double num1 = Double.Parse(Console.ReadLine());
            double num2 = Double.Parse(Console.ReadLine());
            Console.Out.WriteLine("The product of the two numbers is: " + num1 * num2);
        }
    }
}
