using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PersonClasses;

namespace Tests.PersonClasses
{
    [TestClass] public class DateTimePeriodTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(new DateTimePeriod());
        }


        [TestMethod]
        public void FromTest()
        {
            var d = new DateTimePeriod();
            d.OnChanged += DoOnChanged;
            d.From = DateTime.Now;
        }

        private string invoked;

        private void DoOnChanged(object sender, EventArgs e)
        {
            invoked = "invoked";
        }
    }

}

