using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Tasks;

namespace Tests
{
    [TestClass]
    public class Week12Tests
    {
        [TestMethod]
        public void Puzzle1Test()
        {
            Assert.AreEqual("abc", Week12.Puzzle1("cba"));
            Assert.AreEqual("", Week12.Puzzle1(null));
        }

        [TestMethod]
        public void Puzzle2Test()
        {          
           Assert.AreEqual(0, Week12.Puzzle2(0));
           Assert.AreEqual(1, Week12.Puzzle2(1));
           Assert.AreEqual(4, Week12.Puzzle2(2));
           Assert.AreEqual(9, Week12.Puzzle2(3));
           Assert.AreEqual(625, Week12.Puzzle2(25));
           Assert.AreEqual(16, Week12.Puzzle2(4));
        }


        [TestMethod]
        public void Puzzle3Test()
        {
            Assert.AreEqual(0, Week12.Puzzle3(""));
            Assert.AreEqual(0, Week12.Puzzle3(null));
            Assert.AreEqual(97, Week12.Puzzle3("a"));
            Assert.AreEqual(194, Week12.Puzzle3("aa"));
            Assert.AreEqual(98, Week12.Puzzle3("b"));
            Assert.AreEqual(294, Week12.Puzzle3("abc"));
        }


        [TestMethod]
        public void Puzzle4Test()
        {
            Assert.AreEqual("", Week12.Puzzle4(string.Empty));
            Assert.AreEqual("", Week12.Puzzle4(null));
            Assert.AreEqual("d", Week12.Puzzle4("a"));
            Assert.AreEqual("dd", Week12.Puzzle4("aa"));
            Assert.AreEqual("e", Week12.Puzzle4("b"));
            Assert.AreEqual("def", Week12.Puzzle4("abc"));
            Assert.AreEqual("abc", Week12.Puzzle4("xyz"));
        }

        [TestMethod]
        public void Puzzle5Test()
        {
            Assert.AreEqual("", Week12.Puzzle5(string.Empty));
            Assert.AreEqual("", Week12.Puzzle5(null));
            Assert.AreEqual("a", Week12.Puzzle5("a"));
            Assert.AreEqual("a", Week12.Puzzle5("aa"));
            Assert.AreEqual("b", Week12.Puzzle5("b"));
            Assert.AreEqual("abc", Week12.Puzzle5("abc"));
            Assert.AreEqual("a", Week12.Puzzle5("aaaa"));
            Assert.AreEqual("abx", Week12.Puzzle5("abxab"));
        }

        [TestMethod]
        public void Puzzle6Test()
        {
            Assert.AreEqual("", Week12.Puzzle6(null));
            Assert.AreEqual("97", Week12.Puzzle6("a"));
            Assert.AreEqual("98", Week12.Puzzle6("b"));
            Assert.AreEqual("120", Week12.Puzzle6("x"));
            Assert.AreEqual("9797", Week12.Puzzle6("aa"));
            Assert.AreEqual("120121122", Week12.Puzzle6("xyz"));     
        }

        [TestMethod]
        public void Puzzle7Test()
        {
            Assert.AreEqual(0, Week12.Puzzle7(0));
            Assert.AreEqual(2, Week12.Puzzle7(1,1));
            Assert.AreEqual(15, Week12.Puzzle7(1,2,3,4,5));         
        }

        [TestMethod]
        public void Puzzle8Test()
        {
            Assert.AreEqual(0, Week12.Puzzle8(0,0));
            Assert.AreEqual(243, Week12.Puzzle8(121, 122));
        }

       
        [TestMethod]
        public void Puzzle9Test()
        {
            Assert.AreEqual(0, Week12.Puzzle9(0));
            Assert.AreEqual(1, Week12.Puzzle9(1, 1));
            Assert.AreEqual(208, Week12.Puzzle9(1, 208, 3, 4, 5));
        }
        
        [TestMethod]
        public void Puzzle10Test()
        {
            Assert.AreEqual(0, Week12.Puzzle10(0));
            Assert.AreEqual(-1, Week12.Puzzle10(1));
            Assert.AreEqual(10, Week12.Puzzle10(-10));
        }
    }
}
