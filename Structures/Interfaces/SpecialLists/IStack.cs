using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces.SpecialLists
{
    public interface IStack<T>
    {
        public void Push(T item);
        bool IsEmpty { get; }
        public T Pop();
        public T Peek();
    }
}
