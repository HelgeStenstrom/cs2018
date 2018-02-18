using Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void UniqueIdStrings()
        {
            var a1 = new Eagle("", Gender.Male, 0, 0, 0);
            var a2 = new Eagle("", Gender.Male, 0, 0, 0);
            string id1 = a1.Id;
            string id2 = a2.Id;
            Assert.IsTrue(0 == id1.CompareTo(id1));
            Assert.IsTrue(0 < id2.CompareTo(id1)); // id2 has later ID number than id1.

        }

        [TestMethod]
        public void GetSpecies()
        {
            Animal bear = new Bear("b", Gender.Female, 42, 17, 0);
            Assert.AreEqual("Bear", bear.GetSpecies());
        }

        [TestMethod]
        public void CopyConstruct()
        {
            Eagle e1 = new Eagle("e1", Gender.Male, 0, 0, 0);
            Animal e2 = new Eagle("e2", Gender.Male, 0, 0, 0);


            Animal e3 = e1.Clone();
        }

    }
}