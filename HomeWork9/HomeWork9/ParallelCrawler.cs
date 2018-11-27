using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//将书中例9-10的爬虫程序，使用并行处理进行优化，实现更快速的网页爬取。
namespace HomeWork9
{
    class ParallelCrawler
    {
        Stopwatch stopWatch = new Stopwatch();
        private int count = 0;
        private int max = 100;
        public ConcurrentBag<String> complated = new ConcurrentBag<string>();
        public ConcurrentQueue<String> pending = new ConcurrentQueue<string>();

        public void Start(String url, int max)
        {
            stopWatch.Start();
            this.count = 0;
            this.max = max;

            Task.Run(() => DownloadAndParse(url));
            while (count < max)
            {
                String ur;
                pending.TryDequeue(out ur);
                if (ur != null)
                    Task.Run(() => DownloadAndParse(ur));
            }
            stopWatch.Stop();
            Console.WriteLine("time cost:" + stopWatch.ElapsedMilliseconds);
        }

        public void DownloadAndParse(String url)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                Console.WriteLine($"Downlonding {url}");
                String page = client.DownloadString(url);
                File.WriteAllText(count.ToString(), page, Encoding.UTF8);
                count++;
                Console.WriteLine($"Parsing {url}");
                Parse(page);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Parse(string page)
        {

            HashSet<String> urls = new HashSet<string>();
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";

            MatchCollection matches = new Regex(strRef).Matches(page);
            foreach (Match match in matches)
            {
                String url = match.Value.Substring(match.Value.IndexOf("=") + 1)
                  .Trim('"', '\"', '#', ',', '>');
                if (url.Length == 0) continue;
                if (!pending.Contains(url) || !complated.Contains(url))
                    pending.Enqueue(url);
            }
        }


    }
}

