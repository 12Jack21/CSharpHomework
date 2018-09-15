using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tag = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            int data = num;
            int[] result = new int[100000];

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                while (true)
                {
                    if (num % i == 0)
                    {
                        result[tag] = i;
                        tag++;
                        num /= i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (num != 1)
            {
                result[tag] = num;
            }

            Console.WriteLine("The Prime factor of " + data + " is:");
            Console.Write(data + " = ");
            for (int i = 0; i < tag + 1; i++)
            {
                if (i == tag)
                {
                    break;
                }
                if (i != 0)
                {
                    Console.Out.Write(" * ");

                }
                Console.Out.Write(result[i]);
            }
            Console.Out.WriteLine("");
        }
    }
}