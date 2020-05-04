using Structures.Interfaces.Simple;
using Structures.Nodes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Structures.SpecialLists
{
    public class BinaryTree
    {
        private BinaryTreeNode Root { get; set; }

        public BinaryTree(int root)
        {
            Root = new BinaryTreeNode(root);
        }

        #region Add
        //sem recursivo
        public void Add(int value)
        {
            //Íf the tree is empty
            if (Root == null)
            {
                Root = new BinaryTreeNode(value);
                return;
            }
            var currentNode = Root;
            var node = new BinaryTreeNode(value);
            bool added = false;
            do
            {
                if(value < currentNode.Content)
                {
                    //go to the left
                    if(currentNode.Left == null)
                    {
                        currentNode.Left = node;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.Left;
                    }
                }
                else
                {
                    if(currentNode.Content <= value)
                    {
                        if(currentNode.Right == null)
                        {
                            currentNode.Right = node;
                            added = true;
                        }
                        else
                        {
                            currentNode = currentNode.Right;
                        }
                    }
                }
            } while (!added);

        }
        #endregion

        #region Add Recursivo
        public void AddRecursive(int value)
        {
            //if the tree is empty
            if (Root == null) Root = new BinaryTreeNode(value);
            else Add(Root, value);
        }
        
        //suporte a recursivo
        private void Add(BinaryTreeNode currentNode, int value)
        {
            var node = new BinaryTreeNode(value);
            if(value < currentNode.Content)
            {
                if (currentNode.Left == null) currentNode.Left = node;
                else Add(currentNode.Left, value);
            }
            else
            {
                if (currentNode.Right == null) currentNode.Right = node;
                else Add(currentNode.Right, value);
            }
           
        }
        #endregion

        #region Smallest
        public double Smallest(BinaryTreeNode currentNode = null)
        {
            if (Root == null) return double.NaN;
            if (currentNode == null) return Smallest(Root);
            if (currentNode.Left == null) return currentNode.Content;
            else return Smallest(currentNode.Left);
        }
        #endregion

        #region Largest
        public double Highest(BinaryTreeNode currentNode = null)
        {
            if (Root == null) return double.NaN;
            if (currentNode == null) return Highest(Root);
            if (currentNode.Right == null) return currentNode.Content;
            else return Highest(currentNode.Right);
        }
        #endregion

        #region in order
        public void InOrderTraversal(BinaryTreeNode currentNode = null)
        {
            //When we start the search
            if (currentNode == null)
            {
                InOrderTraversal(Root);
                return;
            }
            //First we go left
            if (currentNode.Left != null)
                InOrderTraversal(currentNode.Left);

            //Then we print the current content
            Console.Write(currentNode.Content + " ");

            //Then we go right
            if (currentNode.Right != null)
                InOrderTraversal(currentNode.Right);
        }

        #endregion

        #region preorder
        public void PreOrderTraversal(BinaryTreeNode currentNode = null)
        {
            //When we start the search
            if (currentNode == null)
            {
                PreOrderTraversal(Root);
                return;
            }
            //First we print the current content
            Console.Write(currentNode.Content + " ");

            //Then we go left
            if (currentNode.Left != null)
                PreOrderTraversal(currentNode.Left);

            //Then we go right
            if (currentNode.Right != null)
                PreOrderTraversal(currentNode.Right);
        }
        #endregion

        #region postorder
        public void PostorderTraversal(BinaryTreeNode currentNode = null)
        {
            //When we start the search
            if (currentNode == null)
            {
                PreOrderTraversal(Root);
                return;
            }
            //First we go left
            if (currentNode.Left != null)
                PreOrderTraversal(currentNode.Left);

            //Then we go right
            if (currentNode.Right != null)
                PreOrderTraversal(currentNode.Right);

            //First we print the current content
            Console.Write(currentNode.Content + " ");
        }
        #endregion

    }
}
