using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleLinqSamples
{
    class LinqQueries
    {
        static void Main()
        {
            //Linq quries can be written in two ways
            //1.Query syntax//query on RDM data:"select * from Emp where esal>5000 order by Ename desc"
            string[] cities = { "Boston", "Los Angels", "Seattle", "London", "Hyderabad" };
            IEnumerable<String> filteredCities = from city in cities where city.StartsWith("L") &&city.Length < 15
               orderby city
               select city;
            var allCities = from city in cities select city;
            foreach(var f in filteredCities)
            {
                Console.WriteLine(f);
            }

            //2.Method Syntax
            //Console.WriteLine("Method Syntax");
            var methodSyntax=cities.Where(c=>c.StartsWith("L")&&c.Length<15).OrderBy(c=>c).Select(c=>c);
            foreach (var c in methodSyntax)
            {
                Console.WriteLine(c);
            }

            Console.Read();
        }
    }
}
