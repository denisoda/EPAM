using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree <T>
    {
        private static IComparer<T> Comparer;

        BinarySearchTree(IComparer<T> comparer)
        {
            Comparer = comparer;
        }

        private class Node<T>
        {
            public T Value;
            public Node<T> Left;
            public Node<T> Right;
        }

        class Tree<T>
        {

            public Node<T> Insert(Node<T> root, T v)
            {
                if (root == null)
                {
                    root = new Node<T> {Value = v};
                }
                else if (BinarySearchTree<T>.Comparer.Compare(v, root.Value) < 0)
                {
                    root.Left = Insert(root.Left, v);
                }
                else
                {
                    root.Right = Insert(root.Right, v);
                }

                return root;
            }

            public void Traverse(Node<T> root)
            {
                if (root == null)
                {
                    return;
                }

                Traverse(root.Left);
                Traverse(root.Right);
            }
        }
    }
}
