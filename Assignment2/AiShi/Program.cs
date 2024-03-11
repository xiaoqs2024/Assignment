using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AiShi
    {
        static void Main(String[] args)
        {
            int[] arr = new int[99];
            //赋值
            for (int i = 2; i <= 99; i++)
            {
                arr[i - 2] = i;
            }
            //筛选
            for (int j = 2; j < 99; j++)
            {
                for (int i = j - 1; i < arr.Length; i++)
                {
                    if (arr[i] % j == 0)
                    {
                        arr[i] = 0;
                    }
                }
            }
            //输出
            for (int i = 0; i < arr.Length; i++)
            {
                if (!(arr[i] == 0))
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}
