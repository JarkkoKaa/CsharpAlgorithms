using System;
using CsharpAlgorithms.DataStructures;

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

        static void Main(string[] args)
        {
            LinkedList();
        }
    }
}
