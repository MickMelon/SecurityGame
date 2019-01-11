using System;
using System.Collections.Generic;

namespace SecurityGame.Extensions
{
    public static class ListExtensions
    {
        private static Random random = new Random();

        /// <summary>
        /// Shuffles a List based on the Fisher-Yates shuffle.
        /// </summary>
        /// <param name="list">The list to be shuffled.</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
