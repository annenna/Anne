using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PersonClasses;

namespace Tests.PersonClasses
{
    [TestClass] public class BaseClassTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(new BaseClass());
        }
    }
}
