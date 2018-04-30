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
    public class InvoiceReaderTests
    {
        [TestMethod()]
        public void InvoiceReaderTest()
        {
            string fn = "InvoiceDemo1.txt";
            var x = new InvoiceReader(fn);



            Assert.Fail("Test not done");
        }
    }
}