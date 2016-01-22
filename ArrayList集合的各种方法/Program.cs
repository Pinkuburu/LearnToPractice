using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ArrayList集合的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            //给集合添加单个元素
            list.Add(1);
            list.Add(3.14);
            list.Add(500m);
            list.Add(true);
            list.Add("男生");
            list.Add('男');
            //给集合添加集合
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            list.AddRange(new string[] { "张三", "王五", "李四" });
            //list.AddRange(list);

            //删除集合中所有的元素
            //list.Clear()
            //删除集合中单个元素
            //list.Remove(1);
            //根据索引删除元素,按照单个元素处理            
            //list.RemoveAt(6);
            //移除一定范围内的数据
            //list.RemoveRange(6, 5);


            //向集合中插入元素
            //list.Insert(1, "我是新来的");
            //list.InsertRange(0, new string[] { "娃哈哈", "你问问" });

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();

        }
    }
}
