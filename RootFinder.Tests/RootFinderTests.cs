using System;
using NUnit.Framework;
namespace RootFinder.Tests
{
    public class RootFinderTests
    {
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]

        public double FindNthRoot_TestsWithValues(double a, int n, double eps)
            => RootFinder.FindNthRoot(a, n, eps);

        [Test]
        public void FindNthRoot_WithNegativeN_ThrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => RootFinder.FindNthRoot(5, 0, 0.001));

        [Test]
        public void FindNthRoot_WithNegativeA_ThrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => RootFinder.FindNthRoot(-5, 1, 0.001));

        [Test]
        public void FindNthRoot_WithIncorrectEpsilon_ThrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => RootFinder.FindNthRoot(5, 1, -0.001));
    }
}
