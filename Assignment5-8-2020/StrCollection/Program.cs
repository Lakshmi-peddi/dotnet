using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrCollection
{

    class Program
    {
        static void Main(string[] args)
        {
            StringCollection str = new StringCollection();
            str.Add("Sai");
            str.Add("Lakshmi");
            str.Add("Vinni");
            str.Add("Hari");
            str.Add("Teju");
            Console.WriteLine("StringCollection elements");
            foreach (string res in str)
            {
                Console.WriteLine(res);
            }
            String[] arr = new String[] { "one", "two", "three", "four", "five" };
            str.AddRange(arr);
            Console.WriteLine("Adding range of elements to string collection.....");
            foreach (string res in str)
            {
                Console.WriteLine(res);
            }
            Console.WriteLine("inserting elements at a specified location.....");
            str.Insert(1, "Sampad");
            foreach (string res in str)
            {
                Console.WriteLine(res);
            }
            Console.WriteLine("checking wheteher the element is present or nor...");
            var k = str.Contains("Siri");
            Console.WriteLine(k);
            Console.WriteLine("finding the index of a particular element...");
            var j = str.IndexOf("Geetha");
            Console.WriteLine(j);
            Console.WriteLine("finding equality...");
            var l = str.Equals("Sarika");
            Console.WriteLine(l);
            Console.Read();
        }
    }
}