using Structures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Nodes
{
    public class SingleLinkNode<T> : ISingleLinkNode<T>
    {
        public T Content { get; set; }

        public SingleLinkNode<T> Next { get; set; }
    }
}
