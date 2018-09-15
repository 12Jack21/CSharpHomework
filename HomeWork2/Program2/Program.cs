using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the int array:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the int value of the array:");
            int[] data = new int[length];
            for(int i = 0;i < length;i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
