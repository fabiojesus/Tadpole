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

        #region Properties
        private ISingleLinkNode<T> FirstNode { get; set; }

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
        #endregion

        #region Add 
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
            if (FirstNode == null)
            {
                FirstNode = node;
                return;
            }
            node.Next = next;
            if (next == FirstNode) FirstNode = node;
            else if (next == null) LastNode.Next = node;
        }
        #endregion

        #region Remove 

        public T RemoveFirst()
        {
            return Remove(FirstNode);
        }

        public T RemoveLast()
        {
            return Remove(LastNode);
        }

        private T Remove(ISingleLinkNode<T> node)
        {
            if(node == FirstNode)
            {
                var second = FirstNode.Next;
                FirstNode = second;
                return node.Content;
            }
            else if(node == LastNode)
            {
                var current = FirstNode;
                while(current != LastNode)
                {
                    current = current.Next;
                }
                var tempData = current.Content;
                current = null;
                return tempData;
            }
            return default;
        }

        #endregion

    }
}
