using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Reminder.Storage.Core
{
    public class ReminderItem
    {
        private Thread _thread;
        private long _contactId;
        public Guid Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Message { get; set; }
        public long contactId
        {
            get => _contactId;
            set
            {
                _contactId = value < 0 ? 0 : value;
            }
        }
        public ReminderStatus Status { get; set; } = ReminderStatus.Awaiting;
        public TimeSpan TimeToAlarm => Date - DateTime.UtcNow;



        public ReminderItem(Guid id, DateTimeOffset date, string message, long contactId)
        {
            this.Id = id;
            this.Date = date;
            this.Message = message;
            this._contactId = contactId;
            _thread = new Thread(StartReminder);
            _thread.Start();
        }

        public override string ToString()
        {
            return $"До срабатывания осталось {TimeToAlarm.TotalSeconds}. Сообщение: {Message} ";
        }


        private void StartReminder()
        {
            while (true)
            {
                if (TimeToAlarm.TotalMilliseconds <= 0)
                {
                    Console.WriteLine($"Надо делать работу: {Message}");
                    break;
                }
                else 
                    Thread.Sleep(20);

            }
            _thread.Interrupt();

        }
    }
}
