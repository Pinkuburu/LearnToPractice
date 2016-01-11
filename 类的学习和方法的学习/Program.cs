using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的学习和方法的学习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person();
            //Person lsPerson = new Person();

            zsPerson.Name = "张三";
            zsPerson.Age = -20;
            zsPerson.Gender = '中';

            zsPerson.SayHello();
            Console.ReadKey();
        }
    }
}
