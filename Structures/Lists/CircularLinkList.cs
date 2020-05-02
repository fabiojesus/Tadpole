using Structures.Interfaces.Simple;
using Structures.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Lists
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkList<T>
    {
        #region Property
        private ISingleLinkNode<T> FirstNode { get; set; }
        private ISingleLinkNode<T> LastNode
        {
            get
            {
                //If the list is empty
                if (FirstNode == null) return null;
                var node = FirstNode;
                //searches for the last node, being this the one with the first node next.
                while (node.Next != FirstNode)
                {
                    node = node.Next;
                }
                //returns the last node.
                return node;
            }
        }

        #endregion

        #region Exists
        /// <summary>
        /// Checks if the value exists
        /// </summary>
        /// <param name="value">the value to check</param>
        /// <returns>wether the value exists or not</returns>
        public bool Exists(T value)
        {
            if (FirstNode == null) return false;
            var node = FirstNode;
            do
            {
                if (node.Content.Equals(value)) return true;
                node = node.Next;
            } while (node != FirstNode);
            return false;
        }

        /// <summary>
        /// Checks if the node exists
        /// </summary>
        /// <param name="node">the node to check</param>
        /// <returns>wether the node exists or not</returns>
        private bool Exists(ISingleLinkNode<T> nodeToCheck)
        {
            if (FirstNode == null) return false;
            var node = FirstNode;
            do
            {
                if (node == nodeToCheck) return true;
                node = node.Next;
            } while (node != FirstNode) ;
            return false;
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
            if (FirstNode == null) return null;
            if (node == FirstNode) return LastNode;
            var currentNode = FirstNode;
            while (currentNode.Next != node)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }
        #endregion


        #region Add
        public void AddFirst(T value)
        {
            //There is no previous
            Add(value, null);
        }

        //The previous is the last element
        public void AddLast(T value)
        {
            Add(value, LastNode);
        }

        private void Add(T value, ISingleLinkNode<T> previous)
        {
            //Let's create the node first
            var node = new SingleLinkNode<T>(value);
            //Now, we check if the list is empty, and if it is, then we add the node in the first place
            if (FirstNode == null)
            {
                FirstNode = node;
                FirstNode.Next = node;
                //All done
                return;
            }
            if(previous == LastNode || previous == null)
            {
                //wether the previous is null or last, it's always going to set the first node
                LastNode.Next = node;
                node.Next = FirstNode;
                if(previous == null)FirstNode = node;
                return;
            }
            var b = previous.Next;
            previous.Next = node;
            node.Next = b;

        }
        #endregion

        #region Remove
        /// <summary>
        /// Remove the first element
        /// </summary>
        /// <returns>the value for the first element</returns>
        public T RemoveFirst()
        {
            return Remove(FirstNode);
        }

        /// <summary>
        /// Remove the last element
        /// </summary>
        /// <returns>the value for the last element</returns>
        public T RemoveLast()
        {
            return Remove(LastNode);
        }

        /// <summary>
        /// Removes a node from the circular list
        /// </summary>
        /// <param name="node">the node to be removed</param>
        /// <returns></returns>
        private T Remove(ISingleLinkNode<T> node)
        {
            //The list is empty
            if (FirstNode == null) return default;

            //The node does not exist
            if (!Exists(node)) return default;

            //Fetch the node's content
            var value = node.Content;

            var previous = NodeBefore(node);

            //if the list is going to be empty
            if(FirstNode.Next == FirstNode)
            {
                FirstNode = null;
                return value;
            }

            //Updates the firstNode to the next node
            if (node == FirstNode) FirstNode = node.Next;

            previous.Next = node.Next;

            return value;
        }
        #endregion
    }
}
