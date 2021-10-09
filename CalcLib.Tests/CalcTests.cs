using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLib.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_10and30_40returned()
        {
            //arrange
            int x = 10;
            int y = 30;
            int expected = 40;

            //actual
            Calc c = new Calc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
