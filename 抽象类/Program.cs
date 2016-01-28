using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            文件流
            FileStream,StreamReader和StreamWriter
            装箱和拆箱
            泛型集合
            多态


            */
            //FileStream文件流
            //using (FileStream fsRead = new FileStream(@"D:\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];

            //    //本次读取实际读取到的有效字节数
            //    int r = fsRead.Read(buffer, 0, buffer.Length);
            //    //
            //    string s= Encoding.Default.GetString(buffer, 0, r);
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();

            //using (FileStream fsWrite = new FileStream(@"D:\Desktop\2.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string s = "9991231231232";
            //    byte[] buffer = Encoding.Default.GetBytes(s);
            //    fsWrite.Write(buffer, 0, buffer.Length);                               
            //}

            //泛型集合
            //List<int> list = new List<int>();
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "zs");
            //dic.Add(2, "ls");
            //dic.Add(3, "ww");
            //dic.Add(4, "zl");
            //dic.Add(5, "zq");
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}-------{1}",kv.Key,kv.Value);
            //}

            //拆箱和装箱
            //值类型：int double char decimal bool enum struct
            //引用类型：string 数组 集合 自定义类 object 接口

            //多态：一个对象，多种类型
            //虚方法、抽象类、接口
            //使用多态的思想来模拟U盘，移动硬盘，mp3插到电脑上读写数据
            //U盘和移动硬盘都有一个Read（）和Write（）
            //MP3除了Read（）和Write（），本身还可以播放音乐
            //父类 移动设备
            UDisk uDisk = new UDisk();
            MobileDisk mobileDisk = new MobileDisk();
            MP3 mp3 = new MP3();

            Computer cpu = new Computer();

            cpu.CPUWrite(uDisk);
            cpu.CPURead(uDisk);


            Console.ReadKey();
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }

    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }

    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3在播放音乐");
        }
    }

    public class Computer
    {
        //获得插到电脑上的移动设备

            /// <summary>
            /// 电脑需要调用查到电脑上的移动设备的读取数据的方法
            /// </summary>
        public void CPURead(MobileStorage ms)
        {
            ms.Read();
        }

        public void CPUWrite(MobileStorage ms)
        {
            ms.Write();
        }


    }
}
