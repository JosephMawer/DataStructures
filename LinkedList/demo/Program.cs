using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice,data,k,x;
            
            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                System.Console.WriteLine("1.Display list");
                System.Console.WriteLine("2.Count the number of nodes");
                System.Console.WriteLine("3.Search for an element");
                System.Console.WriteLine("4.Insert in empty list/insert in beginning of the list");
                System.Console.WriteLine("5.Insert a node at the end of the list");
                System.Console.WriteLine("6.");
                System.Console.WriteLine("7.");
                System.Console.WriteLine("8.");
                System.Console.WriteLine("9.");
                System.Console.WriteLine("10.");
                System.Console.WriteLine("11.");
                System.Console.WriteLine("12.");
                System.Console.WriteLine("13.");
                System.Console.WriteLine("14.");
                System.Console.WriteLine("15.");
                System.Console.WriteLine("16.");
                System.Console.WriteLine("");
            }

        }
    }

    public class Node
    {
        public int info;
        public Node link;
        public Node(int i)
        {
            info = i;
            link = null;
        }
    }

    public class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }
    }
}
