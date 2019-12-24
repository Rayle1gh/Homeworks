using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Storage.Core
{
    public interface IReminderStorage
    {

        void Add(Guid guid, ReminderItem item);

        ReminderItem Get(Guid id);

        List<ReminderItem> GetList();
        void Remove(Guid id);
        void Update(Guid id, ReminderItem item);
        void RemoveAll();
    }
}
