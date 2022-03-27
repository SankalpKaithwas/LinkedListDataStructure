using System;
namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedList = new LinkedLists();

            linkedList.AddNode(56);
            linkedList.AppendNode(70);
            linkedList.Insert(30, 56);
            linkedList.Display();
            Console.WriteLine();          
            linkedList.DeleteEndNode();
            linkedList.Display();

            Node check = linkedList.Search(30);
            if(check != null)
            {
                Console.WriteLine("\nNode found");
            }
            else
            {
                Console.WriteLine("\nNode not found");
            }

        }
    }
}
