using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            Node<string> firstNode = new Node<string>("First");
            Node<string> secondNode = new Node<string>("Second");
            Node<string> thirdNode = new Node<string>("Third");
            Node<string> forthNode = new Node<string>("Forth");
            Console.WriteLine(linkedList.Count);
            linkedList.Add(firstNode);
            Console.WriteLine(linkedList.Count);
            linkedList.Add(secondNode);
            Console.WriteLine(linkedList.Count);
            linkedList.Add(thirdNode);
            Console.WriteLine(linkedList.Count);
            linkedList.Add(forthNode);

            EnlistAll(linkedList);

            //linkedList.Remove();
            //Console.WriteLine("After remove");
            //EnlistAll(linkedList);
            linkedList.RemoveByIndex(3);
            EnlistAll(linkedList);
            Console.ReadKey();

        }

        private static void EnlistAll(LinkedList<string> linkedList)
        {
            Node<string> head = linkedList.first;
            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }
    }
}
