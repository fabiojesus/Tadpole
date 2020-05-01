using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces.Lists
{
    public interface ISingleLinkedList<T>
    {
        public void AddFirst(T value);
        public void AddLast(T value);
    }
}
