using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleString
{
    class SwitchCase
    {

        void Display()
        {
            Console.WriteLine("1. Concatenate Strings. ");
            Console.WriteLine("2. Length of two strings. ");
            Console.WriteLine("3. Substring ");
            Console.WriteLine("4. Replace. ");
            Console.WriteLine("5. Uppercase.");
            Console.WriteLine("6. Lowercase.");
            Console.WriteLine("7. Trim. ");
            Console.WriteLine("8. Split. ");
            Console.WriteLine("Make the choice again Enter 9 to exit ");
        }
        static void Main()
        {
            Console.WriteLine("Enter First string  ");
            string strA = Console.ReadLine();

            Console.WriteLine("Enter Second string  ");
            string strB = Console.ReadLine();
            string str;

             SwitchCase obj = new  SwitchCase();

        checkpoint: Console.WriteLine();
            
            obj.Display();

            char ch;
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    str = String.Concat(strA, strB);
                    Console.WriteLine("Concatenated string is: {0}", str);
                    goto checkpoint;
                
                case '2':
                    Console.WriteLine("String Length of first : " + strA.Length);
                    Console.WriteLine("String Length of first : " + strB.Length);
                    goto checkpoint;
                
                case '3':
                    Console.WriteLine("Substring of string A " + strA.Substring(2));
                    Console.WriteLine("Substring of string B " + strB.Substring(4));
                    goto checkpoint;

                case '4':
                    Console.WriteLine(strA = strA.Replace('a', 'b'));
                    Console.WriteLine(strB = strB.Replace('c', 'd'));
                    goto checkpoint;
               
                case '5':
                    Console.WriteLine(strA = strA.ToUpper());
                    Console.WriteLine(strB = strB.ToUpper());
                    goto checkpoint;

                case '6':
                    Console.WriteLine(strA = strA.ToLower());
                    Console.WriteLine(strB = strB.ToLower());
                    goto checkpoint;
                //break;
                case '7':
                    char[] arrA = { 'J', 'a' };
                    Console.WriteLine("String = " + strA);
                    Console.WriteLine("String (after trim) = " + strA.Trim(arrA));

                    char[] arrB = { 'F', 'a' };
                    Console.WriteLine("String = " + strB);
                    Console.WriteLine("String (after trim) = " + strA.Trim(arrB));
                    goto checkpoint;
               
                case '8':
                    char[] separator = { ':', ' ' };
                    string[] words = strA.Split(separator);
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }

                    char[] separator1 = { ';', ' ' };
                    string[] words1 = strB.Split(separator);
                    foreach (string word in words1)
                    {
                        Console.WriteLine(word);
                    }


                    goto checkpoint;
     
                case '9':

                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}