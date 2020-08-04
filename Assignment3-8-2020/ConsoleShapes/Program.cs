using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapes
{
    interface IVolume {
       
        //read-only property 
        double Volume { get;  }
    }

    interface IArea {
        double SurfaceArea();
    }

    interface ISolid : IArea, IVolume { 
    
    }

    abstract class ClassSolid:ISolid {
       
        double radius;
        const double pi=3.142;
        
        
        public abstract double Volume { get; set; }
        
         
        public abstract double SurfaceArea();
        
        
        public ClassSolid()
        {
            
        }

        public ClassSolid(double Radius)
        {
            radius = Radius;
        }

        

        
        public double Radius 
        { 
            get { return radius; } 
            set { radius = value; }
        }

        public double Pi 
        {
            get { return pi;} 
        }

    }

    

    class Cylinder : ClassSolid
    {
        double height;

        public Cylinder()
        {

        }

        public Cylinder(double Radius , double _height): base(Radius)
        {
            height = _height;
        }

        public override  double Volume 
        {
            
            get {
                return Pi * Radius * Radius * height;
            }

            set {
              
                Volume = value;
            }
        }

        public override double SurfaceArea()
        {
            
            double _SurfaceArea = 2 * Pi * Radius * (Radius* height);
            return _SurfaceArea;
        }

        public void Show(double rad , double ht)
        {
            Radius = rad;
            height = ht;
            SurfaceArea();
            Console.WriteLine("Volume of              Cylinder:   {0}", Volume);
            Console.WriteLine("Surface Area of        Cylinder:   {0}", SurfaceArea());
            Console.WriteLine("-----------------------------------------------------------------");
        }

    }

    class Sphere : ClassSolid
    {
        public Sphere()
        {

        }
        public Sphere(double Radius):base(Radius)
        {

        }
        public override double Volume
        {
            get
            {
                return 4 * Pi * Radius * Radius;
            }

            set
            {
                Volume = value ;
            }
        }

        public override double SurfaceArea()
        {
            double SurfaceArea = (4 / 3) * Pi * Radius * Radius * Radius;
            return SurfaceArea;
        }

        public void Show(double rad)
        {
            Radius = rad;
            SurfaceArea();
            Console.WriteLine("Volume of              Sphere:   {0}", Volume);
            Console.WriteLine("Surface Area of        Sphere:   {0}", SurfaceArea());
            Console.WriteLine("-----------------------------------------------------------------");
        }

    }


    class Program
    {
        static void Main()
        {
            
            Cylinder cylinderObj = new Cylinder();
            cylinderObj.Show(1,2);
            Sphere sphereObj = new Sphere();
            sphereObj.Show(3);
        }
    }
}