using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#的访问修饰符
            //public 公开的公共的
            //private 私有的，只能在当前类的内部访问
            //protect 受保护的，只能在当前类的内部和该类的子类中访问
            //internal 只能在当前项目中访问
            //protect internal 

            //修饰符累的访问修饰符只有两个，public和internal
        }
    }
    public class Person
    {
        private string _name;
        protected int _age;
        internal char _gender;
    }

    public class Student : Person
    {
        public void Test()
        {
            
        }
    }
}
