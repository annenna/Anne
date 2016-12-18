using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PersonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace Tests.PersonClasses
{
    [TestClass] public class GenderTests {

        [TestMethod] public void ConstructorTest()
        {
            Assert.AreEqual(4, Enum.GetNames(typeof(Gender)).Length);
        }

        [TestMethod] public void MaleTest() { }

        [TestMethod] public void NotApplicableTest() { }

        [TestMethod] public void FemaleTest() { }

        [TestMethod] public void NotKnownTestTest() { }
         

    }

   
}
