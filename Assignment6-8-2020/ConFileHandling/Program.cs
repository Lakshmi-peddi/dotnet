using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explore DriveInfo
            Console.WriteLine("================Explore DriveInfo================");
            DriveInfo dio = new DriveInfo("c:");
            Console.WriteLine("Free space " + (dio.AvailableFreeSpace / 1024) / 1024);
            Console.WriteLine("VolumeLable: " + dio.VolumeLabel);
            Console.WriteLine("Drivertype: " + dio.DriveType);
            Console.WriteLine("IsReady: " + dio.IsReady);
            Console.WriteLine("RootDirectory: " + dio.RootDirectory);
            Console.WriteLine("DriveFormat: " + dio.DriveFormat);

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);

            }
            //Explore DirectoryInfo
            Console.WriteLine("================Explore DirectoryInfo================");
            DirectoryInfo dirinfo = new DirectoryInfo(@"E:\FrontEnd\bootstrapassignment");
            if (dirinfo.Exists)
            {
                DirectoryInfo[] arr = dirinfo.GetDirectories();
                foreach (var item in arr)
                {
                    Console.WriteLine($"Fullname {item.FullName}     Name: {item.Name}");
                }

                FileInfo[] fio = dirinfo.GetFiles();
                Console.WriteLine("File name");
                foreach (var item in fio)
                {
                    Console.WriteLine($"Fullname: {item.FullName} == {item.Length} bytes");
                }
            }

            else
            {
                Console.WriteLine("File do not exist");
            }
            Console.WriteLine("Parent: " + dirinfo.Parent);
            Console.WriteLine("Root: " + dirinfo.Root);
            DirectoryInfo di = new DirectoryInfo(@"E:\Dotnettraining\FrontEnd");
            
            
            //Explore FileInfo
            Console.WriteLine("================Explore FileInfo================");
            FileInfo file1 = new FileInfo(@"E:\Dotnettraining\Dot Net\README.md");
            Console.WriteLine($"Name: {file1.FullName} Extension: {file1.Extension} DirectoryName:  {file1.DirectoryName}");
            Console.WriteLine($"Directory: {file1.Directory} CreationTime: {file1.CreationTime} LastAccessTime: {file1.LastAccessTime}");

        }
    }
}

