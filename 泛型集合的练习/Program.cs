using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////偶数奇数放在同一个集合里，然后要奇数在左侧，偶数在右侧
            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //listJi.Add(1);
            //listJi.Add(3);
            //listJi.Add(5);
            //listOu.Add(2);
            //listOu.Add(4);
            //listOu.Add(6);

            ////List<int> listSum = new List<int>();
            ////listSum.AddRange(listJi);
            ////listSum.AddRange(listOu);

            ////for (int i = 0; i < listSum.Count; i++)
            ////{
            ////    Console.WriteLine(listSum[i]);
            ////}

            //listJi.AddRange(listOu);
            //for (int i = 0; i < listJi.Count; i++)
            //{
            //    Console.WriteLine(listJi[i]);
            //}


            ////将一个集合中的奇数拿出来，偶数拿出来，合并成新的集合，然后奇数在左边，偶数在右边
            //int[] nums = { 1, 2,3, 4, 5, 6, 7, 8, 9 };
            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //List<int> listSum = new List<int>();


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listOu.Add(nums[i]);
            //    }
            //}

            //listJi.AddRange(listOu);

            //foreach (var item in listJi)
            //{
            //    Console.WriteLine(item);
            //}
            ////listSum.AddRange(listJi);
            ////listSum.AddRange(listOu);
            ////foreach (var item in listSum)
            ////{
            ////    Console.Write(item+"\t");
            ////}

            //输入字符串，使用foreach循环复制给一个char数组

            Console.WriteLine("输入一个字符串");
            string input = Console.ReadLine();
            char[] chs = new char[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    chs[i] = input[i];
            //}
            int i = 0;
            foreach (var item in input)
            {
                chs[i] = item;
                i++;
            }
            foreach (var item in chs)
            {
                Console.Write(item);
            }


            Console.ReadKey();
        }
    }
}
