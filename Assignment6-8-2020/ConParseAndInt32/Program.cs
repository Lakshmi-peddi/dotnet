using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConParseAndInt32
{
    class Program
    {
        static void Main(string[] args)
        {
            string convertToInt = "12";
            string nullString = null;
            string maxValue = "59781346792584139761";
            string formatException = "45.98";

            Console.WriteLine("int.Parse");
            Console.WriteLine();
            Console.WriteLine(" int.Parse(convertToInt) : {0}", int.Parse(convertToInt));
            Console.WriteLine();

            try
            {
                Console.WriteLine("int.Parse(nullString) : {0}", int.Parse(nullString));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("int.Parse(maxValue) : {0}", int.Parse(maxValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("int.Parse(formatException) : {0}", int.Parse(formatException));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("ConvertToInt");
            Console.WriteLine();
            Console.WriteLine("Convert.ToInt32(convertToInt) : {0}", Convert.ToInt32(convertToInt));
            Console.WriteLine();

            try
            {
                Console.WriteLine(" Convert.ToInt32(nullString) : {0}", Convert.ToInt32(nullString));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine(" Convert.ToInt32(maxValue) : {0}", Convert.ToInt32(maxValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine(" Convert.ToInt32(formatException) : {0}", Convert.ToInt32(formatException));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
