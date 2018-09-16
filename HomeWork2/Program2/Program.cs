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
            //从屏幕读取数据
            Console.WriteLine("Please enter the length of the int array:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the int value of the array:");
            int[] data = new int[length];
            for(int i = 0;i < length;i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //寻找最小值
            int min = data[0];
            for(int i = 1;i <length;i++)
            {
                if(min >= data[i])
                {
                    min = data[i];
                }
            }
            Console.WriteLine("The miximum of the int array is : " + min);

            //寻找最大值
            int max = data[0];
            for (int i = 1; i < length; i++)
            {
                if (max <= data[i])
                {
                    max = data[i];
                }
            }
            Console.WriteLine("The maximum of the int array is : " + max);

            //求和
            int sum = 0;
            for(int i = 0;i < length;i++)
            {
                sum += data[i];
            }
            Console.WriteLine("The sum of the int array is: " + sum);

            //求平均值
            double average = sum / (length * 1.0);
            Console.WriteLine("The average of the int array is: " + average);
        }
    }
}
