using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using CalculatorLib;

namespace CalculatorSerialization
{
    [Serializable]

    class Program
    {
        static void Main(string[] args)
        {
            ArthematicOperations obj= new ArthematicOperations();
            FileStream fs = new FileStream("Calculator1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(fs, obj);
            Console.WriteLine("Text File Created");
        }
    }
}
