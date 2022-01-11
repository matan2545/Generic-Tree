using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsWork
{
    class GenericTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public Type GetGenericType()
        {
            return typeof(T);
        }

        public bool Insert(T value)
        {
            Node<T> lastNode = null, currentNode = this.Root;

            while (currentNode != null) {
                lastNode = currentNode;
                if (value.CompareTo(currentNode.Data) < Constants.EMPTY) {
                    currentNode = currentNode.LeftNode;
                }
                else if (value.CompareTo(currentNode.Data) > Constants.EMPTY) {
                    currentNode = currentNode.RightNode;
                }
                else {
                    //Exist same value
                    return false;
                }
            }

            Node<T> newNode = new Node<T>();
            newNode.Data = value;

            if (this.Root == null) { // empty tree
                this.Root = newNode;
            }
            else {
                if (value.CompareTo(lastNode.Data) < Constants.EMPTY) {
                    lastNode.LeftNode = newNode;
                }
                else {
                    lastNode.RightNode = newNode;
                }
            }
            return true;
        }

        public void Remove(T value)
        {
            if (Find(value, Root) == null) {
                throw new ValueNotFoundException(Constants.NOT_FOUND_ERROR);
            }
            this.Root = Remove(this.Root, value);
        }

        private Node<T> Find(T value, Node<T> parent)
        {
            if (parent != null) {
                if (value.Equals(parent.Data)) return parent;
                if (value.CompareTo(parent.Data) < Constants.EMPTY)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
            return null;
        }

        private Node<T> Remove(Node<T> parent, T key)
        {
            if (parent == null) {
                return parent;
            }

            if (key.CompareTo(parent.Data) < Constants.EMPTY) {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key.CompareTo(parent.Data) > Constants.EMPTY) {
                parent.RightNode = Remove(parent.RightNode, key);
            }

            else {
                if (parent.LeftNode == null) {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null) {
                    return parent.LeftNode;
                }
                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }
            return parent;
        }

        private T MinValue(Node<T> node)
        {
            T minValue = node.Data;

            while (node.LeftNode != null) {
                minValue = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minValue;
        }
    }
}
