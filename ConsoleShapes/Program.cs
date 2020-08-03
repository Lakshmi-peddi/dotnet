using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapes
{
    interface IVolume
    {
        double Volume { get; }
    }
    interface IArea
    {
        double SurfaceArea();
    }

    interface ISolid : IArea, IVolume
    {

    }
    abstract class Solid : ISolid
    {
        double radius;
        const double pi = 3.142;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double Pi
        {
            get { return pi; }

        }

        public Solid()
        {

        }
        public Solid(double _radius, double _pi)

        {
            radius = _radius;

        }
        
        public abstract double Volume
        {
            get;
        }

        
        public abstract double SurfaceArea();



    }
    class Cylinder : Solid
    {
        double height;
        
        public Cylinder()
        {

        }
        public Cylinder(double _height, double _radius, double _pi) : base(_radius, _pi)
        {
            height = _height;

        }

        public override double Volume
        {
            get
            {
                double volume = Pi * Radius * height;
                return volume;
            }

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 2 * Pi * Radius * (Radius + height);
            return surfaceArea;
        }
    }
    class Sphere : Solid
    {
        public Sphere()
        {

        }
        public Sphere(double _radius, double _pi) : base(_radius, _pi)
        {

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 4 / 3 * Pi * Radius * Radius * Radius;
            return surfaceArea;
        }
        public override double Volume
        {
            get
            {
                double volume = 4 * Pi * Radius * Radius;

                return volume;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cd = new Cylinder(5.6, 3.2, 3.14);
            //cd.SurfaceArea();
            Console.WriteLine("Surface Volume of Cylinder : {0}", cd.Volume);
            Console.WriteLine("Surface area  of Cylinder:{0}", cd.SurfaceArea());
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Sphere Sp = new Sphere(3.2, 3.14);
            Console.WriteLine("Surface Volume of Sphere :{0}", Sp.Volume);
            Console.WriteLine("Surface area of Sphere : {0}", Sp.SurfaceArea());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");


        }
    }
}