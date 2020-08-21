using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTree
{
    class Node
    {
        public int Weight;
        public Node LeftChild;
        public Node RightChild;

    }
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.Weight = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.Weight)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public List<int> GetOrderedWeights(Node Root)
        {
            List<int> res = new List<int>();
            if (Root != null)
            {
                GetOrderedWeights(Root.LeftChild);
                res.Add(Root.Weight);
                Console.Write(Root.Weight + ",");
                GetOrderedWeights(Root.RightChild);
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree BST = new Tree();
            BST.Insert(30);
            BST.Insert(35);
            BST.Insert(57);
            BST.Insert(15);
            BST.Insert(63);
            BST.Insert(49);
            BST.Insert(89);
            BST.Insert(77);
            BST.Insert(67);
            BST.Insert(98);
            BST.Insert(91);
            BST.GetOrderedWeights(BST.ReturnRoot());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
