using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //装箱：将值类型转换为引用类型
            //拆箱：将引用类型转换为值类型
            //值类型：int，double，decimal，enum，struct，bool，char
            //引用类型：数组，集合，自定义类，string，object

            int n = 10;
            object o = n;//这个就是把值类型转换成引用类型，这就是装箱

            int nn = (int)o;//引用类型转换成值类型，这就是拆箱，装的是什么类型，拆就拆什么类型


        }
    }
}
