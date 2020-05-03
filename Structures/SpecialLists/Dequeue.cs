using Structures.Interfaces.Simple;
using Structures.Interfaces.SpecialLists;
using Structures.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.SpecialLists
{
    public class Dequeue<T> : IDequeue<T>
    {
        private ISingleLinkNode<T> FirstNode { get; set; }

        public bool IsEmpty => FirstNode == null;


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


        /// <summary>
        /// Basically a Peek for a Queue
        /// </summary>
        /// <returns></returns>
        public T PeekFirst()
        {
            if (FirstNode == null) return default;
            else return FirstNode.Content;
        }

        /// <summary>
        /// Basically a Peek for a Stack
        /// </summary>
        /// <returns></returns>
        public T PeekLast()
        {
            if (IsEmpty) return default;
            else return LastNode.Content;
        }

        //Removes the last item. Basically a stack's pop
        public T Pop()
        {
            if (IsEmpty) return default;
            var value = LastNode.Content;

            if (FirstNode.Next == null)
            {
                FirstNode = null;
                return value;
            }
            //Fetch the node before the last one.
            var beforeLast = NodeBefore(LastNode);
            //Fetch the value from the last node
            //Set the last node as null;
            beforeLast.Next = null;
            //return the value
            return value;
        }

        //Basically the push from a stack
        public void Push(T item)
        {
            var node = new SingleLinkNode<T>(item);
            if (IsEmpty) FirstNode = node;
            else LastNode.Next = node;
        }

        //This is the only one that changes. It needs to insert the new node at the beginning of the list
        public void Shift(T item)
        {
            var node = new SingleLinkNode<T>(item);
            node.Next = FirstNode;
            FirstNode = node;
        }

        //basically a dequeue from a queue
        public T Unshift()
        {
            if (IsEmpty) return default;
            var value = FirstNode.Content;
            FirstNode = FirstNode.Next;
            return value;
        }
    }
}
