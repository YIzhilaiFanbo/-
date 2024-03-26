using System;

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            // 订阅嘀嗒事件
            clock.Tick += (sender, e) =>
            {
                Console.WriteLine("嘀嗒");
            };

            // 订阅响铃事件
            clock.Bell += (sender, e) =>
            {
                Console.WriteLine("闹钟响了");
            };

            // 设置响铃时间
            clock.SetAlarmTime(8, 0, 0);

            //设置当前时间
            clock.SetCurrentTime(7, 59, 55);

            // 运行闹钟
            clock.RunClock();
        }
    }
}
