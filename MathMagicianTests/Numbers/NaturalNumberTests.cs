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
            //arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            int expectedResult = 4;
            int actualResult = naturalNumber.GetNext(3);


            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumberSequence()
        {
            //arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            int[] expectedResult = { 1, 2, 3, 4, 5, 6 };
            int[] actualResult = naturalNumber.GetSequence(6);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintToConsole()
        {
            //arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            string expectedResult = "1 2 3 4 5";
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            string actualResult = naturalNumber.PrintNumbers(inputArray);
            //string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}
