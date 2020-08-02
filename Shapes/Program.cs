using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

abstract class Quadrilateral
{
    public int length;
    public Quadrilateral(int _length)
    {
        length = _length;
    }
    public void Display()
    {

        Console.WriteLine("");

    }

    public abstract int Area();

}

class Square : Quadrilateral
{
    public Square(int _len) : base(_len)
    {
    }
    public override int Area()
    {
        int r = length * length;
        return r;
    }
}

class Rectangle : Quadrilateral
{
    int breadth;
    public Rectangle(int _breadth, int _len) : base(_len)
    {
        breadth = _breadth;

    }
    public override int Area()
    {
        return (breadth * length);
    }
}




class Program
{
    static void Main(string[] args)
    {
        Square s = new Square(4);
        Console.WriteLine("Squaure Area : " + s.Area());

        Quadrilateral q = new Rectangle(6, 5);
        Console.WriteLine("Rectangle Area : " + q.Area());

        if (s.Area() > q.Area())
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }


        Console.Read();

    }
}
