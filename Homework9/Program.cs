using System;

namespace Homework9
{
    class Program
    {
        static void Main()
        {
            ReminderItem values = new ReminderItem(new DateTime(2019, 11, 28, 08, 00, 00), "Проснись тварь");
            ReminderItem values1 = new ReminderItem(new DateTime(2019, 12, 01, 10, 30, 00), "Проснись киберспортсмен");
            values.WriteProperties();
            values1.WriteProperties();
            Console.ReadKey();
        }
    }

    public interface IReminderItem
    {
        DateTimeOffset AlarmDate { get; set; }
        string AlarmMessage { get; set; }
        TimeSpan TimeToAlarm { get; }
        bool IsOutdated { get; }
        void WriteProperties();
    }
    public class ReminderItem : IReminderItem
    {
        public ReminderItem(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }

        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm { get { return DateTimeOffset.Now - AlarmDate; } }
        public bool IsOutdated
        {
            get
            {
                if (TimeToAlarm.TotalMilliseconds >= 0)
                    return true;
                return false;
            }
        }
        public void WriteProperties()
        {
            Console.WriteLine("AlarmDate: {0}\nAlarmMessage: {1}\nTimeToAlarm: {2:%d} days {2:%h} hours {2:%m} minutes {2:%s} seconds\nIsOutdated: {3}",
                 AlarmDate.DateTime, AlarmMessage, TimeToAlarm, IsOutdated);
        }
    }
}
