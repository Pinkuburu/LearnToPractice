using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //生产笔记本 IBM Lenovo Dell Acer
            Console.WriteLine("你要啥牌子？");
            string brand = Console.ReadLine();
            Notebook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();



        }
        public static Notebook GetNoteBook(string brand)
        {
            Notebook nb = null;
            switch (brand)
            {
                case "IBM":
                    nb = new IBM();
                    break;
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                
            }
            return nb;
        }
    }
    public abstract class Notebook
    {
        public abstract void SayHello();
    }

    public class IBM : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("IBM SayHello");
        }
    }
    public class Lenovo : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("Lenovo SayHello");
        }
    }

    public class Acer : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("Acer SayHello");
        }
    }

    public class Dell : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("Dell SayHello");
        }
    }

}
