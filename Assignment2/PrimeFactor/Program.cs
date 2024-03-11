using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class PrimeFactor
    {
        static void Main(String[] args)
        {
            Console.WriteLine("请输入数据：");
            int number = int.Parse(Console.ReadLine());

            //法一
            for (int i = 2; i < number; i++)
            {
                if (isPrimeNumber(i) && number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            bool isPrimeNumber(int number)
            {
                if (number < 2)
                {
                    return false;
                }
                for (int i = 2; i < number; i++)
                {
                    if (number / i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            //法二
            int[] temp = { 2, 3, 5, 7, 11, 13, 17, 19 ,23, 29, 31, 37, 41, 43, 47, 53};
            int index = 0;
            bool flag = true;
            while (temp[index] <= number)
            {
                if (number % temp[index] == 0)
                {
                    if (flag)
                    {
                        Console.WriteLine(temp[index]);
                    }
                    number = number / temp[index];
                    flag = false;
                }
                else
                {
                    index++;
                    if (index == temp.Length) { break; }
                    flag = true;
                }
            }

        }

    }
}

