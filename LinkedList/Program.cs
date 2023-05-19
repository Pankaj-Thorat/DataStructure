using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            Node node70 = new Node(70);
            myList.Add(node70);

            Node node30 = new Node(30);
            myList.AddAfter(node70, node30);

            Node node56 = new Node(56);
            myList.AddAfter(node30, node56);

            myList.Display();
        }

    }
}

