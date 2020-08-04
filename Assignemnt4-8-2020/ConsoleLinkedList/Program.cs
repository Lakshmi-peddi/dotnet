using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinkedList
{
    class Program
    {
            static void Main()
            {
                LinkedList<String> myList = new LinkedList<String>();
                myList.AddLast("quick");
                myList.AddLast("fox");
                myList.AddLast("the");
                myList.AddLast("lazy");
                Console.WriteLine("Linked list after adding the elements");
                foreach (string str in myList)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("myList after doing Addfirst..........");
                myList.AddFirst("allow");
                foreach (string str in myList)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("myList after doing Addlast..........");
                myList.AddLast("team");

                foreach (string str in myList)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("myList after doing Addafter..........");
                var newNode = myList.AddLast("dad");
                myList.AddAfter(newNode, "popup");
                foreach (string str in myList)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("myList after doing Addbefore..........");
                myList.AddBefore(newNode, "ear");
                foreach (string str in myList)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("myList after doing find..........");
                LinkedListNode<String> temp = myList.Find("allow");
                Console.WriteLine(temp.Value);
                Console.WriteLine("myList after doing findlast..........");
                LinkedListNode<String> temp2 = myList.FindLast("ear");
                Console.WriteLine(temp2.Value);
                Console.Read();

            }
        }
    }