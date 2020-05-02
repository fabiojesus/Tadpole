using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;
using Structures.Nodes;
using System;

namespace Structures.Lists
{

    /// <summary>
    /// List with a uni-directional link
    /// </summary>
    /// <typeparam name="T">the generic type</typeparam>
    public class SingleLinkList<T> : ISingleLinkedList<T>
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
                //searches for the last node, being this the one with a null next.
                while(node.Next != null)
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
            while (node != null)
            {
                if (node.Content.Equals(value)) return true;
                node = node.Next;
            }
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
            while (node != null)
            {
                if (node == nodeToCheck) return true;
                node = node.Next;
            }
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
            if (FirstNode == null || node == FirstNode) return null;
            var currentNode = FirstNode;
            while(currentNode.Next != node)
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
            if(FirstNode == null)
            {
                FirstNode = node;
                //All done
                return;
            }

            //Let's check if this element goes to the head node (special case)
            if(previous == null)
            {
                node.Next = FirstNode;
                FirstNode = node;
                return;
            }
            
            //Next, we set "previous"'s Next as the node's next
            node.Next = previous.Next;

            //Now, all we need is to set the "previous"'s Next as the node
            previous.Next = node;

            //Presto finito!
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
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private T Remove(ISingleLinkNode<T> node)
        {
            //The list is empty
            if (FirstNode == null) return default;
            
            //The node does not exist
            if (!Exists(node)) return default;

            //Fetch the node's content
            var value = node.Content;

            //if the list has only one element special case
            if(FirstNode.Next == null)
            {
                FirstNode = null;
                return value;
            }

            //First we get the previous node to the one that's being removed
            var previous = NodeBefore(node);

            if (previous != null)
                previous.Next = node.Next;
            else
                FirstNode = FirstNode.Next;
            return value;
        }
        #endregion
    }
}
