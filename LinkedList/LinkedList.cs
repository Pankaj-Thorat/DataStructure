using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    class LinkedList
    {
        private Node head;
        //To insert
        public void Add(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }
        //To add after
        public void AddAfter(Node node, Node newNode)
        {
            if (node == null)
            {
                Console.WriteLine("Cannot add after a null node.");
                return;
            }

            newNode.Next = node.Next;
            node.Next = newNode;
        }

        // To display
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
