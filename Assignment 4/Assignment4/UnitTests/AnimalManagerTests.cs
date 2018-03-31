using System.Linq;
using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AnimalManagerTests
    {

        [TestMethod] 
        //[Ignore]
        public void AddingAnimalObjects()
        {
            // Setup
            IAnimal p = new Penguin("Tux", Gender.Male, 0, 0, 0);
            var p2 = new Penguin("Tux", Gender.Male, 0, 0, 0);
            var mgr = new AnimalManager();
            
            // Exercise
            mgr.Add(p);  // an Animal
            mgr.Add(p2); // a Penguin
            
            // Verify
            Assert.AreEqual(2, mgr.AnimalssAsRows.Count());

        }

    }
}