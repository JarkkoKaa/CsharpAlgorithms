using System;
using System.Collections.Generic;
using CsharpAlgorithms.DataStructures;
using CsharpAlgorithms.Algorithms;

namespace CsharpAlgorithms
{
    class Program
    {
        static void SLinkedList()
        {
            SinglyLinkedList<string> list = new SinglyLinkedList<string>();
            list.Insert("Monday");
            list.Insert("Tuesday");
            list.DisplayAll();
            var items = list.GetAll();
            // list.ClearAll();
            list.RemoveFirst();
            list.Insert("Wednesday");
            list.Insert("Thursday");
            list.RemoveLast();
        }

        static void DLinkedList()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.RemoveLast();
            list.InsertFirst("Tuesday");
            list.InsertFirst("Monday");
            list.InsertLast("wednesday");
            Console.WriteLine(list.FindIndex(1));
            var items = list.GetAll();
            list.ClearAll();  
            //list.RemoveLast();
            //list.RemoveFirst();
            list.DisplayAll();
        }

        static void BubbleSort(int[] values)
        { 
            BubbleSort<int> bsort = new BubbleSort<int>();
            var sorted = bsort.Sort(values);
        }

        static void MergeSort(int[] values)
        {
            MergeSort<int> mergeSort = new MergeSort<int>();
            var sorted = mergeSort.Sort(values);
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted.GetValue(i));
            }
        }

        static int[] QuickSort(int[] values)
        {
            QuickSort<int> quickSort = new QuickSort<int>();
            return quickSort.Sort(values, 0, values.Length - 1);
        }

        static int BinarySearch(int[] values)
        {
            QuickSort(values);
            BinarySearch<int> searcher = new BinarySearch<int>();
            return searcher.Search(values, 4);
        }

        static int[] HeapSort(int[] values)
        {
            HeapSort<int> hSort = new HeapSort<int>();
            return hSort.Sort(values);

        }
        static void Main(string[] args)
        {
            int[] values = new int[] { 4, 3, 1, 2, 5 };
            // int[] values = new int[] { 'c', 'd', 'b', 'a' };
            // DLinkedList();
            // BubbleSort(values);
            // MergeSort(values);
            // QuickSort(values);
            // SLinkedList();
            //int index = BinarySearch(values);
            var sorted = HeapSort(values);
        }
    }
}
