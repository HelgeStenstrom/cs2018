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

        [TestMethod]
        public void SortByName()
        {
            // Setup
            var mgr = new AnimalManager();

            IAnimal bear1 = new Bear("Adam", Gender.Male, 5, 32, 147);
            var bear2 = new Bear("David", Gender.Male, 4, 32, 147);
            var p1 = new Penguin("Caesar", Gender.Male, 3, 32, 147);
            IAnimal e1 = new Eagle("Bertil", Gender.Female, 2, 11, 100);

            mgr.AddAnimal(bear1);
            mgr.AddAnimal(bear2);
            mgr.AddAnimal(p1);
            mgr.AddAnimal(e1);
            
            // pre-check
            Assert.AreNotEqual(bear1.Name, bear2.Name );

            // Execute       
            mgr.SortBy("Name");
            // We should be able to sort on Id, gender, name, age, eatertype, species or in general all properties that every Animal has.

            // Verify
            Assert.AreEqual("Adam", mgr.GetAnimal(0).Name);
            Assert.AreEqual("Bertil", mgr.GetAnimal(1).Name);


            // Execute again
            mgr.SortBy("ID");
            // Verify
            Assert.AreEqual("Adam", mgr.GetAnimal(0).Name);
            Assert.AreEqual("David", mgr.GetAnimal(1).Name);

            // Execute again
            mgr.SortBy("Age");
            // Verify
            Assert.AreEqual("Bertil", mgr.GetAnimal(0).Name);
            Assert.AreEqual("Caesar", mgr.GetAnimal(1).Name);

        }
    }
}