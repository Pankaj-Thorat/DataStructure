using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            //To add
            myList.Add(56);
            myList.Add(30);
            myList.Add(70);
            //To display
            myList.Display();
        }

    }
}

