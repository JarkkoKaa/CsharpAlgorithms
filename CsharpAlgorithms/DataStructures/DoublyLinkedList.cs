using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.DataStructures
{
    /* Goals:
     * Data is string
     * Add and delete first node
     * Add and delete last node
     * */
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
            DNode<T> firstNode = new DNode<T>(newData);
            firstNode.next = dLinkedList.head;
            firstNode.prev = null;

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

        public DNode<T> FindLastNode(DLinkedList<T> dLinkedList)
        {
            DNode<T> find = dLinkedList.head;
            while(find.next != null)
            {
                find = find.next;
            }
            return find;
        }
    }
}
