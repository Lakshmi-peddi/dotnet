using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleLinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows";
            ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("**************");
            ShowLargeFilesWithLinq(path);
            Console.Read();
        }



        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length
                        select file;
            //foreach(var file in query)
            //{
            //    Console.WriteLine($"{file.Name} : {file.Length}");
            //}



            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }



        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fio = dir.GetFiles();
            Array.Sort(fio, new FileInfoComparer());
            foreach (FileInfo item in fio)
            {
                Console.WriteLine($"{item.Name} : {item.Length}");
            }
        }
    }



    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
