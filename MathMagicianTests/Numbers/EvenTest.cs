using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            Even evenNumber = new Even();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureICanGetFirsEventNumber()
        {
            //Arrange
            Even evenNumber = new Even();

            //Act
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNextEvenNumber()
        {
            //Arrange
            Even evenNumber = new Even();

            //Act
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetEvenSequenceArray()
        {
            //Arrange
            Even evenNumber = new Even();

            //Act
            int[] expectedResult = { 2, 4, 6, 8, 10, 12 };
            int[] actualResult = evenNumber.GetSequence(6);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetEvenArrayPrintOut()
        {
            //arrange
            Even evenNumber = new Even();

            //act
            string expectedResult = "2 4 6 8 10";
            int[] inputArray = new[] { 2, 4, 6, 8, 10 };
            string actualResult = evenNumber.PrintNumbers(inputArray);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
