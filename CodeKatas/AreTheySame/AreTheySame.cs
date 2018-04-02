using System;

namespace CodeKatas
{
    /// <summary>
    /// Checks whether the two arrays have the "same" elements, with the same multiplicities.
    /// </summary>
    public class AreTheySame
    {
        /// <summary>
        /// Compares that the elements in b are the elements in a squared, regardless of the order.
        /// First, identify if the square elements in a are in b
        /// Second, indentify if the square root elements of b are in a
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Comp(int[] a, int[] b)
        {
            foreach(int item in a)
            {
                int square = item * item;
                bool match = Array.Exists(
                    b,
                    element => element == square
                );
                if (match == false)
                {
                    return false;
                }
            }
            foreach(int item in b)
            {
                int squareRoot = (int) Math.Sqrt(item);
                bool match = Array.Exists(
                    a,
                    element => element == squareRoot
                );
                if (match == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}