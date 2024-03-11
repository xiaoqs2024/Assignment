using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Matrix
    {
        static void Main(String[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 5, 1, 2, 3 };
            int[] arr3 = { 9, 5, 1, 2 };
            int[][] arr = { arr1, arr2, arr3 };
            bool result = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    result = false;
                    break;
                }
            }
            Console.WriteLine("The result is " + result);
        }
    }
}
