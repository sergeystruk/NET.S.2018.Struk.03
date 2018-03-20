using System;
using NUnit.Framework;
namespace RootFinder.Tests
{
    public class RootFinderTests
    {
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        [TestCase(0.005, 1, 0.1, 0.1)]

        public void FindNthRoot_TestsWithValues(double number, int degree, double precision, double result)
            => Assert.AreEqual(RootFinder.FindNthRoot(number, degree, precision), result, precision);

        [Test]
        public void FindNthRoot_WithNegativeN_ThrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => RootFinder.FindNthRoot(5, 0, 0.001));

        [Test]
        public void FindNthRoot_WithNegativeA_ThrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => RootFinder.FindNthRoot(-5, -2, 0.001));

        [Test]
        public void FindNthRoot_WithIncorrectEpsilon_ThrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => RootFinder.FindNthRoot(5, 2, -0.001));
    }
}
