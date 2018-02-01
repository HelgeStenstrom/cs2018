using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System;
using System.Collections.Generic;

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
        public void UniqueAnimals()
        {
            int last = Animal.LastAssignedIdNumber;
            //string expected = $"A{last}";
            string given = "A";
            Animal a = new Eagle(given);
            var x = a.RowStrings;
            var id = x[1];
            Assert.AreEqual(given, x[0]);
            Assert.AreEqual($"A{last}", id);
            Assert.AreEqual(last + 1, Animal.LastAssignedIdNumber);

            last += 1;
            a = new Cat(given);
            x = a.RowStrings;
            id = x[1];

            Assert.AreEqual(given, x[0]);
            Assert.AreEqual($"A{last}", id);
            Assert.AreEqual(last + 1, Animal.LastAssignedIdNumber);       
        }

        [TestMethod]
        public void findSpecies()
        {
            List<Type> x = AnimalManager.Species();
            Assert.AreEqual(4, x.Count);            
        }

        [TestMethod]
        public void findBirds()
        {
            List<Type> x = AnimalManager.OfCategory(typeof(Bird));
            Assert.AreEqual(2, x.Count);
            Assert.IsTrue(x.Contains(typeof(Eagle)));
            Assert.IsTrue(x.Contains(typeof(Penguin)));
            Assert.IsFalse(x.Contains(typeof(Bear)));
            Assert.IsFalse(x.Contains(typeof(Cat)));

            List<string> names = new List<string>();
            foreach (Type t in x)
            {
                names.Add(t.Name);
            }
            Assert.IsTrue(names.Contains("Eagle"));

            Assert.IsTrue(AnimalManager.TypeNames(AnimalManager.OfCategory(typeof(Bird))).Contains("Eagle"));
        }

    }
}
