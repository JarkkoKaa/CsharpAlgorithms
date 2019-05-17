using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.DataStructures
{
    class Node<T>
    {
        public T value;
        public int height = 0;
        public Node<T> childLeft;
        public Node<T> childRight;
        public Node(T _value)
        {
            value = _value;
        }
    }

    class AVLTree<T>
    {
        public Node<T> root;

        // height of the tree
        int GetHeight(Node<T> n)
        {
            if (n == null)
                return -1;

            return n.height;
        }

        int MaxHeight(int left, int right)
        {
            return (left > right) ? left : right;
        }
        Node<T> RotateRight(Node<T> currentNode)
        {
            Node<T> n1 = currentNode.childLeft;
            Node<T> n2 = n1.childRight;

            // perform rotation
            n1.childRight = currentNode;
            currentNode.childLeft = n2;

            currentNode.height = MaxHeight(GetHeight(currentNode.childLeft), GetHeight(currentNode.childRight)) + 1;
            n1.height = MaxHeight(GetHeight(n1.childLeft), GetHeight(n1.childRight)) + 1;

            return n1;
        }

        Node<T> RotateLeft(Node<T> currentNode)
        {
            Node<T> n1 = currentNode.childRight;
            Node<T> n2 = n1.childLeft;

            n1.childLeft = currentNode;
            currentNode.childRight = n2;

            currentNode.height = MaxHeight(GetHeight(currentNode.childLeft), GetHeight(currentNode.childRight) + 1);
            currentNode.height = MaxHeight(GetHeight(n1.childLeft), GetHeight(n1.childRight) + 1);

            return n1;
        }

        int GetBalanceFactor(Node<T> n)
        {
            if (n == null)
                return -1;

            return GetHeight(n.childLeft) - GetHeight(n.childRight);
        }

        public Node<T> Insert(Node<T> newNode, T _value)
        {
            if (newNode == null)
                return (new Node<T>(_value));

            var comparer = Comparer<T>.Default;

            if (comparer.Compare(_value, newNode.value) < 0)
                newNode.childLeft = Insert(newNode.childLeft, _value);
            else if (comparer.Compare(_value, newNode.value) > 0)
                newNode.childRight = Insert(newNode.childRight, _value);
            else
                return newNode;

            newNode.height = 1 + MaxHeight(GetHeight(newNode.childLeft), GetHeight(newNode.childRight));

            int balance = GetBalanceFactor(newNode);
            // left left case
            if (balance > 1 && comparer.Compare(_value, newNode.childLeft.value) < 0)
                return RotateRight(newNode);
            // right right case
            if (balance < -1 && comparer.Compare(_value, newNode.childRight.value) > 0)
                return RotateLeft(newNode);
            // left right case
            if (balance > 1 && comparer.Compare(_value, newNode.childLeft.value) > 0)
            {
                newNode.childLeft = RotateLeft(newNode.childLeft);
                return RotateRight(newNode);
            }
            // right left case
            if (balance < -1 && comparer.Compare(_value, newNode.childRight.value) < 0)
            {
                newNode.childRight = RotateRight(newNode.childRight);
                return RotateLeft(newNode);
            }

            return newNode;
        }
    }
}