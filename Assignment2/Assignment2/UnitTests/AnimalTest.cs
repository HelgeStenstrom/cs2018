using Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        [Ignore]
        public void UniquenessByString()
        {
            var a1 = new Eagle("", "", Gender.Male, 0, 0, 0);
            var a2 = new Eagle("", "", Gender.Male, 0, 0, 0);
            Assert.Fail("Test not done");
        }

        [TestMethod]
        public void GetSpecies()
        {
            Animal bear = new Bear("a", "b", Gender.Female, 42, 17, 0);
            Assert.AreEqual("Bear", bear.GetSpecies());
        }
    }
}