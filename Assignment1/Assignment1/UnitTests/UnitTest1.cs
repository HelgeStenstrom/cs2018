using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddABear()
        {
            AnimalManager mgr = new AnimalManager();
            mgr.AddBear();
            string[] strings = mgr.getAllAnimalStrings();
            Assert.AreEqual(1, strings.Length);
        }

        [TestMethod]
        public void typeCast()
        {
            Animal eagle = new Eagle("givenId");
            ((Eagle)eagle).FlightSpeed = 10;
        }

        [TestMethod]
        public void TestOverride()
        {
            Animal eagle = new Eagle("givenId");
            Assert.AreEqual("Bird", eagle.Virtuell());
        }

    }
}
