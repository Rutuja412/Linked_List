using System;
using System.Collections.Generic;

namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Linked List Practice Problems *******");
            LinkedLists list = new LinkedLists();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
