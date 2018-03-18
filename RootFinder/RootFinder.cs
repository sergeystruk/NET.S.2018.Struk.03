using System;

namespace RootFinder
{
    public static class RootFinder
    {
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
