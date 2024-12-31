
using FizzBuzzGame;

namespace FizzBuzz_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Check_Fizz_Buzz CObj = new Check_Fizz_Buzz();

        [TestMethod]
        public void Check_Fizz()
        {
            Assert.AreEqual("Fizz!", CObj.Check_Game(60));
        }

        [TestMethod]
        public void Check_Buzz()
        {
            Assert.AreEqual("Buzz!", CObj.Check_Game(28));
            Assert.AreEqual("Buzz buzz!", CObj.Check_Game(49));
        }
        
        [TestMethod]
        public void Check_FizzBuzz()
        {
            Assert.AreEqual("Fizz fizz Buzz!", CObj.Check_Game(35));
        }

        [TestMethod]
        public void Check_No_FizzBuzz()
        {
            Assert.AreEqual("18!", CObj.Check_Game(18));
            Assert.AreEqual("48!", CObj.Check_Game(48));
        }

        [TestMethod]

        public void Check_Contains_Seven()
        {
            Assert.AreEqual("Buzz!", CObj.Check_Game(47));
        }

        [TestMethod]

        public void Check_Contains_Five()
        {
            Assert.AreEqual("Fizz!", CObj.Check_Game(51));
            Assert.AreEqual("Fizz!", CObj.Check_Game(52));
            Assert.AreEqual("Fizz!", CObj.Check_Game(53));
            Assert.AreEqual("Fizz!", CObj.Check_Game(54));
        }

        [TestMethod]
        public void Check_Fizz_And_Contains_Five()
        {
            Assert.AreEqual("Fizz fizz fizz!", CObj.Check_Game(25));
            Assert.AreEqual("Fizz fizz fizz!", CObj.Check_Game(50));
            Assert.AreEqual("Fizz fizz fizz!", CObj.Check_Game(55));
        }

        [TestMethod]
        public void Check_Fizz_And_Contains_Seven()
        {
            Assert.AreEqual("Fizz Buzz buzz!", CObj.Check_Game(70));
            Assert.AreEqual("Fizz fizz fizz Buzz!", CObj.Check_Game(75));
            Assert.AreEqual("Buzz buzz buzz!", CObj.Check_Game(77));
        }

        [TestMethod]

        public void Check_Buzz_And_Contains_Five()
        {
            Assert.AreEqual("Fizz Buzz!", CObj.Check_Game(56));
            Assert.AreEqual("Fizz Buzz!", CObj.Check_Game(57));
        }

        [TestMethod]

        public void Check_Buzz_And_Contains_seven()
        {
            Assert.AreEqual("Fizz fizz fizz Buzz!", CObj.Check_Game(75));
            Assert.AreEqual("Fizz fizz Buzz!", CObj.Check_Game(105));
        }
    }
}