using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.Algorithms
{
    class MergeSort<T>
    {

        public T[] Sort(T[] list)
        {
            if (list.Length <= 1)
                return list;

            T[] left;
            T[] right;
            int middle = list.Length / 2;

            left = new T[middle];

            if (list.Length % 2 == 0)
                right = new T[middle];
            else
                right = new T[middle + 1];

            for(int i = 0; i < middle; i++)
            {
                    left[i] = list[i]; 
            }

            int rightIndex = 0;
            for(int i = middle; i < list.Length; i++)
            {
                right[rightIndex] = list[i];
                rightIndex++;
            }

            left = Sort(left);
            right = Sort(right);
            T[] result = Merge(left, right);
            return result;
        }

        public T[] Merge(T[] left, T[] right)
        {
            int length = left.Length + right.Length;
            int indexLeft = 0;
            int indexRight = 0;

            T[] result = new T[length];

            var comparer = Comparer<T>.Default;

            for (int i = 0; i < length; i++)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (comparer.Compare(left[indexLeft], right[indexRight]) <= 0)
                    {
                        result[i] = left[indexLeft];
                        indexLeft++;
                    }
                    else
                    {
                        result[i] = right[indexRight];
                        indexRight++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[i] = left[indexLeft];
                    indexLeft++;
                }
                else if (indexRight < right.Length)
                {
                    result[i] = right[indexRight];
                    indexRight++;
                }
            }

            return result;
        }
    }
}
