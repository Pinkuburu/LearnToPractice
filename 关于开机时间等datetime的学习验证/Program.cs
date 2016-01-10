using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关于开机时间等datetime的学习验证
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now.AddMilliseconds(0 - Environment.TickCount);

            DateTime dt2 = DateTime.Now;

            
            Console.WriteLine("变量dt="+dt.ToString());

            Console.WriteLine("变量dt2=" + dt2.ToString());

            Console.WriteLine("变量dt3=" + (dt2 - dt));

            Console.WriteLine("Environment.TickCount=" + Environment.TickCount);
            



            Console.ReadKey();
        }
    }
}
