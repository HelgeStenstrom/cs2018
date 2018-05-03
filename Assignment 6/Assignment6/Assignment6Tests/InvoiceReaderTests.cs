using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Assignment6.Tests
{
    [TestClass()]
    public class InvoiceReaderTests
    {
        [TestMethod()]
        public void ReasonableFileSize()
        {
            string filename = "InvoiceDemo1.txt";
            var x = new InvoiceReader(filename);
            int sz = x.Size;
            Assert.IsTrue(0 < sz, "file should not be empty");
            Assert.AreEqual(17, sz);
            Assert.Fail("Test not done");
        }

        [TestMethod]
        public void test1()
        {
            // TODO: Sätt att hitta fil som ligger i projektet.
            
            using (TextReader reader = new StreamReader("InvoiceDemo1.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

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