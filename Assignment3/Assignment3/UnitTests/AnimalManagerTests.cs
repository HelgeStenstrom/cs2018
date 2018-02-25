using System;
using System.Collections.Generic;
using System.Linq;
using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AnimalManagerTests
    {
    
        [TestMethod]
        public void FindSpecies()
        {
            List<Type> x = AnimalManager.Species();
            Assert.AreEqual(4, x.Count);            
        }

        [TestMethod]
        public void FindBirds()
        {
            // Execute
            List<Type> x = AnimalManager.OfCategory(typeof(Bird));
            
            // Verify
            Assert.AreEqual(2, x.Count);
            Assert.IsTrue(x.Contains(typeof(Eagle)));
            Assert.IsTrue(x.Contains(typeof(Penguin)));
            Assert.IsFalse(x.Contains(typeof(Bear)));
            Assert.IsFalse(x.Contains(typeof(Gnu)));

            List<string> names = new List<string>();
            foreach (Type t in x)
            {
                names.Add(t.Name);
            }
            Assert.IsTrue(names.Contains("Eagle"));
            Assert.IsTrue(AnimalManager.TypeNames(AnimalManager.OfCategory(typeof(Bird))).Contains("Eagle"));
        }

        [TestMethod] 
        //[Ignore]
        public void AddingAnimalObjects()
        {
            // Setup
            IAnimal p = new Penguin("Tux", Gender.Male, 0, 0, 0);
            var p2 = new Penguin("Tux", Gender.Male, 0, 0, 0);
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