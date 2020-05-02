using Structures.Interfaces.Simple;
using Structures.Lists;
using Structures.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CircularLinkList<int>();
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            var one = list.RemoveFirst();
            var six = list.RemoveLast();
            var two = list.RemoveFirst();
            var five = list.RemoveLast();
            var three = list.RemoveFirst();
            var four = list.RemoveLast();
            list.AddLast(3);
        }

    }
}
