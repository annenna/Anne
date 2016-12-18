using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PersonClasses;

namespace Tests.PersonClasses
{
    [TestClass]
    public class PersonTests
    {

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(new Person());
        }


        [TestMethod]
        public void NameTest()
        {
            var m = new Person();
            Assert.IsNotNull(m.Name);
            m.Name = null;
            Assert.IsNotNull(m.Name);
        }
    }

    
    }

