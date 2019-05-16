﻿using System;
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

        static void QuickSort(char[] values)
        {
            QuickSort<char> quickSort = new QuickSort<char>();
            var sorted = quickSort.Sort(values, 0, values.Length - 1);
        }

        static void Main(string[] args)
        {
            //int[] values = new int[] { 9, 4, 6, 7, 8, 3, 2, 1, 5 };
            int[] values = new int[] { 'c', 'd', 'b', 'a' };
            int value = 1;
            // LinkedList();
            // BubbleSort(values);
            // MergeSort(values);
            // QuickSort(values);
            AVLTree<int> aVLTree = new AVLTree<int>();
            aVLTree.Insert(value);
        }
    }
}
