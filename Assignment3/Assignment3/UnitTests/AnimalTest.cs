using System;
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
            Assert.IsTrue(0 == String.Compare(id1, id1, StringComparison.Ordinal));
            Assert.IsTrue(0 < String.Compare(id2, id1, StringComparison.Ordinal)); // id2 has later ID number than id1.

        }

        [TestMethod]
        public void GetSpecies()
        {
            Animal bear = new Bear("b", Gender.Female, 42, 17, 0);
            Assert.AreEqual("Bear", bear.GetSpecies());
        }

        [TestMethod]
        public void CopyEagle()
        {
            Eagle e1 = new Eagle("e1", Gender.Male, 0, 0, 0);
            Eagle e2 = new Eagle("e2", Gender.Male, 0, 0, 0);


            Animal e3 = new Eagle(e2);
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotEqual(e1.Id, e2.Id);
            Assert.AreNotSame(e2, e3);
        }

        [TestMethod]
        public void CopyPenguin()
        {
            Penguin e2 = new Penguin("e2", Gender.Male, 0, 0, 0);

            Animal e3 = new Penguin(e2);
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotSame(e2, e3);
        }

        [TestMethod]
        public void CopyBear()
        {
            Bear e2 = new Bear("e2", Gender.Male, 0, 0, 0);

            Animal e3 = new Bear(e2);
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotSame(e2, e3);
        }


        [TestMethod]
        public void CopyGnu()
        {
            Gnu e2 = new Gnu("e2", Gender.Male, 0, 0, 0);

            Animal e3 = new Gnu(e2);
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotSame(e2, e3);
        }


        [TestMethod]
        public void CloningEagle()
        {
            Eagle e2 = new Eagle("e2", Gender.Male, 0, 0, 0);

            Animal e3 = e2.Clone();
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotSame(e2, e3);
        }


        [TestMethod]
        public void CloningPenguin()
        {
            Penguin e2 = new Penguin("e2", Gender.Male, 0, 0, 0);

            Animal e3 = e2.Clone();
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotSame(e2, e3);
        }

        [TestMethod]
        public void CloningBear()
        {
            Bear e2 = new Bear("e2", Gender.Male, 0, 0, 0);

            Animal e3 = e2.Clone();
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotSame(e2, e3);
        }

        [TestMethod]
        public void CloningGnu()
        {
            Gnu e2 = new Gnu("e2", Gender.Male, 0, 0, 0);

            Animal e3 = e2.Clone();
            Assert.AreEqual(e2.Name, e3.Name);
            Assert.AreEqual(e2.Id, e3.Id);
            Assert.AreNotSame(e2, e3);
        }

        [TestMethod]
        public void Eatertypes()
        {
            Assert.AreEqual(EaterType.Carnivore, new Eagle("", Gender.Female, 0, 0, 0).GetEaterType());
            Assert.AreEqual(EaterType.Carnivore, new Penguin("", Gender.Female, 0, 0, 0).GetEaterType());
            Assert.AreEqual(EaterType.Omnivore, new Bear("", Gender.Female, 0, 0, 0).GetEaterType());
            Assert.AreEqual(EaterType.Herbivore, new Gnu("", Gender.Female, 0, 0, 0).GetEaterType());
        }

    }
}