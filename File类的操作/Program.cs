using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File类的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"D:\Desktop\1.txt"))
            {
                File.Create(@"D:\Desktop\1.txt");
                Console.WriteLine("创建成功");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("文件已存在");
                Console.ReadKey();
            }
            if (File.Exists(@"D:\Desktop\1.txt"))
            {
                File.Move(@"D:\Desktop\2.txt", @"D:\Desktop\练习\2.txt");
                File.Copy(@"D:\Desktop\1.txt", @"D:\Desktop\2.txt");
                Console.WriteLine("复制成功");
                Console.ReadKey();
                File.Delete(@"D:\Desktop\1.txt");
                Console.WriteLine("删除成功");
                Console.ReadKey();
            }
        }
    }
}
