using Structures.Interfaces.Simple;
using Structures.Interfaces.SpecialLists;
using Structures.Nodes;

namespace Structures.SpecialLists
{
    public class Stack<T> : IStack<T>
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

        //Stacks are really simple. The only
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

        //Stacks are really simple. Since we only add at the tail, the only concern is the empty list. Otherwise, the element is added at the end of the list
        public void Push(T item)
        {
            var node = new SingleLinkNode<T>(item);
            if (IsEmpty) FirstNode = node;
            else LastNode.Next = node;
        }


        //We want to know the last value without actually removing the node
        public T Peek()
        {
            if (FirstNode == null) return default;
            else return LastNode.Content;
        }
    }
}
