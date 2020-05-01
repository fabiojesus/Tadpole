using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces
{
    public interface ISingleLinkNode<T> : INode<T>
    {
        ISingleLinkNode<T> Next { get; set; }
    }
}
