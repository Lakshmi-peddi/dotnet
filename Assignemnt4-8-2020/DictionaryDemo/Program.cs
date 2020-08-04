using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "Guntur");
                dict.Add(2, "Pune");
                dict.Add(3, "Banglore");
                dict.Add(4, "Hyderabad");
                
                Console.WriteLine("Printing Dictionary Element");
                foreach (var a in dict)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();

                Console.WriteLine("Count of element in dictionary : {0}", dict.Count);

                Console.WriteLine("Checking index 1 in dict : {0}", dict.ContainsKey(1));
                Console.WriteLine("Checking Value Guntur in dict : {0}", dict.ContainsValue("Guntur"));
                Console.WriteLine("Checking index 5 in dict : {0}", dict.ContainsKey(5));

                dict.Clear();

                foreach (var a in dict)
                {
                    Console.WriteLine(a);
                }


                Console.ReadLine();

            }
        }
    }
