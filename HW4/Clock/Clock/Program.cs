using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            myClock.alarmClock.Run();
        }
    }

    public delegate void ClockHandler(object sender, DateTime dataTime);

    public class ClockEventArgs
    {
        public event ClockHandler Tick;
        public event ClockHandler Alarm;
        private DateTime alarmTime;
        public DateTime AlarmTime
        {
            get => alarmTime;
            set => alarmTime = value;
        }
        public void Run()
        {
            Console.WriteLine("开始运行！");
            while (true)
            {
                Tick(this, DateTime.Now);
                if (DateTime.Now.ToString() == AlarmTime.ToString())
                {
                    Alarm(this, DateTime.Now);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    public class Clock
    {
        public ClockEventArgs alarmClock = new ClockEventArgs();
        public Clock()
        {
            // alarmClock = new AlarmClock();
            DateTime alarmTime = new DateTime();
            int year, month, day, hour, minute, second;
            Console.WriteLine("Please enter the accurate alarm time of your clock");
            Console.WriteLine("NOTICE:");
            Console.WriteLine("1. Enter year, month, day, hour ,minute and second IN TURN");
            Console.WriteLine("2. Seperate them with the ENTER key");
            Console.WriteLine("3. If you don't need to set the second, please set it as 0");
            try
            {
                year = int.Parse(Console.ReadLine());
                month = int.Parse(Console.ReadLine());
                day = int.Parse(Console.ReadLine());
                hour = int.Parse(Console.ReadLine());
                minute = int.Parse(Console.ReadLine());
                second = int.Parse(Console.ReadLine());
                alarmTime = new DateTime(year, month, day, hour, minute, second);
                Console.WriteLine($"You have set the alarm time as {alarmTime}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error:the time you enter is out of range");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error:the format of time you enter is wrong");
            }
            // alarmClock.AlarmTime = new DateTime(2020, 3, 17, 16, 26, 0);
            alarmClock.AlarmTime = alarmTime;
            alarmClock.Tick += new ClockHandler(Alarm_tick);
            alarmClock.Alarm += Alarm_alarm;
        }
        void Alarm_tick(object sender, DateTime dateTime)
        {
            Console.WriteLine($"滴答......滴答......  现在时间：{dateTime.ToString()}");
        }
        void Alarm_alarm(object sender, DateTime dateTime)
        {
            Console.WriteLine($"叮铃铃......叮铃铃......  现在时间：{dateTime.ToString()}");
        }
    }

    public class Form
    {
        public Clock clock = new Clock();

    }
}
