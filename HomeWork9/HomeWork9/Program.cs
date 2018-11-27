using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//将书中例9-10的爬虫程序，使用并行处理进行优化，实现更快速的网页爬取。
namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            String startUrl = "http://www.cnblogs.com/dstang2000/";
            Crawler crawler1 = new Crawler();
            ParallelCrawler crawler2 = new ParallelCrawler();
            //时间对比
            Stopwatch sw = new Stopwatch();
            sw.Start();
            crawler1.Start(startUrl, 20);
            sw.Stop();
            Console.WriteLine("Normal crawler crawling time: " + sw.ElapsedMilliseconds);

            sw.Restart();
            crawler2.Start(startUrl,20);
            sw.Stop();
            Console.WriteLine("Parallel crawler crawling time: " + sw.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
