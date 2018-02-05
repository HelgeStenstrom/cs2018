using System;
using System.Collections.Generic;
using System.Linq;
using Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AnimalManagerTests
    {
    
        [TestMethod]
        public void findSpecies()
        {
            List<Type> x = AnimalManager.Species();
            Assert.AreEqual(4, x.Count);            
        }

        [TestMethod]
        public void findBirds()
        {
            // Execute
            List<Type> x = AnimalManager.OfCategory(typeof(Bird));
            
            // Verify
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

        [TestMethod]
        [Ignore]
        public void Sorting()
        {
            // Setup
            var mgr = new AnimalManager();
            mgr.AddAnimal("A", 1, Gender.Female, "1", "1", "Bear");

            Assert.Fail("Test not done");
        }

        [TestMethod] 
        [Ignore]
        public void AddingAnimalObjects()
        {
            // Setup
            Animal p = new Penguin("ID1", "Tux", Gender.Male, 0, 0, 0);
            var p2 = new Penguin("ID2", "Tux", Gender.Male, 0, 0, 0);
            var mgr = new AnimalManager();
            
            // Exercise
            mgr.AddAnimal(p);  // an Animal
            mgr.AddAnimal(p2); // a Penguin
            
            // Verify
            var x = mgr.AnimalssAsRows;
            Assert.AreEqual(2, x.Count());

        }

    }
}