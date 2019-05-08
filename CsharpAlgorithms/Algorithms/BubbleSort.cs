using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.Algorithms
{
    public class BubbleSort<T>
    {
        public T[] Sort(T[] array)
        {
            var comparer = Comparer<T>.Default;

            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - i -1 ; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        T tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }
    }
}
