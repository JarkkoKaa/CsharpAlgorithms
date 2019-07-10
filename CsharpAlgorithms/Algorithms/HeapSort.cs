using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.Algorithms
{
    class HeapSort<T>
    {
        private Comparer<T> compare;
        public HeapSort()
        {
            compare = Comparer<T>.Default;
        }

        /// <summary>
        /// Heap sort
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public T[] Sort(T[] array)
        {
            // Build heap
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, array.Length, i);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                T temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }

            return array;
        }

        /// <summary>
        /// Arrange elements
        /// </summary>
        private T[] Heapify(T[] array,int len,int i)
        {
            int largest = i; // init largest as root
            int left = 2 * i + 1; // left child
            int right = left + 1; // right child

            if (left < array.Length && compare.Compare(array[left], array[largest]) < 0)
                largest = left;
            if (right < array.Length && compare.Compare(array[right], array[largest]) < 0)
                largest = right;

            // if largest is not the root
            if (largest != i)
            {
                T temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                Heapify(array, len, largest);
            }

            return array;
        }
    }
}
