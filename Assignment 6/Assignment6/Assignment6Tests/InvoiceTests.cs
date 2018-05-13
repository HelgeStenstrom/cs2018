// Helge Stenström 
// ah7875
// C# del II 2018

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
        public void ItemTest1()
        {
            var i = new Invoice.Item(0, "desc", 7, 3.14, 2.71);
            Assert.AreEqual("desc", i.Description);
            Assert.AreEqual(7, i.Quantity);
            Assert.AreEqual(3.14, i.UnitPrice);
            Assert.AreEqual(2.71, i.TaxPercent);
        }

        [TestMethod()]
        public void ItemTest2()
        {
            // Setup
            var desc = "Strong Bear";
            var quant = 5;
            var up = 39.9;
            var tax = 25.0;
            var totalTax = 49.875; // 5 *  0.25 * 39.9;
            var total = 249.375; //  quant * up + totalTax;

            // Exercise
            var i = new Invoice.Item(0, desc, quant, up, tax);

            // Verify
            Assert.AreEqual(desc, i.Description);
            Assert.AreEqual(quant, i.Quantity);
            Assert.AreEqual(up, i.UnitPrice);
            Assert.AreEqual(tax, i.TaxPercent);
            Assert.AreEqual(totalTax, i.TotalTax);
            Assert.AreEqual(total, i.Total);

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


        [TestMethod()]
        public void InvoiceTotalTest()
        {
            // Setup
            var iDate = new DateTime(2018, 5, 3);
            var dueDate = new DateTime(2018, 7, 2);
            var receiver = ValidContact();
            var sender = ValidContact();
            
            var items =  new List<Invoice.Item>();
            items.Add(new Invoice.Item(0, "Strong Bear", 5, 39.9, 25));
            items.Add(new Invoice.Item(0, "Garlic Bread", 2, 4.99, 6));

            // Execute
            var invoice = new Invoice(123,
                iDate, dueDate,
                receiver, sender,
                "phone", "webaddress",
                items);
            invoice.Discount = 100;

            // Verify
            Assert.AreEqual(50.4738, invoice.TotalTax);
            
            Assert.AreEqual(259.9538, invoice.Total);

            Assert.AreEqual(159.9538, invoice.ToPay);
        }

        private static Invoice.Contact ValidContact()
        {
            return new Invoice.Contact("sender", "n2", "3", "zip", "5", "6");
        }

        [TestMethod]
        public void validDefaultInvoice()
        {
            // Setup & Exercise

            Invoice invoice = new Invoice();

            // Verify
            Assert.AreEqual(0, invoice.Discount);
            Assert.IsNotNull(invoice.Items);
            Assert.IsNotNull(invoice.Receiver);
            Assert.IsNotNull(invoice.Sender);

        }
    }
}