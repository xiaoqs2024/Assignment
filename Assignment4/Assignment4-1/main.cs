using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class main
    {
        static void Main(string[] args)
        {
           GenericList<int> list = new GenericList<int>();
           for (int i = 0; i < 10; i++)
           {
                list.Add(i);
           }
           Caculator caculator = new Caculator();
           Action<GenericList<int>> p = caculator.PrintList;
           p += caculator.Min;
           p += caculator.Max;
           p += caculator.Sum;
           p(list);

        }
    }
}
