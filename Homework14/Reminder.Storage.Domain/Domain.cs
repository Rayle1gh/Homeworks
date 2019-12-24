using System;
using System.Linq;
using Reminder.Storage.Core;
using ReminderStorage;
using Reminder.Storage.Domain.Models;
using Reminder.Storage.Domain.EventArgs;
using System.Collections.Generic;
using System.Threading;

namespace Reminder.Storage.Domain
{
    public class Domain
    {
        private IReminderStorage _storage;
        private int _timeToUpdate;
        public Action<SendReminderItemModel> SendReminder { get; set; }
        public event EventHandler<SendSuccesEventArgs> OnSuccesSend;
        public event EventHandler<SendFailedEventArgs> OnFailedSend;

        /// <summary>
        /// Создание домен контроллера
        /// </summary>
        /// <param name="storage">Хранилище напоминаний</param>
        public Domain(IReminderStorage storage) {
            _storage = storage;
            _timeToUpdate = 5;
        }


        /// <summary>
        /// Создание домен контроллера
        /// </summary>
        /// <param name="storage">Хранилище напоминаний</param>
        /// <param name="timeToUpdate">Промежуток обновленния данных</param>
        public Domain(IReminderStorage storage, int timeToUpdate)
        {
            _storage = storage;
            _timeToUpdate = timeToUpdate;
        }


        public void Run()
        {
            while (true)
            {
                Thread.Sleep(_timeToUpdate);
            }
        }


        public void Add(AddReminderItemModel model)
        {
            ReminderItem item = new ReminderItem()
            {
                Id = Guid.NewGuid(),
                date = model.date,
                Message = model.Message,
                contactId = model.contactId,
                _status = ReminderStatus.Awaiting
            };
            _storage.Add(item.Id, item);
        }


        public void CheckAwaitingReminders()
        {
            var ids = _storage.Get(ReminderStatus.Awaiting, 0, 0).Where(r => r.IStimeToAlarm).Select(r=>r.Id);
            _storage.UpdateStatus(ids, ReminderStatus.ReadyToSend);
        }

        public void SendReadyRemiders()
        {
            var reminders = _storage.Get(ReminderStatus.ReadyToSend, 0, 0).Where(r => r.IStimeToAlarm).ToList();
            foreach(ReminderItem r_item in reminders)
            {
                SendReminderItemModel sendModel = new SendReminderItemModel()
                {
                    id = r_item.Id,
                    contactId = r_item.contactId,
                    Message = r_item.Message
                };

                try
                {
                    SendReminder?.Invoke(sendModel);
                    _storage.UpdateStatus(sendModel.id, ReminderStatus.Sended);
                    OnSuccesSend?.Invoke(this, new SendSuccesEventArgs(r_item));

                }
                catch (Exception e)
                {
                    _storage.UpdateStatus(sendModel.id, ReminderStatus.Failed);
                    OnFailedSend?.Invoke(this, new SendFailedEventArgs(e, r_item));
                }
            } 
        }
        public void Display()
        {
            foreach(ReminderItem item in _storage.Get(0, 0))
            {
                Console.WriteLine($"ID:{item.Id};Contact:{item.contactId};Message:{item.Message}");
            }
        }
    }
}
