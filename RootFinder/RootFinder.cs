using System;

namespace RootFinder
{
    /// <summary>
    /// Static class provides one static method to find the n-th root of a number
    /// </summary>
    public static class RootFinder
    {
        /// <summary>
        /// This method finds the n-th root of a number
        /// </summary>
        /// <param name="A">
        /// Number
        /// </param>
        /// <param name="n">
        /// Degree of root
        /// </param>
        /// <param name="eps">
        /// The accuracy of computations
        /// </param>
        /// <returns>
        /// N-th root of Number
        /// </returns>
        public static double FindNthRoot(double A, int n, double eps)
        {
            if (eps < 0 || eps > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(eps));
            }

            if (A < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(A));
            }

            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double currentApproximation = A / n;
            double nextApproximation = (1 / (double)n) * ((n - 1) * currentApproximation + A / Math.Pow(currentApproximation, n - 1));

            while (Math.Abs(nextApproximation - currentApproximation) > eps)
            {
                currentApproximation = nextApproximation;
                nextApproximation = (1 / (double)n) * ((n - 1) * currentApproximation + A / Math.Pow(currentApproximation, n - 1));
            }
            
            return nextApproximation;
        }
    }
}
