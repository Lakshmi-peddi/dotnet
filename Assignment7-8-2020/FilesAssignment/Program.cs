using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAssignment
{
    class Program
    {
        public static void Main()
        {
            string path = @"E:\DotNet\ConsoleFindouts\Samples\MyTest.txt";


            if (!File.Exists(path))
            {

                string createText = "This is Sai!";
                File.WriteAllText(path,createText);
            }


            string appendText = "Hello Sai";
            File.AppendAllText(path,appendText);

            File.Copy(@"E:\DotNet\ConsoleFindouts\Samples\MyTest.txt", @"E:\DotNet\ConsoleFindouts\Samples\MyTest2.txt");
            string readText = File.ReadAllText(path);

            File.Delete(@"E:\DotNet\ConsoleFindouts\Samples\MyTest2.txt");
            Console.WriteLine(readText);
        }
    }
}