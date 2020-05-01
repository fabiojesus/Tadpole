using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces
{
    public interface IDualSingleLinkNode<T> : INode<T>
    {
        IDualSingleLinkNode<T> Previous { get; set; }
        IDualSingleLinkNode<T> Next { get; set; }
    }
}
