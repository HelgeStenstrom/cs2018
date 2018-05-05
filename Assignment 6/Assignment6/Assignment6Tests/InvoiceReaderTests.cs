using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Assignment6.Tests
{
    [TestClass()]
    public class InvoiceReaderTests
    {
        [TestMethod]
        public void readFile()
        {
            // Setup
            var reader = new InvoiceReader("InvoiceDemo1.txt");

            // Execute
            var invoice = reader.GetInvoice();

            // Verify

            Assert.AreEqual("Beverages.com", invoice.WebAddress);
        }


    }
}