using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你要哪个打折方式");
            Console.WriteLine("1不打折，2打95折，3打85折，4买300-50,5买500送100");

            string input = Console.ReadLine();

            Console.WriteLine("你打折前应付439.8");
            DZFather dz = GetDz(input);
            double realMoney = dz.GetMoney(439.8);
            Console.WriteLine("{0}",realMoney);
            Console.ReadKey();

        }

        public static DZFather GetDz(string input)
        {
            DZFather dz = null;
            switch (input)
            {
                case "1":
                    dz = new NormalDZ();
                    break;
                case "2":
                    dz = new RateDz(0.95);
                    break;
                case "3":
                    dz = new RateDz(0.85);
                    break;
                case "4":
                    dz = new MNDZ(300, 50);
                    break;
                case "5":
                    dz = new MNDZ(500, 100);
                    break;

            }
            return dz;
        }
    }
    public abstract class DZFather
    {
        public abstract double GetMoney(double totalMoney);
    }

    public class NormalDZ : DZFather
    {
        /// <summary>
        /// 打折前多少钱，打折后就多少钱
        /// </summary>
        /// <param name="totalMoney">打折前应付的价钱</param>
        /// <returns>打折后应该付的钱</returns>
        public override double GetMoney(double totalMoney)
        {
            return totalMoney;
        }
    }

    public class RateDz : DZFather
    {

        public double Rate
        {
            get;

            set;
        }
        /// <summary>
        /// 传入折扣率
        /// </summary>
        /// <param name="rate">要打的折扣</param>
        public RateDz(double rate)
        {
            this.Rate = rate;
        }

        public override double GetMoney(double totalMoney)
        {
            return totalMoney * this.Rate;
        }
    }

    public class MNDZ : DZFather
    {
        //500减100

        public double M
        {
            get;

            set;
        }


        public double N
        {
            get;

            set;
        }

        public MNDZ(double m, double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetMoney(double totalMoney)
        {
            if (totalMoney > this.M)
            {
                return totalMoney - ((int)(totalMoney / this.M)) * this.N;
            }
            else
            {
                return totalMoney;
            }
        }
    }



}
