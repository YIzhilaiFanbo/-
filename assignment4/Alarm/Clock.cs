using System;

namespace AlarmClock
{
    public class Clock
    {
        // 嘀嗒事件
        public event EventHandler Tick;
        // 响铃事件
        public event EventHandler Bell;

        // 时、分、秒
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public int Second { get; private set; }

        // 响铃时的时、分、秒
        public int AlarmHour { get; private set; }
        public int AlarmMinute { get; private set; }
        public int AlarmSecond { get; private set; }
        public Clock()
        {
            Hour = Minute = Second = 0;
        }

        // 设置闹钟当前时间
        public void SetCurrentTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        // 设置响铃时间
        public void SetAlarmTime(int hour, int minute, int second)
        {
            AlarmHour = hour;
            AlarmMinute = minute;
            AlarmSecond = second;
        }

        // 删除响铃时间
        public void ClearAlarmTime()
        {
            AlarmHour = 0;
            AlarmMinute = 0;
            AlarmSecond = 0;
        }

        // 输出当前时间
        public void PrintCurrentTime()
        {
            Console.WriteLine($"当前时间：{Hour:D2}:{Minute:D2}:{Second:D2}");
        }

        // 触发嘀嗒事件
        protected virtual void OnTick(EventArgs e)
        {
            Tick?.Invoke(this, e);
        }

        // 触发响铃事件
        protected virtual void OnBell(EventArgs e)
        {
            Bell?.Invoke(this, e);
        }

        // 检查响铃时间并响铃
        private void CheckAlarm()
        {
            if (Hour == AlarmHour && Minute == AlarmMinute && Second == AlarmSecond)
            {
                OnBell(EventArgs.Empty);
            }
        }

        // 时钟运行
        public void RunClock()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000); // 模拟1秒的间隔
                UpdateTime();
                OnTick(EventArgs.Empty); // 触发嘀嗒事件
                PrintCurrentTime();//输出当前时间
                CheckAlarm(); // 检查指定时间并响铃
            }
        }

        // 更新时间
        private void UpdateTime()
        {
            Second++;
            if (Second == 60)
            {
                Second = 0;
                Minute++;
                if (Minute == 60)
                {
                    Minute = 0;
                    Hour++;
                    if (Hour == 24)
                    {
                        Hour = 0;
                    }
                }
            }
        }
    }
}
