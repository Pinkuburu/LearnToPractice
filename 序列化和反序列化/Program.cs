using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            ////服务器端
            ////序列化：就是讲对象转换为二进制
            ////反序列化：将二进制转换为对象
            ////作用：传输数据

            ////序列化：1、 将要序列化的对象所在的类标记为可被序列化
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 19;
            //p.Gender = '男';


            //using (FileStream fsWrite = new FileStream(@"D:\Desktop\Person.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //序列化的对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite,p);

            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();


            //客户端将二进制转成对象
            Person per;
            using (FileStream fsReader = new FileStream(@"D:\Desktop\Person.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                per=(Person)bf.Deserialize(fsReader);
            }
            Console.WriteLine(per.Name);
            Console.WriteLine(per.Age);
            Console.WriteLine(per.Gender);
            Console.ReadKey();

    }
}


[Serializable]
public class Person
{
    public string Name
    {
        get;
        set;
    }
    public int Age
    {
        get;
        set;
    }
    public char Gender
    {
        get;
        set;
    }
}
}
