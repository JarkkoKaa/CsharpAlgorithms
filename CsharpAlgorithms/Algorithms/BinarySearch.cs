using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.Algorithms
{
    class BinarySearch<T>
    {
        /// <summary>
        /// Binary search value from array. If found result returns index else returns -1.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int BSearch(T[] array,T value)
        {
            int lowerBound = 0;
            int higherBound = array.Length;

            var comparer = Comparer<T>.Default;
            while (lowerBound <= higherBound)
            {
                int midPoint = (lowerBound + higherBound) / 2;

                if (comparer.Compare(array[midPoint], value) > 0)
                    higherBound = midPoint - 1;
                else if (comparer.Compare(array[midPoint], value) < 0)
                    lowerBound = midPoint + 1;
                else
                    return midPoint;
            }

            return -1;
        }

    }
}
