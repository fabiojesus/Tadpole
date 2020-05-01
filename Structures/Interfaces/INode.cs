using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces
{
    public interface INode<T>
    {
        T Content { get; set; }
    }

}
