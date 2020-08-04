using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSortedList
{
        class Program
        {
            static void Main(string[] args)
            {


                var sorted = new SortedList<string, int>();

                sorted.Add("apples", 4);
                sorted.Add("bananna", 5);
                sorted.Add("orange", 6);
                sorted.Add("pineapple", 7);
                sorted.Add("papaya", 8);
                Console.WriteLine("Count");
                Console.WriteLine("No of items:{0}", sorted.Count);


                Console.WriteLine("Contain Key");

                Console.WriteLine("There are books in the list:{0}", sorted.ContainsKey("orange"));

                Console.WriteLine("Contains Value");
                Console.WriteLine("The value bananna contains in the sortedlist:" + sorted.ContainsValue(4));



                Console.WriteLine("Keys");



                foreach (KeyValuePair<string, int> pair in sorted)
                {
                    Console.WriteLine("{0} = {1}", pair.Key, pair.Value);
                }
                IList<int> ilvalue = sorted.Values;
                foreach (int i in ilvalue)
                {
                    Console.Write(i + "\n");
                }
                Console.WriteLine();

                Console.WriteLine("Values");

                IList<string> ilkey = sorted.Keys;
                foreach (string i in ilkey)
                {
                    Console.Write(i + "\n");
                }

                Console.Read();

            }
        }


    }
