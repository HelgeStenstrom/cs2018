using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass()]
    public class ListManagerTests
    {
        ListManager<int> lm = new ListManager<int>();

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
            ListManager<Animal> lmAnimal = new ListManager<Animal>();
            var ok = lmAnimal.Add(null);
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
            ListManager<string> lmString = new ListManager<string>();
            lmString.Add("hej");
            var ok = lmString.ChangeAt("x", 0);
            Assert.IsTrue(ok);
            ok = lmString.ChangeAt(null, 0);
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