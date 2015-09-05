using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MYDOTNet;
namespace DOTNet_Test
{

    [TestClass]
    public class MYUnitTest1
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        ///A test for SaySomething
        ///</summary>
        [TestMethod()]
        public void SaySomethingTest()
        {
            MYDOTNet.MYHello  target = new MYHello(); // TODO: Initialize to an appropriate value
            string input = "world"; // TODO: Initialize to an appropriate value
            string expected = "Hello World"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SaySomething(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void largeNumberTest()
        {
            MYHello target = new MYHello(); // TODO: Initialize to an appropriate value

            int actual = target.largeNumber(2, 3, 4);
            Assert.AreEqual(4, actual);
        }

        [TestMethod()]
        public void subtractTest()
        {
            MYHello target = new MYHello(); // TODO: Initialize to an appropriate value

            int actual = target.subtract(4, 2);
            Assert.AreEqual(2, actual);
        }


        [TestMethod()]
        public void addTest()
        {
            MYHello target = new MYHello(); // TODO: Initialize to an appropriate value

            int actual = target.add(4, 2);
            Assert.AreEqual(6, actual);
        }

        [TestMethod()]
        public void divideTest()
        {
            MYHello target = new MYHello(); // TODO: Initialize to an appropriate value

            int actual = target.divide(4, 2);
            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        public void multiplyTest()
        {
            MYHello target = new MYHello(); // TODO: Initialize to an appropriate value

            int actual = target.multiply(4, 2);
            Assert.AreEqual(8, actual);
        }

    }
}
