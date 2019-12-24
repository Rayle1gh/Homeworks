using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReminderStorage.InMemory;
using System;
using System.Collections.Generic;
using System.Text;
using Reminder.Storage.Core;

namespace ReminderStorage.InMemory.Tests
{
    [TestClass()]
    public class InMemoryStorageTests
    {
        [TestMethod()]
        public void RemoveAllTest()
        {
            var storage = new InMemoryStorage();
            var item = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item.Id, item);
            var item1 = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item1.Id, item1);
            var item2 = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item2.Id, item2);
            storage.RemoveAll();
            var count = storage.GetList().Count;
            Assert.AreEqual(count, 0);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            var storage = new InMemoryStorage();
            var item = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item.Id, item);
            storage.Remove(item.Id);
            var count = storage.GetList().Count;
            Assert.AreEqual(count, 0);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var storage = new InMemoryStorage();
            var item = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item.Id, item);
            var item1 = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test HALLO", 1);
            storage.Update(item.Id, item1);
            var getItem = storage.Get(item1.Id);
            Assert.AreEqual(item1, getItem);
        }

        [TestMethod()]
        public void AddTest()
        {
            var storage = new InMemoryStorage();
            var item = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item.Id, item);
            var count = storage.GetList().Count;
            Assert.AreEqual(count, 1);
        }

        [TestMethod()]
        public void GetTest()
        {
            var storage = new InMemoryStorage();
            var item = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item.Id, item);
            var getItem = storage.Get(item.Id);
            Assert.AreEqual(item, getItem);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var storage = new InMemoryStorage();
            var item = new ReminderItem(Guid.NewGuid(), DateTimeOffset.Now, "Test ALO", 0);
            storage.Add(item.Id, item);
            var count = storage.GetList().Count;
            Assert.AreEqual(count, 1);
        }
    }
}