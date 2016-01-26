using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学习HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add('c', true);
            ht.Add(3.14, 100);
            ht[5] = "李四";//向集合中添加相同的键，可替换原来的键值

            //ht.Clear();//清空集合
            ht.Remove(1);//根据键值删除指定
            if (ht.ContainsKey(1))
            {
                Console.WriteLine("已存在相同的键值");
            }
            else
            {
                ht.Add(1, "王五");
            }
            
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键---{0}值-----{1}",item,ht[item]);
            }
            Console.ReadKey();
        }
    }
}
