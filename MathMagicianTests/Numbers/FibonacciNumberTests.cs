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
    }
}
