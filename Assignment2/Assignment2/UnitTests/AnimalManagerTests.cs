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
            Animal p = new Penguin("Tux", Gender.Male, 0, 0, 0);
            var p2 = new Penguin("Tux", Gender.Male, 0, 0, 0);
            var mgr = new AnimalManager();
            
            // Exercise
            mgr.AddAnimal(p);  // an Animal
            mgr.AddAnimal(p2); // a Penguin
            
            // Verify
            var x = mgr.AnimalssAsRows;
            Assert.AreEqual(2, x.Count());

        }

        [TestMethod]
        public void SortByX()
        {
            // Setup
            var mgr = new AnimalManager();

            Animal bear1 = new Bear("Bamse", Gender.Male, 3, 32, 147);
            var bear2 = new Bear("Tapio", Gender.Male, 3, 32, 147);
            var p1 = new Penguin("Tapio", Gender.Male, 3, 32, 147);
            Animal e1 = new Eagle("Eddie", Gender.Female, 1, 11, 100);

            mgr.AddAnimal(bear1);
            mgr.AddAnimal(bear2);
            mgr.AddAnimal(p1);
            mgr.AddAnimal(e1);
            
            // pre-check
            Assert.AreNotEqual(bear1.Name, bear2.Name );

            // Execute       
            mgr.SortBy("name");
            // We should be able to sort on Id, gender, name, age, eatertype, species or in general all properties that every Animal has.

            // Verify

            Assert.Fail("Test not done");
        }
    }
}