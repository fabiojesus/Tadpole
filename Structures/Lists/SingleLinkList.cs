using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;
using Structures.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Lists
{
    public class SingleLinkList<T> : ISingleLinkedList<T>
    {
        public ISingleLinkNode<T> FirstNode { get; set; }

        private ISingleLinkNode<T> LastNode
        {
            get
            {
                if (FirstNode == null) return null;
                var current = FirstNode;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                return current;
            }
        }

        public void AddFirst(T value)
        {
            var node = new SingleLinkNode<T>(value);
            Add(node, FirstNode);
        }

        public void AddLast(T value)
        {
            var node = new SingleLinkNode<T>(value);
            Add(node, null);
        }

        private void Add(ISingleLinkNode<T> node, ISingleLinkNode<T> next)
        {
            if (FirstNode == null) FirstNode = node;
            node.Next = next;
            if (next == FirstNode) FirstNode = node;
            else if (next == null) LastNode.Next = node;
        }


    }
}
