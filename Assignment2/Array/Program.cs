using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Array
    {
        static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int min = arr[0], max = arr[0], ave, sum = 0;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] < min) { min = arr[i]; }
                if (arr[i] > max) { max = arr[i]; }
                sum += arr[i];
            }
            ave = sum / len;
            Console.WriteLine("Min is " + min);
            Console.WriteLine("Max is " + max);
            Console.WriteLine("Ave is " + ave);
        }
    }
}

