using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*1、使用事件机制，模拟实现一个闹钟的定时功能，可以设置闹钟，在闹钟时间到了以后，在控制台显示提示信息。*/

namespace ClockTiming
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Clock());
        }
    }
}
