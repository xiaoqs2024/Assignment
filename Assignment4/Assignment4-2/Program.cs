﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();
            f.clock.Alarm();
            f.clock.Tick(22);
        }
    }
}
