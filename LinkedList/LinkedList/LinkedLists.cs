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
        public Node Search(int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }
        public void Insert(int data, int dataBefore)
        {
            Node node = new Node(data);
            if (head == null)
                head = tail = node;
            else
            {
                Node nodeBefore = Search(dataBefore);
                if (nodeBefore != null)
                {
                    node.next = nodeBefore.next;
                    nodeBefore.next = node;
                    if (nodeBefore == tail)
                    {
                        tail = node;
                    }
                }
            }
        }
        public void DeleteFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = head;
                head = head.next;
                Console.WriteLine("\nRemoved from list " + temp.data);
            }
        }
        public void DeleteEndNode()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
        public int getSize()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public void DeleteNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Node node = Search(data);
                if (node == null)
                {
                    Console.WriteLine("Node not found");
                }
                else if (node == head)
                {
                    head = head.next;
                    if (node == tail)
                    {
                        tail = null;
                    }
                }
                else
                {
                    Node nodeBefore = null;
                    Node temp = head;
                    while (temp != null)
                    {
                        if (temp.next == node)
                        {
                            nodeBefore = temp;
                            break;
                        }
                        temp = temp.next;
                    }
                    nodeBefore.next = node.next;
                    if (node == tail)
                    {
                        tail = nodeBefore;
                    }
                    else
                    {
                        node.next = null;
                    }
                }
            }
        }
    }
}
