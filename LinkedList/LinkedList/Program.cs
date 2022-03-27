
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
            linkedList.DeleteFirstNode();
            linkedList.Display();


        }
    }
}
