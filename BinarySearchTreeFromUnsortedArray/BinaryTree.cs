using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeFromUnsortedArray
{
    public static class BinaryTree
    {
        public static Node CreateSubTree(int[] items)
        {
            if (items == null || items.Length ==0)
                throw new ArgumentNullException();

            var mid = items.Length / 2;

            if (mid == 0)
                return new Node { Data = items[0] };


            var node = new Node { Data = items[mid] };

            var leftSubtree = items.Take(mid).ToArray();
            var rightSubtree = items.Skip(mid + 1).Take(items.Length - mid).ToArray();

            if (HasLeftSubtreeItem(items))
                node.Left = CreateSubTree(leftSubtree);

            if (HasRightSubtreeItem(items))
                node.Right = CreateSubTree(rightSubtree);

            return node;
        }

        public static void PreOrderTraversal(Node node)
        {
            Console.WriteLine(node.Data);
            if(node.Left != null)
                PreOrderTraversal(node.Left);
            
            if(node.Right != null)
                PreOrderTraversal(node.Right);  

        }

        public static void PostOrderTraversal(Node node)
        {

            if (node.Left != null)
                PostOrderTraversal(node.Left);

            if (node.Right != null)
                PostOrderTraversal(node.Right);

            Console.WriteLine(node.Data);   

        }

        public static void InOrderTraversal(Node node)
        {
            if(node.Left != null)
                InOrderTraversal(node.Left);

            Console.WriteLine(node.Data);

            if(node.Right != null)
                InOrderTraversal(node.Right);   
        }

        public static void AddNodeToTheEnd(int value)
        {
            
        }

        public static Node FindNode(int value, Node node)
        {
            if (value == node.Data)
                return node;

            if (value > node.Data && node.Right != null)
                return FindNode(value, node.Right);

            if (value < node.Data && node.Left != null)
                return FindNode(value, node.Left);

            return null;

        }

        static bool HasRightSubtreeItem(int[] items)
        {
            return items.Length > 2;
        }

        static bool HasLeftSubtreeItem(int[] items)
        {
            return items.Length > 1;
        }
    }
}
