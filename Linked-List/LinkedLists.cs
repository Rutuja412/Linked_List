using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Linked_List
{
    internal class LinkedLists
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Append(int data)
        {
            Node node2 = new Node(data);
            if (this.head == null)
            {
                this.head = node2;
            }
            else
            {
                Node temp = this.head;
                head = node2;
                head.next = temp;
            }
            System.Console.WriteLine(data + " added in  appending order \n ");
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write( temp.data  + "->");
                temp = temp.next;
            }
        }
    }
}
