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
            var list = new DualLinkList<int>();
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            MoveAndShow(list, false);
            MoveAndShow(list, false);
            MoveAndShow(list, false);
            MoveAndShow(list, false);
            MoveAndShow(list, true);

        }


        static void MoveAndShow(DualLinkList<int> lista, bool paraAfrente)
        {
            if (paraAfrente) lista.Next();
            else lista.Previous();
            Console.WriteLine(lista.Current);
        }
    }
}
