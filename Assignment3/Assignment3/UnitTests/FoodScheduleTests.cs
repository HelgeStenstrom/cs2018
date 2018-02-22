using System.Collections.Generic;
using Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FoodScheduleTests
    {


        [TestMethod]
        public void List_constructor()
        {
            // setup
            List<string> foods = new List<string>();
            foods.Add("one");
            foods.Add("two");
            
            // Exercise
            var foodSchedule = new FoodSchedule(foods);
            
            // Verify
            Assert.AreEqual(2, foodSchedule.Count);
        }

        [TestMethod]
        public void Get_item()
        {
            // Setup
            List<string> foods = new List<string>();
            foods.Add("one");
            foods.Add("two");
            var foodSchedule = new FoodSchedule(foods);
            
            // Exercise
            Assert.AreEqual("two", foodSchedule.GetFoodSchedule(1));
            Assert.AreEqual("one", foodSchedule.GetFoodSchedule(0));
        }

        [TestMethod]
        public void Iterate_over_foods()
        {
            // Setup
            List<string> foods = new List<string>
            {
                "one",
                "two"
            };
            var foodSchedule = new FoodSchedule(foods);

            List<string> cpy = new List<string>();
            
            // Exercise 
            foreach (var f in foodSchedule)
            {
                cpy.Add(f);
            }
            
            // Verify
            Assert.AreEqual(foods.Count, cpy.Count);
            for (var i = 0; i < foods.Count; i++)
            {
                Assert.AreEqual(foods[i], cpy[i]);
            }
        }
    }
}
