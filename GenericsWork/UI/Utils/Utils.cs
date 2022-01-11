using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsWork
{
    public class Utils<T>
    {
        public static void PrintPreOrder(Node<T> parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + Constants.ARROW);
                PrintPreOrder(parent.LeftNode);
                PrintPreOrder(parent.RightNode);
            }
        }

        public static void PrintInOrder(Node<T> parent)
        {
            if (parent != null)
            {
                PrintInOrder(parent.LeftNode);
                Console.Write(parent.Data + Constants.ARROW);
                PrintInOrder(parent.RightNode);
            }
        }

        public static void PrintPostOrder(Node<T> parent)
        {
            if (parent != null)
            {
                PrintPostOrder(parent.LeftNode);
                PrintPostOrder(parent.RightNode);
                Console.Write(parent.Data + Constants.ARROW);
            }
        }
    }
}
