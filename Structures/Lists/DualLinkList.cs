using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;
using Structures.Nodes;

namespace Structures.Lists
{
    public class DualLinkList<T>
    {
        #region Property
        private IDualLinkNode<T> FirstNode { get; set; }
        private IDualLinkNode<T> LastNode
        {
            get
            {
                //If the list is empty
                if (FirstNode == null) return null;
                var node = FirstNode;
                //searches for the last node, being this the one with a null next.
                while (node.Next != null)
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
        private bool Exists(IDualLinkNode<T> nodeToCheck)
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
        private IDualLinkNode<T> NodeBefore(IDualLinkNode<T> node)
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

        private void Add(T value, IDualLinkNode<T> previous)
        {
            //Let's create the node first
            var node = new DualLinkNode<T>(value);
            //Now, we check if the list is empty, and if it is, then we add the node in the first place
            if (FirstNode == null)
            {
                FirstNode = node;
                //All done
                return;
            }

            //Let's check if this element goes to the head node (special case)
            if (previous == null)
            {
                FirstNode.Previous = node;
                node.Next = FirstNode;
                FirstNode = node;
                return;
            }

            //Now here's the tricky part. Let's say that we are adding n between a and b
            //We need to set n's previous as "a" and n's next as "b"

            var a = previous;
            var b = previous.Next;
            var n = node;

            n.Previous = a;
            n.Next = b;

            //Then, a's next has to be n

            a.Next = n;

            //And last but not least b's previous has to be n as long as b is not null

            if(b != null)b.Previous = n;

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
        private T Remove(IDualLinkNode<T> node)
        {
            //The list is empty
            if (FirstNode == null) return default;

            //The node does not exist
            if (!Exists(node)) return default;

            //Fetch the node's content
            var value = node.Content;

            //if the list has only one element special case
            if (FirstNode.Next == null)
            {
                FirstNode = null;
                return value;
            }

            //Let's get to the trick part once more. We want to remove n that is between a and b

            //First we get a
            var a = NodeBefore(node);

            
            //Then we get b

            var b = node.Next;

            //Check if the element that is being removed is the first one and if it is replace it with b
            if (node == FirstNode) FirstNode = b;

            //Now we have to connect a and b in a way that a's next is b and b's previous is a

            //Check if b is null
            if (a != null) a.Next = b;

            //Check if b is null
            if (b != null)
            {
                b.Previous = a;
            }
            //Done!
            return value;
        }
        #endregion
    }
}