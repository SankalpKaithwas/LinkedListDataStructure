using System;

namespace LinkedList
{
    class LinkedLists
    {
        public Node head;
        public Node tail;

        public LinkedLists()
        {
            head = null;
            tail = null;
        }

        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head = node;
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
