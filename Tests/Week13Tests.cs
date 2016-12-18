using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Tasks;


namespace Tests
{
    [TestClass]
    public class Week13Tests
    {
        [TestMethod]
        public void Puzzle11Test()
        {
            Assert.AreEqual('\0', Week13.GetCharByIndex(1, null)); // '\0' kõik nullid
            Assert.AreEqual('\0', Week13.GetCharByIndex(1));
            Assert.AreEqual('\0', Week13.GetCharByIndex(3, 'a','b','c'));
            Assert.AreEqual('\0', Week13.GetCharByIndex(-1, 'a', 'b', 'c'));
            Assert.AreEqual('b', Week13.GetCharByIndex(1, 'a', 'b', 'c'));
            Assert.AreEqual('b', Week13.GetCharByIndex(1, new char[] {'a', 'b', 'c'})); // ilma params'ita töötab ainult see
            Assert.AreEqual('x', Week13.GetCharByIndex(2, 'x','y','x','a', 'b', 'c'));
        }


        /*
        [TestMethod]
        public void Puzzle12Test()
        {
            Assert.AreEqual('\0', Week13.Puzzle12(5, null));
            Assert.AreEqual('\0', Week13.Puzzle12(5, new char[] {}));
            Assert.AreEqual('c', Week13.Puzzle12(5, new [] { 'a', 'b', 'c' }));
            Assert.AreEqual('b', Week13.Puzzle12(1, new [] { 'a', 'b', 'c' }));
            Assert.AreEqual('x', Week13.Puzzle12(2, new []{'x', 'y', 'x', 'a', 'b', 'c'}));
        }
        */

        [TestMethod]
        public void Puzzle13Test()
        {
            int x;
            x = 4;
            Week13.Puzzle13(ref x);// x on 4, puzzle13 muudab xi 16ks.
            Assert.AreEqual(16,x);
            x = 5;
            Week13.Puzzle13(ref x); //x on 5, puzzle13 muudab xi 25ks.
            Assert.AreEqual(25, x);
        }


        [TestMethod]
        public void Puzzle14Test()
        {
            int x;
            x = 4;
            Week13.Puzzle14(x);
            Assert.AreEqual(4, x);// annad 4 sisse, saad 4 tagasi.
            x = 5;
            Week13.Puzzle14(x); 
            Assert.AreEqual(5, x);
        }
        

        [TestMethod]
        public void Puzzle15Test()
        {
            int x;
            x = 4;
            Week13.Puzzle15(4, out x);// 
            Assert.AreEqual(16, x);
            x = 5;
            Week13.Puzzle15(5, out x); //
            Assert.AreEqual(25, x);
        }

      
        [TestMethod]
        public void Puzzle16Test()
        {
            Assert.AreEqual(16,Week13.Puzzle16(4));
            Assert.AreEqual(25,Week13.Puzzle16(5));
        }
        

        [TestMethod]
        public void Puzzle17Test()//arvutab faktoriaali
        {
            Assert.AreEqual(1, Week13.Factorial(-1));
            Assert.AreEqual(1, Week13.Factorial(0));
            Assert.AreEqual(1, Week13.Factorial(1));
            Assert.AreEqual(2, Week13.Factorial(2));
            Assert.AreEqual(6, Week13.Factorial(3));
            Assert.AreEqual(24, Week13.Factorial(4));
            Assert.AreEqual(120, Week13.Factorial(5));
            Assert.AreEqual(720, Week13.Factorial(6));
        }


        [TestMethod]
        public void Puzzle18Test()//pöörab sõna tagurpidi
        {
            Assert.AreEqual("", Week13.Puzzle18(null));
            Assert.AreEqual("", Week13.Puzzle18(string.Empty));
            Assert.AreEqual("a", Week13.Puzzle18("a"));
            Assert.AreEqual("cba", Week13.Puzzle18("abc"));         
        }

        
        [TestMethod]
        public void Puzzle19Test()//kontrollib kas ob peegelpildi efekt
        {
            Assert.AreEqual(false, Week13.Puzzle19(null));
            Assert.AreEqual(false, Week13.Puzzle19(string.Empty));
            Assert.AreEqual(true, Week13.Puzzle19("a"));
            Assert.AreEqual(true, Week13.Puzzle19("anna"));
            Assert.AreEqual(false, Week13.Puzzle19("beta"));
            Assert.AreEqual(true, Week13.Puzzle19("123454321"));
        }
       

        [TestMethod]
        public void Puzzle20Test()//arvutab faktoriaali
        {            
            Assert.AreEqual(0u, Week13.Puzzle20(0));
            Assert.AreEqual(1u, Week13.Puzzle20(1));
            Assert.AreEqual(2u, Week13.Puzzle20(2));
            Assert.AreEqual(3u, Week13.Puzzle20(3));
            Assert.AreEqual(5u, Week13.Puzzle20(4));
            Assert.AreEqual(8u, Week13.Puzzle20(5));
            Assert.AreEqual(13u, Week13.Puzzle20(6));
            Assert.AreEqual(21u, Week13.Puzzle20(7));
            Assert.AreEqual(34u, Week13.Puzzle20(8));
        }

        [TestMethod]
        public void Puzzle100Test()//arvutab faktoriaali
        {
            Assert.AreEqual(0, Week13.Puzzle100(0));
            Assert.AreEqual(1, Week13.Puzzle100(1));
            Assert.AreEqual(1, Week13.Puzzle100(2));
            Assert.AreEqual(2, Week13.Puzzle100(3));
            Assert.AreEqual(3, Week13.Puzzle100(4));
            Assert.AreEqual(5, Week13.Puzzle100(5));
            Assert.AreEqual(8, Week13.Puzzle100(6));
            Assert.AreEqual(13, Week13.Puzzle100(7));
            Assert.AreEqual(21, Week13.Puzzle100(8));
            Assert.AreEqual(34, Week13.Puzzle100(9));
        }
    }
}
