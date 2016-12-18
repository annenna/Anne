using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PersonClasses;

namespace Tests.PersonClasses
{
    [TestClass]class GeographicAddressTests
    {
        private GeographicAddress p;


        [TestInitialize]
        public void TestInitialize(){
           p = new GeographicAddress();
        }

        [TestCleanup]
        public void TestCleanup() {
           p = null;
        }

        [TestMethod]
        public void ConstructorTest() {
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void TownTest() {
            p.Town = "Tallinn";
            Assert.AreEqual("Tallinn", p.Town);
        }
    }
}
