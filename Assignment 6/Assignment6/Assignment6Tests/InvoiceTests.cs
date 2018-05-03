using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void ContactTest()
        {
            var c = new Invoice.Contact("n1", "n2", "3", "zip", "5", "6");
            Assert.AreEqual("n1", c.CompanyName);
            Assert.AreEqual("n2", c.PersonName);
            Assert.AreEqual("3", c.Street);
            Assert.AreEqual("zip", c.Zip);
            Assert.AreEqual("5", c.City);
            Assert.AreEqual("6", c.Country);
        }


        [TestMethod()]
        public void ItemTest()
        {
            var i = new Invoice.Item("desc", 7, 3.14, 2.71);
            Assert.AreEqual("desc", i.Description);
            Assert.AreEqual(7, i.Quantity);
            Assert.AreEqual(3.14, i.UnitPrice);
            Assert.AreEqual(2.71, i.TaxPercent);
        }

        [TestMethod()]
        public void InvoiceTest()
        {
            // Setup
            var iDate = new DateTime(2018, 5, 3);
            var dueDate = new DateTime(2018, 7, 2);
            var receiver = new Invoice.Contact("receiver", "n2", "3", "zip", "5", "6");
            var sender = new Invoice.Contact("sender", "n2", "3", "zip", "5", "6");
            
            
            // Execute
            var invoice = new Invoice(123, 
                iDate, dueDate, 
                receiver, sender, 
                "phone", "webaddress", 
                new List<Invoice.Item>() );
            
            // Verify
            Assert.AreEqual(iDate, invoice.InvoiceDate);
            Assert.AreEqual(receiver, invoice.Receiver);
            Assert.AreEqual("phone", invoice.Phone);
        }
    }
}