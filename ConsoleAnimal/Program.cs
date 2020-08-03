using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArr = { "Zebra", "Ant", "Owl", "Lion", "Dog" };
            Console.WriteLine("********For Loop*******");
            for (int i = 0; i < MyArr.Length; i++)
            {
                Console.WriteLine(MyArr[i]);

            }
            Console.WriteLine("********Foeach Loop********");
            foreach (string i in MyArr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("********dowhile loop********");
            int j = 0;
            do
            {


                Console.WriteLine(MyArr[j]);
                j++;
            } while (j < MyArr.Length);
            Console.WriteLine("********while loop********");
            int k = 0;
            while (k < MyArr.Length)
            {
                Console.WriteLine(MyArr[k]);
                k++;
            }
            string[] Animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] Places = { "Africa", "New Zealand", "Jamaica", "India" };
            Array.Sort(Animals);
            Console.WriteLine("********Sorted array of animals********");
            foreach (string i in Animals)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("********Sorted array of Places********");
            Array.Sort(Places);
            foreach (string i in Places)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
