using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public delegate void ClockHandler(object sender,
        ClockEventArgs args);
    public class ClockEventArgs
    {
        public int TIME { get; set; }
    }
}
