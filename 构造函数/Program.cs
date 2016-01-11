using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zsStudent = new Student("张三",50, '男');

            zsStudent.SayHello();
            Console.ReadKey();
        }
    }
}
