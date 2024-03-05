using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1, num2, op;
            Console.WriteLine("请输入第一个数字：");
            num1 = Console.ReadLine();
            Console.WriteLine("请输入第二个数字：");
            num2 = Console.ReadLine();
            Console.WriteLine("请输入运算符号：");
            op = Console.ReadLine();
            int result = 0;
            switch (op)
            {
                case "+":
                    { result = int.Parse(num1) + int.Parse(num2); break; }
                case "-":
                    { result = int.Parse(num1) - int.Parse(num2); break; }
                case "/":
                    {
                        if (int.Parse(num2) == 0) { Console.WriteLine("输入的式子有误！"); }
                        else { result = int.Parse(num1) / int.Parse(num2); }
                        break;
                    }
                case "*":
                    { result = int.Parse(num1) * int.Parse(num2); break; }
            }
            if (!(int.Parse(num2) == 0 && op=="/"))
            { 
                Console.WriteLine("计算结果为：" + result);
                Console.ReadKey();
            }
        }
    }
}
