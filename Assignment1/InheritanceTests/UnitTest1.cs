using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance;

namespace InheritanceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PersonWithInvalidAddress()
        {
            Person person = new Person("ett", "två");
            string address = person.Address.ToString();
            //Console.WriteLine(address);
            //Assert.AreEqual("hej", address.ToString());
        }
    }
}
