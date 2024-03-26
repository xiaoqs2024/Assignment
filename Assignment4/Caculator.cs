using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Caculator
    {
        public void PrintList(GenericList<int> list)
        {
            for (Node<int> node = list.Head; node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
        }
        public void Min(GenericList<int> list)
        {
            Node<int> node = list.Head;
            int min = node.Data;
            while (node != null)
            {
                min = node.Data < min ? node.Data : min;
                node = node.Next;
            }
            Console.WriteLine("最小值为"+min);
        }
        public void Max(GenericList<int> list)
        {
            Node<int> node = list.Head;
            int max = node.Data;
            while (node != null)
            {
                max = node.Data > max ? node.Data : max;
                node = node.Next;
            }
            Console.WriteLine("最大值为" + max);
        }
        public void Sum(GenericList<int> list)
        {
            int sum = 0;
            for (Node<int> node = list.Head; node != null; node = node.Next)
            {
                sum += node.Data;
            }
            Console.WriteLine("和为"+sum);
        }
    }
}
