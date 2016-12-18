using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PersonClasses;

namespace Tests.PersonClasses
{
    [TestClass] public class BaseListTests
    {
        private BaseList<string> list;

        [TestInitialize]
        public void TestInit() { 
        list= new BaseList<string>();
            list.Add("A");
            list.Add("B");
        }

        [TestCleanup]
        public void TestCleanup() {
            list = null;
        }

        [TestMethod]
        public void ConstructorTest() {
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void CountTest(){
            var c = list.Count;
            list.Add("C");
            Assert.AreEqual(c+1, list.Count);
        }

        [TestMethod]
        public void AddTest(){
            Assert.IsFalse(list.Contains("C"));
            list.Add("C");
            Assert.IsTrue(list.Contains("C"));
        }

        [TestMethod]
        public void ContainsTest(){
            AddTest();
        }

        [TestMethod]
        public void Test() {
            AddTest();
        }
    }
}

