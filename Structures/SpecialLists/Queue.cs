using Structures.Interfaces.Simple;
using Structures.Interfaces.SpecialLists;
using Structures.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.SpecialLists
{
    public class Queue<T> : IQueue<T>
    {

        private ISingleLinkNode<T> FirstNode { get; set; }

        #region LastNode

        private ISingleLinkNode<T> LastNode
        {
            get
            {
                if (IsEmpty) return null;
                if (FirstNode.Next == null) return FirstNode;
                var node = FirstNode;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                return node;
            }
        }
        #endregion

        #region NodeBefore
        /// <summary>
        /// Fetches the node before another one (e.g. the node before the fourth is the third)
        /// </summary>
        /// <param name="node">the node that has a previous</param>
        /// <returns></returns>
        private ISingleLinkNode<T> NodeBefore(ISingleLinkNode<T> node)
        {
            if (FirstNode == null || node == FirstNode) return null;
            var currentNode = FirstNode;
            while (currentNode.Next != node)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }
        #endregion

        public bool IsEmpty => FirstNode == null;

        //Dequeing is the same as removing the firt element
        public T Dequeue()
        {
            if (IsEmpty) return default;
            var value = FirstNode.Content;
            FirstNode = FirstNode.Next;
            return value;
        }

        //Queues have their value set at the end of the list which is basically a push
        public void Enqueue(T item)
        {
            var node = new SingleLinkNode<T>(item);
            if (IsEmpty) FirstNode = node;
            else LastNode.Next = node;
        }

        //We want to peek the first value
        public T Peek()
        {
            if (FirstNode == null) return default;
            return FirstNode.Content;
        }
    }
}
