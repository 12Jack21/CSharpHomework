using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tag = 0;
            int[] prime = new int[100];
            //筛选素数
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0 && i != 2)
                {
                    continue;
                }
                else if (i % 3 == 0 && i != 3)
                {
                    continue;
                }
                else if (i % 5 == 0 && i != 5)
                {
                    continue;
                }
                else if (i % 7 == 0 && i != 7)
                {
                    continue;
                }
                else
                {
                    prime[tag] = i;
                    tag++;
                }
            }

            //输出
            Console.WriteLine("The prime number from 2 to 100 are: ");
            for (int i = 0; i < tag; i++)
            {
                Console.Write(prime[i] + " ");

            }
            Console.WriteLine("");
        }
    }
}
