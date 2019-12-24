using System;
using System.Threading;
using Reminder.Storage.Core;
using ReminderStorage.InMemory;


namespace Reinder
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryStorage _storage = new InMemoryStorage();
            Guid _item1_guid = Guid.NewGuid();
            Thread.Sleep(1000);
            Guid _item2_guid = Guid.NewGuid();
            ReminderItem item1 = new ReminderItem(_item1_guid, DateTime.Now + TimeSpan.FromSeconds(6), "Do job", 0);
            Console.WriteLine(DateTime.Now.ToString("yyyy-MMMM-ddThh:mm:sss.ffff"));
            Thread.Sleep(8000);
            Console.WriteLine(DateTime.Now.ToString("yyyy-MMMM-ddThh:mm:sss.ffff"));
            ReminderItem item2 = new ReminderItem(_item2_guid, DateTime.Now + TimeSpan.FromMinutes(58.9), "123", 546234);
            _storage.Add(item1.Id, item1);
            _storage.Add(item2.Id, item2);
            Console.ReadLine();
        }
    }
}
