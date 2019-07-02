using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.DataStructures
{
    class DNode<T>
    {
        public T data;
        public DNode<T> prev;
        public DNode<T> next;
        public DNode(T _data)
        {
            data = _data;
            prev = null;
            next = null;
        }
    }
    // first node
    class DLinkedList<T>
    {
        public DNode<T> head;
    }

    class DoublyLinkedList<T>
    {
        private DLinkedList<T> dLinkedList;

        public DoublyLinkedList()
        {
            dLinkedList = new DLinkedList<T>();
        }

        // insert first node
        public void InsertFirst(T newData)
        {
            DNode<T> firstNode = new DNode<T>(newData)
            {
                next = dLinkedList.head,
                prev = null
            };

            if (dLinkedList.head != null)
            {
                dLinkedList.head.prev = firstNode;
            }
            dLinkedList.head = firstNode;
        }

        // insert last node
        public void InsertLast(T newData)
        {
            DNode<T> newNode = new DNode<T>(newData);

            if (dLinkedList.head == null)
            {
                newNode.prev = null;
                dLinkedList.head = newNode;
            }
            else
            {
                DNode<T> lastNode = FindLastNode(dLinkedList);
                lastNode.next = newNode;
                newNode.prev = lastNode;
            }
        }

        /// <summary>
        /// Return data from index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T FindIndex(int index)
        {
            DNode<T> find = dLinkedList.head;
            if (find != null)
            {
                int count = 0;
                while (find.next != null)
                {
                    if (index == count)
                        break;
                    find = find.next;
                    count++;
                }
            }
            
            return find.data;
        }

        private DNode<T> FindLastNode(DLinkedList<T> dLinkedList)
        {
            DNode<T> find = dLinkedList.head;
            while(find.next != null)
            {
                find = find.next;
            }
            return find;
        }

        public void DisplayAll()
        {
            if (dLinkedList.head == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                DNode<T> current = dLinkedList.head;
                while(current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }

        public void RemoveFirst()
        {
            if (dLinkedList.head != null)
            {
                DNode<T> newFirst = dLinkedList.head;
                newFirst = newFirst.next;
                newFirst.prev = null;
                dLinkedList.head = newFirst;
            }
        }

        public void RemoveLast()
        {
            if (dLinkedList.head != null)
            {
                DNode<T> newLastNode = FindLastNode(dLinkedList);
                newLastNode = newLastNode.prev;
                newLastNode.next = null;
            }
        }

        public void ClearAll()
        {
            if (dLinkedList.head != null)
            {
                while (dLinkedList.head != null)
                {
                    DNode<T> current = dLinkedList.head;
                    dLinkedList.head = current.next;
                    current = null;
                }
            }
        }
    }
}
