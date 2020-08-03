using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    public enum VehType
    {
        Car,
        Truck,
        Bus
    };
    public enum FuelType
    {
        Diesel,
        Petrol,
        CNG
    };

    public class Vehicle
    {

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        VehType vtype;
        public VehType Vtype
        {
            get { return this.vtype; }
            set { this.vtype = value; }
        }
        int noOfWheels;
        public int NoOfWheels
        {
            get { return noOfWheels; }
            set { noOfWheels = value; }
        }
        FuelType fType;
        public FuelType FType
        {
            get { return fType; }
            set { fType = value; }
        }
        string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public Vehicle(string name, string color, VehType vtype, int noOfWheels, FuelType ftype, string make)
        {
            this.name = name;
            this.color = color;
            this.vtype = vtype;
            this.noOfWheels = noOfWheels;
            this.fType = ftype;
            
        }
        public Vehicle(string name, string color, VehType vehType, int noOfWheels):this(name,color,vehType,noOfWheels,FuelType.Petrol,"Tata")
        {
            this.name = name;
            this.color = color;
            this.vtype = vehType;
            this.noOfWheels = noOfWheels;

        }
        public Vehicle(String name,string color):this(name,color,VehType.Car,4,FuelType.Petrol,"Tata")
        {
            this.name = name;
            this.color = color;
        }
        public void Start()
        {
            Console.WriteLine("{0} {1} {2} has started",name,vtype.ToString(),vtype.ToString());
        }
        public void Stop()
        {
            Console.WriteLine("{0} {1} {2} has stopped", name, vtype.ToString(), vtype.ToString());
        }

    }
}