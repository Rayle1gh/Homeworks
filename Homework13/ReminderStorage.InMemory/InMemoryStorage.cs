using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReminderStorage.InMemory
{
    public class InMemoryStorage : IReminderStorage
    {
        internal readonly Dictionary<Guid, ReminderItem> reminders = new Dictionary<Guid, ReminderItem>();
        
        public void Add(Guid guid, ReminderItem item)
        {
            reminders.Add(guid, item);
        }

        public ReminderItem Get(Guid id)
        {
            if (reminders.ContainsKey(id))
                return reminders[id];
            else
                throw new Exception("Не найдено");
        }

        public List<ReminderItem> GetList()
        {
            return reminders.Select(a => a.Value).ToList();
        }


        public void Display()
        {

            if (reminders.Count > 0) { 
                string msg = "";

                foreach (KeyValuePair<Guid, ReminderItem> pair in reminders)
                    msg += $"{pair.Key.ToString()}. Отправить \"{pair.Value.Message}\" через {pair.Value.TimeToAlarm.TotalSeconds}\n";
                Console.WriteLine(msg);
            }
            else
            {
                Console.WriteLine("Нет задач для выполнения");
            }
        }

        public void Remove(Guid id)
        {
            if (reminders.ContainsKey(id))
            {
                reminders.Remove(id);
            }
        }

        public void Update(Guid id, ReminderItem item)
        {
            Remove(id);
            Add(id, item);
        }

        public void RemoveAll()
        {
            reminders.Clear();
        }
    }
}
