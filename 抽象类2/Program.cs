using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 抽象类2
{
    class Program
    {
        static void Main(string[] args)
        {


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

            //cpu.CPUWrite(uDisk);
            //cpu.CPURead(uDisk);

            cpu.MS = mp3;
            cpu.CPURead();
            cpu.CPUWrite();

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

        public MobileStorage MS
        {
            get;
            set;

        }

        /// <summary>
        /// 电脑需要调用查到电脑上的移动设备的读取数据的方法
        /// </summary>
        public void CPURead()
        {
            this.MS.Read();
        }

        public void CPUWrite()
        {
            this.MS.Write();
        }


    }
}
