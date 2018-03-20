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
        /// <param name="precision">
        /// The accuracy of computations
        /// </param>
        /// <returns>
        /// N-th root of Number
        /// </returns>
        public static double FindNthRoot(double number, int degree, double precision)
        {
            if (degree == 1)
            {
                return number;
            }
            if (precision < 0 || precision > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(precision));
            }

            if (number < 0 && degree % 2 == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            if (degree <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(degree));
            }

            double currentApproximation = number / degree;
            double nextApproximation = (1.0 / degree) * ((degree - 1) * currentApproximation + number / Math.Pow(currentApproximation, degree - 1));

            while (Math.Abs(nextApproximation - currentApproximation) > precision)
            {
                currentApproximation = nextApproximation;
                nextApproximation = (1.0 / degree) * ((degree - 1) * currentApproximation + number / Math.Pow(currentApproximation, degree - 1));
            }
            
            return nextApproximation;
        }
    }
}
