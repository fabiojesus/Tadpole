using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces.Lists
{
    public interface IDualLinkList<T>
    {
        public void AddFirst(T value);
        public void AddLast(T value);
        public T RemoveFirst();
        public T RemoveLast();
        public T Current { get; }
        public void Next();
        public void Previous();
        public void Reset();
    }
}
