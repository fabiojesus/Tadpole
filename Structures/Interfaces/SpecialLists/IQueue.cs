using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces.SpecialLists
{
    interface IQueue<T>
    {
        public void Enqueue(T item);
        bool IsEmpty { get; }
        public T Dequeue();
        T Peek();
    }
}
