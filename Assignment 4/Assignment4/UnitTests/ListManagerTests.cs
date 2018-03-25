using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests
{
    [TestClass()]
    public class ListManagerTests
    {
        ListManager<int> lm = new ListManager<int>();

        [TestInitialize]
        public void setup()
        {
        }


        [TestMethod()]
        public void ListManagerTest()
        {
            // var lm = new ListManager<int>();
            Assert.AreEqual(0, lm.Count);
        }

        [TestMethod()]
        public void AddTest()
        {
            var ok = lm.Add(6);
            Assert.AreEqual(1, lm.Count);
            Assert.AreEqual(6, lm.GetAt(0));
            Assert.IsTrue(ok);
        }

        [TestMethod()]
        public void AddTestFail()
        {
            ListManager<Animal> lm = new ListManager<Animal>();
            var ok = lm.Add(null);
            Assert.IsFalse(ok);
        }

        [TestMethod()]
        public void ChangeAtTest()
        {
            lm.Add(6);
            lm.Add(7);
            var ok = lm.ChangeAt(3, 0);
            Assert.AreEqual(2, lm.Count);
            Assert.AreEqual(3, lm.GetAt(0));
            Assert.IsTrue(ok);
        }

        [TestMethod()]
        public void ChangeFail()
        {
            ListManager<string> lm = new ListManager<string>();
            lm.Add("hej");
            var ok = lm.ChangeAt("x", 0);
            Assert.IsTrue(ok);
            ok = lm.ChangeAt(null, 0);
            Assert.IsFalse(ok);
        }

        [TestMethod()]
        public void CheckIndexTest()
        {
            Assert.IsFalse(lm.CheckIndex(0));
            lm.Add(1);
            Assert.IsTrue(lm.CheckIndex(0));
            Assert.IsFalse(lm.CheckIndex(1));
        }

        [TestMethod()]
        public void DeleteAllTest()
        {
            // Setup
            Assert.AreEqual(0, lm.Count);
            lm.Add(1);
            lm.Add(1);
            Assert.AreEqual(2, lm.Count);
            // Exercise
            lm.DeleteAll();
            // Verify
            Assert.AreEqual(0, lm.Count);
        }

        [TestMethod()]
        public void DeleteAtTest()
        {
            // Setup
            lm.Add(1);
            lm.Add(2);
            lm.Add(3);

            // Execute
            var ok = lm.DeleteAt(1);

            // Verify
            Assert.IsTrue(ok);
            Assert.AreEqual(3, lm.GetAt(1));
            Assert.IsFalse(lm.DeleteAt(17));
        }

        [TestMethod()]
        public void GetAtTest()
        {
            // Setup
            lm.Add(1);
            lm.Add(2);
            lm.Add(30);

            Assert.AreEqual(30, lm.GetAt(2));
            Assert.AreEqual(2, lm.GetAt(1));
            Assert.AreEqual(1, lm.GetAt(0));
        }

        [TestMethod()]
        public void ToStringArrayTest()
        {
            // Setup
            lm.Add(1);
            lm.Add(2);
            lm.Add(30);

            var res = lm.ToStringList();
            Assert.AreEqual("1", res[0]);
            Assert.AreEqual("2", res[1]);
            Assert.AreEqual("30", res[2]);
        }

        [TestMethod()]
        public void ToStringListTest()
        {
            // Setup
            lm.Add(1);
            lm.Add(2);
            lm.Add(30);

            var res = lm.ToStringArray();
            Assert.AreEqual("1", res[0]);
            Assert.AreEqual("2", res[1]);
            Assert.AreEqual("30", res[2]);
        }
    }
}