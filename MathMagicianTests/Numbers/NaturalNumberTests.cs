using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // this is a sanity check test.
        //ensures everything is hooked up correctly AND
        // that the permission are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            //Arrange  (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureTwoIsNextNumber()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            int expectedResult = 4;
            int actualResult = naturalNumber.GetNext(3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumberSequence()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            int expectedResult = 4;
            int actualResult = naturalNumber.GetSequence();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
