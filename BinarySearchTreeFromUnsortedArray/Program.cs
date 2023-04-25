// See https://aka.ms/new-console-template for more information
using BinarySearchTreeFromUnsortedArray;

Console.WriteLine("Hello, World!");



var unsortedArr = new int[] {7,5,6,4,1,2,3, 8, 10, 9, 12, 13, 11, 10, 15, 14};
var sortedArr = unsortedArr.OrderBy(item => item).ToArray();

var tree = BinaryTree.CreateSubTree(sortedArr);

Console.WriteLine("========= Preorder ==================");
BinaryTree.PreOrderTraversal(tree);

Console.WriteLine("========= Postorder ==================");
BinaryTree.PostOrderTraversal(tree);

Console.WriteLine("========= Inorder ==================");
BinaryTree.InOrderTraversal(tree);

Console.WriteLine("Enter Value to find:");
var value = Console.ReadLine();
var node = BinaryTree.FindNode(int.Parse(value), tree);

var t = "";



public class Node 
{
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}