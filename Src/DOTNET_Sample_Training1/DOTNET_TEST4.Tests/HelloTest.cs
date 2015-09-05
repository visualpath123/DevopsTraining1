
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DOTNet_Test2;
namespace DOTNET_TEST4.Tests
{
    
    
    /// <summary>
    ///This is a test class for HelloTest and is intended
    ///to contain all HelloTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HelloTest
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SaySomething
        ///</summary>
        [TestMethod()]
        public void SaySomethingTest()
        {
            Hello target = new Hello(); // TODO: Initialize to an appropriate value
            string input = "world"; // TODO: Initialize to an appropriate value
            string expected = "Hello World"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SaySomething(input);
            Assert.AreEqual(expected, actual);
        }

		[TestMethod()]
        public void largeNumberTest()
        {
            Hello target = new Hello(); // TODO: Initialize to an appropriate value
            
            int actual = target.largeNumber(2,3,4);
            Assert.AreEqual(4, actual);
        }
        
		[TestMethod()]
        public void subtractTest()
        {
            Hello target = new Hello(); // TODO: Initialize to an appropriate value
            
            int actual = target.subtract(4,2);
            Assert.AreEqual(2, actual);
        }
		
		
		[TestMethod()]
        public void addTest()
        {
            Hello target = new Hello(); // TODO: Initialize to an appropriate value
            
            int actual = target.add(4,2);
            Assert.AreEqual(6, actual);
        }

		[TestMethod()]
        public void divideTest()
        {
            Hello target = new Hello(); // TODO: Initialize to an appropriate value
            
            int actual = target.divide(4,2);
            Assert.AreEqual(2, actual);
        }

		[TestMethod()]
        public void multiplyTest()
        {
            Hello target = new Hello(); // TODO: Initialize to an appropriate value
            
            int actual = target.multiply(4,2);
            Assert.AreEqual(8, actual);
        }

		[TestMethod()]
        public void myFunctionTest()
        {
            Hello target = new Hello(); // TODO: Initialize to an appropriate value
            
            bool actual = target.myFunction();
            Assert.AreEqual(true, actual);
        }






		/// <summary>
        ///A test for combineArrayStringWithSpace
        ///</summary>
      /*  [TestMethod()]
        public void combineArrayStringWithSpaceTest()
        {
            //ApplicationCodeClass target = new ApplicationCodeClass(); // TODO: Initialize to an appropriate value
            string[] stringArray = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = null;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }  
		*/


    }
}
