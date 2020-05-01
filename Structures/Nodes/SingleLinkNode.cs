using Structures.Interfaces;
using Structures.Interfaces.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Nodes
{
    public class SingleLinkNode<T> : ISingleLinkNode<T>
    {
        public ISingleLinkNode<T> Next { get; set; }
        public T Content { get; set; }

        public SingleLinkNode(T value)
        {
            Content = value;
        }
    }




}
