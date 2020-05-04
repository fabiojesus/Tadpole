using Structures.Interfaces.Simple;
using Structures.Lists;
using Structures.Nodes;
using Structures.SpecialLists;
using Structures.SpecialLists.A;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new CircularLinkList<int>();
            //list.AddFirst(3);
            //list.AddFirst(2);
            //list.AddFirst(1);
            //list.AddLast(4);
            //list.AddLast(5);
            //list.AddLast(6);
            //var one = list.RemoveFirst();
            //var six = list.RemoveLast();
            //var two = list.RemoveFirst();
            //var five = list.RemoveLast();
            //var three = list.RemoveFirst();
            //var four = list.RemoveLast();
            //list.AddLast(3);

            //var stack = new Structures.SpecialLists.Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //var lst = new List<int>();
            //while (!stack.IsEmpty)
            //{
            //    Console.WriteLine(stack.Peek());
            //    lst.Add(stack.Pop());
            //}

            //var queue = new Structures.SpecialLists.Queue<int>();
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //var lst = new List<int>();
            //while (!queue.IsEmpty)
            //{
            //    Console.WriteLine(queue.Peek());
            //    lst.Add(queue.Dequeue());
            //}

            //var dequeue = new Structures.SpecialLists.Dequeue<int>();
            //dequeue.Push(4);
            //dequeue.Push(5);
            //dequeue.Push(6);
            //dequeue.Shift(3);
            //dequeue.Shift(2);
            //dequeue.Shift(1);
            //var lst = new List<int>();
            //lst.Add(dequeue.Unshift());
            //lst.Add(dequeue.Pop());
            //lst.Add(dequeue.Unshift());
            //lst.Add(dequeue.Pop());
            //lst.Add(dequeue.Unshift());
            //lst.Add(dequeue.Pop());

            //var binaryTree = new BinaryTree(3);
            //binaryTree.AddRecursive(4);
            //binaryTree.AddRecursive(2);
            //binaryTree.AddRecursive(5);
            //binaryTree.AddRecursive(1);
            //Console.WriteLine(binaryTree.Highest());
            //Console.WriteLine(binaryTree.Smallest());
            //binaryTree.PostorderTraversal();
            //Console.WriteLine();
            //binaryTree.PreOrderTraversal();
            //Console.WriteLine();
            //binaryTree.InOrderTraversal();

            var dequeueeuueue = new Structures.SpecialLists.A.Dequeue<int>();
            dequeueeuueue.Push(3);
            Console.WriteLine(dequeueeuueue.Pop());
        }

    }
}
