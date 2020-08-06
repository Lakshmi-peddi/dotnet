using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleLinqSamples
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,Func<T,bool>predicate)
        {
            var result = new List<T>();
            foreach(var item in source)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
    class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year { get; set; }
    }
    class ComplexLinqQueries
    {
        static void Main()
        {
            var movies = new List<Movie>
            {
                new Movie {Title="Super Deluxe", Rating=4.2f,Year=2019},
                new Movie {Title="Special 26", Rating=4.8f,Year=2014},
                new Movie {Title="Kurban", Rating=4.1f,Year=2010},
                new Movie {Title="3 Idiots", Rating=5.0f,Year=2009}

            };
            var query = movies.Where(m => m.Year > 2010);
            foreach (var q in query)
            {
                Console.WriteLine($"Title :{q.Title} \n and Year:{q.Year}");
            }
            // IEnumerable<Movie>ie=movies
            //custom filter method
            var query1 = movies.Filter(m => m.Title.StartsWith("s"));
            foreach (var item in query1)
            {
                Console.WriteLine($"Movie Name Starting with S:{item.Title}");
            }
            Console.WriteLine("GroupBy Method");
            var groupmethod = movies.GroupBy(mov => mov.Year).Select(mov => mov);
            foreach (var item in groupmethod)
            {
                Console.WriteLine(item.Key);
                foreach (var student in item)
                {
                    Console.WriteLine(student.Title);
                }

            }

            Console.Read();
        }
    }
}