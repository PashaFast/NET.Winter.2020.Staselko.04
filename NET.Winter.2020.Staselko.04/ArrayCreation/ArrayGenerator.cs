using System;
using System.Linq;

namespace ArrayCreation
{
    /// <summary>
    /// Class ArrayGenerator.
    /// </summary>
    public static class ArrayGenerator
    {
        /// <summary>
        /// This method generates a sorted array of "count" elements
        /// starting at the "start" position and with step 1.
        /// </summary>
        /// <param name="start">start number.</param>
        /// <param name="count">counts of elements.</param>
        /// <returns>Sorted array.</returns>
        public static int[] GetSortedArray(int start, int count)
        {
            return Enumerable.Range(start, count).ToArray();
        }

        /// <summary>
        /// this method generates an array of elements, that containы the given digit.
        /// </summary>
        /// <param name="count">counts of elements.</param>
        /// <param name="digit">the number that all elements must contain.</param>
        /// <returns>Array of elements, that containы the given digit. </returns>
        public static int[] GetArrayWithDigit(int count, int digit)
        {
            return Enumerable.Repeat(digit, count).ToArray();
        }

        /// <summary>
        /// This method mixes the array.
        /// </summary>
        /// <param name="array">Array for mixing.</param>
        /// <returns>Mixed array.</returns>
        public static int[] GetMixArrayFirstAlgotithm(int[] array)
        {
            Random random = new Random();
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "cannot be null");
            }

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                Swap(ref array[i], ref array[j]);
            }

            return array;
        }

        /// <summary>
        /// This method mixes the array.
        /// </summary>
        /// <param name="array">Array for mixing.</param>
        /// <returns>Mixed array.</returns>
        public static int[] GetMixArraySecondAlgotithm(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "cannot be null");
            }

            for (int i = 0; i < (array.Length / 2) - 1; i++)
            {
                Swap(ref array[i], ref array[array.Length - i - 1]);
            }

            return array;
        }

        /// <summary>
        /// This method mixes the array.
        /// </summary>
        /// <param name="array">Array for mixing.</param>
        /// <returns>Mixed array.</returns>
        public static int[] GetMixArrayThirdAlgotithm(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "cannot be null");
            }

            for (int i = 0; i < array.Length - 1; i += 2)
            {
                Swap(ref array[i], ref array[i + 1]);
            }

            return array;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
