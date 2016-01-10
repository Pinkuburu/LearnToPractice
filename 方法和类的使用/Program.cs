using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法和类的使用
{
    class Program
    {
        class ClassMax
        {
            public int IntMax(int a,int b)
            {
                return a > b ? a : b;
            }
        }
        /// <summary>
        /// 类》声明对象》访问对象
        /// 类的定义
        /// class 类名
        /// {
        /// 
        /// }
        /// 例如声明一个叫student的类：
        /// class student
        /// {
        ///     public string name;
        /// }
        /// 
        /// 声明对象
        /// 类名 对象名;
        /// 例如声明一个叫s1的对象：
        /// student s1;
        /// 
        /// 访问对象
        /// 对象名.类的字段
        /// 例如访问s1的name字段：
        /// s1.name
        /// 
        /// 
        /// 声明方法
        /// 访问修饰符 返回类型 方法名（参数列表）
        /// {
        /// 
        /// }
        /// 例如比较两个数的大小的一个方法：
        /// public int IntMax（int a，int b）
        /// {
        ///     一段比较的语句块
        /// }
        /// 在声明的类中调用方法
        /// 方法名（参数列表）
        /// return IntMax（a，b）
        /// 
        /// 在声明的类外调用方法
        /// 对象名.方法名（参数列表）
        /// 
        /// </summary>
        /// <param name="args"></param>
        ///         

        static void Main(string[] args)
        {
            
            int x = 41, y;
            y = 100;
            ClassMax a = new ClassMax();
            int c = a.IntMax(x, y);
            Console.WriteLine(c);
            Console.ReadKey();
        }
       
    }
}
