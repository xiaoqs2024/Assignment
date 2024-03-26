using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Clock
    {
        //定义事件，创建一个委托实例
        public event ClockHandler OnClock;
        public void Tick(int time)
        {
            Console.WriteLine($"现在时间为{time}点");
            ClockEventArgs args = new ClockEventArgs()
            {
                TIME = time
            };
            //触发事件
            OnClock(this, args);
        }
        
        public void Alarm()
        {
            Console.WriteLine($"闹钟响了");
        }
    }
}
