using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;
using Structures.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Lists
{
    public class DualLinkList<T> : IDualLinkList<T>
    {

        #region Properties
        private IDualLinkNode<T> FirstNode { get; set; }

        private IDualLinkNode<T> LastNode
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


        private IDualLinkNode<T> _current;
        public T Current
        {
            get
            {
                if (_current == null) return default;
                return _current.Content;
            }
        }
        #endregion

        #region Add 
        public void AddFirst(T value)
        {
            var node = new DualLinkedNode<T>(value);
            Add(node, FirstNode);
        }

        public void AddLast(T value)
        {
            var node = new DualLinkedNode<T>(value);
            Add(node, null);
        }

        private void Add(IDualLinkNode<T> node, IDualLinkNode<T> next)
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

        private T Remove(IDualLinkNode<T> node)
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

        #region Iteration 
        public void Next()
        {
            if(_current != null)
            {
                if(_current.Next != null)
                {
                    _current = _current.Next;
                }
            }
        }

        public void Previous()
        {
            if (_current != null)
            {
                if (_current.Previous != null)
                {
                    _current = _current.Previous;
                }
            }
        }

        public void Reset()
        {
            _current = FirstNode;
        }

        #endregion

    }
}
