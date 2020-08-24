using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleAndSingleOrDefault
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>(){
            new Employee() { Id = 101, Name = "Lakshmi", City = "Guntur" },
            new Employee() { Id=102, Name="Geetha", City="Delhi"},
            new Employee() { Id=103, Name="Monika", City="Indore"},
            new Employee() { Id=104, Name="Manisha", City="Madras"},
            new Employee() { Id=105, Name="Hema", City="Pune"}
        };
            var res = employeeList.Single(e => e.Id == 102);
            var res1= employeeList.Single(e => e.Name == "Lakshmi");
            IList<int> intList = new List<int> { 2 };
            var res2 = intList.Single();
            var res3 = employeeList.SingleOrDefault(e => e.Name == "Mouni");
            var res4 = employeeList.SingleOrDefault(e => e.Name == "Hema");
            var res5 = employeeList.SingleOrDefault(e => e.Id == 103);
            Console.Read();
        }
    }
}
//---Single
//It returns a single specific element from a collection of elements if element match found. An exception is thrown, if none or more than one match found for that element in the collection.
//----SingleOrDefault
//It returns a single specific element from a collection of elements if element match found. An exception is thrown, if more than one match found for that element in the collection. A default value is returned, if no match is found for that element in the collection.