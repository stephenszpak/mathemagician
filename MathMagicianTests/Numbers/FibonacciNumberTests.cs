using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        //Recursive Definition of Fibonacci
        //F3 = F2 + F1
        //F7 = F6 + F5

        [TestMethod]
        public void EnsureICanCreatInstance()
        {
            Fibonacci fibNumber = new Fibonacci();

            Assert.IsNotNull(fibNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            Fibonacci fibNumber = new Fibonacci();

            int expectedResult = 1;
            int actualResult = fibNumber.GetFirst();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumberPrints()
        {
            Fibonacci fibNumber = new Fibonacci();

            int expectedResult =  5;
            int actualResult = fibNumber.GetNext(3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFibonacciSequence()
        {
            Fibonacci fibSequence = new Fibonacci();

            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13, 21 };
            int[] actualResult = fibSequence.GetSequence(8);

            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintToConsole()
        {
            Fibonacci fibNumber = new Fibonacci();

            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = fibNumber.PrintNumbers(inputArray);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
