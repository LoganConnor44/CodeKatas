using System;

namespace CodeKatas
{
    public class AreTheySame
    {
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