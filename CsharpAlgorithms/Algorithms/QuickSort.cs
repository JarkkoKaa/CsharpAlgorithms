using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.Algorithms
{
    class QuickSort<T>
    {
        public T[] Sort(T[] list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                if (pivot > 1)
                    Sort(list, left, pivot - 1);
                if (pivot + 1 < right)
                    Sort(list, pivot + 1, right);
            }

            return list;
        }

        private int Partition(T[] list, int left, int right)
        {
            T pivot = list[left];
            Comparer<T> comparer = Comparer<T>.Default;
            while(true)
            {
                while(comparer.Compare(list[left], pivot) < 0)
                {
                    left++;
                }
                while(comparer.Compare(list[right], pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (comparer.Compare(list[left], list[right]) == 0)
                        return right;

                    T tmp = list[left];
                    list[left] = list[right];
                    list[right] = tmp;
                }
                else
                    return right;
            }
        }
    }
}
