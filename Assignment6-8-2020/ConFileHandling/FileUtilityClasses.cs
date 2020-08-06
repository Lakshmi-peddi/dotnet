using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConFileHandling
{
    class FileUtilityClasses
    {
        static void Main()
        {
            //FileStream fs = new FileStream(@"E:\DotNet\ConsoleFirstAPP\file1.txt", FileMode.Create,FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("We have created our first file using FieStream");
            //sw.WriteLine("FileStream is an utility class of Input Output namespace");
            //sw.WriteLine("File Stream inherits from the abstract class stream");
            //sw.Close();
            //fs.Close();
            //Console.WriteLine("Data written in the file");
            FileStream fs = null;
            StreamWriter sw = null; 
            try
            {
                fs = new FileStream(@"E:\DotNet\ConsoleFirstAPP\file2.txt", FileMode.Open, FileAccess.Read);
                sw= new StreamWriter(fs);
                sw.WriteLine("We have created our first file using FieStream");
                sw.WriteLine("FileStream is an utility class of Input Output namespace");
                sw.WriteLine("File Stream inherits from the abstract class stream");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Data is written");
                sw.Close();
                fs.Close();   
            }
            Console.Read();
        }
    }
}
