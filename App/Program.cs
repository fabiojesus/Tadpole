using Structures.Interfaces.Simple;
using Structures.Lists;
using Structures.Nodes;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = new DualLinkedNode<int>(3);
            n1.Next = null;

            IDualLinkNode<int> current = n1;
            while (true)
            {
                current = current.Next;
            }
        }
    }
}
