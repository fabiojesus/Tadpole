using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces.SpecialLists
{
    public interface IDequeue<T>
    {
        void Push(T item);
        T Pop();
        void Shift(T item);
        T Unshift();
        bool IsEmpty { get; }
        T PeekLast();
        T PeekFirst();
    }
}
