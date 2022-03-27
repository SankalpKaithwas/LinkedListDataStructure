using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class SortedLinkedList
    {
        public Node head;
        public Node tail;
        public SortedLinkedList()
        {
            head = null;
            tail = null;
        }

        public void SortedAppendNode(params int[] data)
        {
            Array.Sort(data);
            for (int i = 0; i < data.Length; i++)
            {
                AppendNode(data[i]);
            }
        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write(" -> ");
                }
                temp = temp.next;
            }
        }
    }
}