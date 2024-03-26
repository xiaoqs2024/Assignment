using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Form
    {
        public Clock clock = new Clock();
        public Form()
        {
            clock.OnClock += new ClockHandler(OnClock1);
            clock.OnClock += new ClockHandler(OnClock2);

            void OnClock1(object sender,ClockEventArgs args)
            {
                Console.WriteLine("");
            }
            void OnClock2(object sender, ClockEventArgs args)
            {
                Console.WriteLine("");
            }
        }
    }
}
