using System;
using CsharpAlgorithms.DataStructures;

namespace CsharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.InsertFirst("Tuesday");
            list.InsertFirst("Monday");
            list.InsertLast("wednesday");
        }
    }
}
