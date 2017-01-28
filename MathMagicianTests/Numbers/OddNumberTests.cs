using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            Odd oddNumber = new Odd();

            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void EnsureICanGetFirsOddtNumber()
        {
            //Arrange
            Odd oddNumber = new Odd();

            //Act
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNextoddNumber()
        {
            //Arrange
            Odd oddNumber = new Odd();

            //Act
            int expectedResult = 3;
            int actualResult = oddNumber.GetNext(1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetOddSequenceArray()
        {
            //Arrange
            Odd oddNumber = new Odd();

            //Act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11 };
            int[] actualResult = oddNumber.GetSequence(6);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetOddArrayPrintOut()
        {
            //arrange
            Odd oddNumber = new Odd();

            //act
            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = oddNumber.PrintNumbers(inputArray);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
