using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.DataStructures
{
    class Node
    {
        public int value;
        public int height = 0;
        public Node childLeft;
        public Node childRight;
        public Node(int _value)
        {
            value = _value;
        }
    }

    class AVLTree
    {
        Node root;

        // height of the tree
        int GetHeight(Node n)
        {
            if (n == null)
                return 0;

            return n.height;
        }

        int MaxHeight(int left, int right)
        {
            return (left > right) ? left : right;
        }
        Node RotateRight(Node currentNode)
        {
            Node n1 = currentNode.childLeft;
            Node n2 = n1.childRight;

            // perform rotation
            n1.childRight = currentNode;
            currentNode.childLeft = n2;

            currentNode.height = MaxHeight(GetHeight(currentNode.childLeft), GetHeight(currentNode.childRight)) + 1;
            n1.height = MaxHeight(GetHeight(n1.childLeft), GetHeight(n1.childRight)) + 1;

            return n1;
        }

        Node RotateLeft()
        {

        }
    }
}
