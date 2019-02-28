using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 作业1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("学号");
            string xuehao = Console.ReadLine();
            Console.WriteLine("姓名");
            string xingming = Console.ReadLine();
            Console.WriteLine("班级");
            string banji = Console.ReadLine();
            Console.WriteLine("年龄");
            string nianling = Console.ReadLine();
            Console.WriteLine("性别");
            string xingbie = Console.ReadLine();
            Console.WriteLine("学号:{0} 姓名:{1} 班级:{2} 年龄:{3} 性别:{4}", xuehao, xingming, banji, nianling, xingbie);
            Console.ReadKey();
        }
    }
}
