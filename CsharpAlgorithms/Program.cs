using System;
using System.Collections.Generic;
using CsharpAlgorithms.DataStructures;
using CsharpAlgorithms.Algorithms;

namespace CsharpAlgorithms
{
    class Program
    {
        static void LinkedList()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.RemoveLast();
            list.InsertFirst("Tuesday");
            list.InsertFirst("Monday");
            list.InsertLast("wednesday");
            list.RemoveLast();
            list.RemoveFirst();
            list.DisplayAll();
        }

        static void BubbleSort()
        {
            int[] numbers = new int[] { 9, 4, 6, 7, 8, 3, 2, 1, 5 };
            BubbleSort<int> bsort = new BubbleSort<int>();
            bsort.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        static void Main(string[] args)
        {
            // LinkedList();
            BubbleSort();
        }
    }
}
