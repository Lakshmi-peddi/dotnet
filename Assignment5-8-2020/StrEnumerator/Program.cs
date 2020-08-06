using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection str = new StringCollection();
            str.Add("1");
            str.Add("2");
            str.Add("3");
            str.Add("4");
            str.Add("5");
            foreach (var i in str)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("enumerating elements .....");
            StringEnumerator stre = str.GetEnumerator();
            while (stre.MoveNext())
            {
                Console.WriteLine("{0}", stre.Current);
            }
            Console.WriteLine("resetting the enumerator...");
            stre.Reset();
            if (stre.MoveNext())
                Console.WriteLine("The first element is {0}.", stre.Current);
            Console.WriteLine("finding the type of elements in the collection.....");
            var k = stre.GetType();
            Console.WriteLine(k);
            Console.WriteLine("finding whether the specified element is equal to all elements in collection...");
            var l = stre.Equals("1");
            Console.WriteLine(l);
            Console.WriteLine("gets the hashcode of the elements...");
            var m = stre.GetHashCode();
            Console.WriteLine(m);
            Console.Read();
        }
    }
}
