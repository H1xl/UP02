using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassLibrary.Tests1
{
    [TestClass]
    public class LearnClassTest1
    {
        // Заблаговременно не проходимый тест перевода часов + минут в секунды
        [TestMethod]
        public void TestTimeInSeconds()
        {
            // arrange
            int a = 2;
            int b = 3;
            int expected = 7380;

            // act
            LearnClass c = new LearnClass();
            int actual = c.TimeInSeconds(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        // Собственный тест перевода секунд в часы
        [TestMethod]
        public void TimeSecondsToHours()
        {
            // arrange
            int a = 7200;
            int expected = 2;

            // act
            LearnClass c = new LearnClass();
            int actual = c.TimeSecondsToHours(a);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
