using Structures.Interfaces.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Nodes
{
    public class BinaryTreeNode
    {
        public int Content { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode(int value)
        {
            Content = value;
        }
    }
}
