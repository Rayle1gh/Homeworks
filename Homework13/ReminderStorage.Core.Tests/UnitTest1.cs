using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using System;
using System.Collections;

namespace ReminderStorage.Core.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "Отправить письмо";
            ReminderItem item = new ReminderItem(Guid.Empty, DateTimeOffset.MinValue,message, 0);

            Assert.AreEqual(message, item.Message);
            Assert.IsFalse(message != item.Message);


        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(1000)]
        [DataRow(1)]
        public void IsContactdIDCorrect(int value)
        {

            string message = "Отправить письмо";
            ReminderItem item = new ReminderItem(Guid.Empty, DateTimeOffset.MinValue, message, value);
            Assert.IsTrue(item.contactId>=0);
        }

    }
}
