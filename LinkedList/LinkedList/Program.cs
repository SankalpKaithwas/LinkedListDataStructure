using System;
namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedList = new LinkedLists();
            linkedList.AddNode(30);
            linkedList.AddNode(56);
            linkedList.AppendNode(70);
            linkedList.Insert(40, 30);
            linkedList.Display();
            linkedList.DeleteNode(40);
            Console.WriteLine("\nSize is " + linkedList.getSize());
            linkedList.Display();
            Console.WriteLine();
            linkedList.DeleteEndNode();
            linkedList.Display();

            Node check = linkedList.Search(30);
            if (check != null)
            {
                Console.WriteLine("\nNode found");
            }
            else
            {
                Console.WriteLine("\nNode not found");
            }
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.SortedAppendNode(new int[] { 56, 30, 40, 70 });
            Console.WriteLine("Sorted Linked List");
            sortedLinkedList.Display();

        }
    }
}
