using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.DataStructures
{
    class SNode<T>
    {
        public T data;
        public SNode<T> next;
        public SNode(T _data)
        {
            data = _data;
            next = null;
        }
    }

    class SLinkedList<T>
    {
        public SNode<T> head;
    }

    class SinglyLinkedList<T>
    {
        private SLinkedList<T> sLinkedList;

        public SinglyLinkedList()
        {
            sLinkedList = new SLinkedList<T>();
        }

        public void Insert(T newData)
        {
            SNode<T> newNode = new SNode<T>(newData);

            if (sLinkedList.head == null)
                sLinkedList.head = newNode;
            else
            {
                SNode<T> last = FindLast(sLinkedList);
                last.next = newNode;
            }
        }

        private SNode<T> FindLast(SLinkedList<T> sLinkedList)
        {
            SNode<T> find = sLinkedList.head;
            while (find.next != null)
            {
                find = find.next;
            }
            return find;
        }
        /// <summary>
        /// Console output
        /// </summary>
        public void DisplayAll()
        {
            if (sLinkedList.head == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                SNode<T> current = sLinkedList.head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }

        /// <summary>
        /// Return all data as a List
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            List<T> list = new List<T>();
            
            if (sLinkedList.head != null)
            {
                SNode<T> current = sLinkedList.head;
                while (current != null)
                {
                    list.Add(current.data);
                    current = current.next;
                }
            }

            return list;
        }

        public void ClearAll()
        {
            if (sLinkedList.head != null)
            {   
                while (sLinkedList.head != null)
                {
                    SNode<T> firstNode = sLinkedList.head;
                    sLinkedList.head = firstNode.next;
                    firstNode = null;  
                }
            }
        }

        public void RemoveFirst()
        {
            if (sLinkedList.head != null)
            {
                SNode<T> firstNode = sLinkedList.head;
                sLinkedList.head = firstNode.next;
                firstNode = null;
            }
        }

        public void RemoveLast()
        {
            if (sLinkedList.head != null)
            {
                SNode<T> lastNode = FindLast(sLinkedList);
                lastNode = null;
            }
        }
    }
}
