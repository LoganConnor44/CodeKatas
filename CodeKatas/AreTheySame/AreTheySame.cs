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
            return true;
        }
    }
}