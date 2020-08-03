using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    public enum VehType
    {
        car,
        bus,
        truck
    };
    public enum FuelType
    {
        diesel,
        petrol,
        cng
    };




    public class Vehicle
    {

        string name;
        string color;
        int noOfWheels;
        VehType vehType;
        FuelType fuel;
        public Vehicle(string name, string color, VehType veh, int noOfWheels, FuelType fuel)
        {
            this.Name = name;
            this.Color = color;
            this.NoOfWheel = noOfWheels;
            this.VehTypes = veh;
            this.FuelTypes = fuel;




        }

        public void Start(VehType vehicletype)
        {
            Console.WriteLine(vehicletype + " has started");
        }
        public void Stop(VehType vehicletype)
        {
            Console.WriteLine(vehicletype + "has stopped");
        }
     
        public Vehicle(string name, string color, VehType veh, int noOfWheels)
        {
            this.Name = name;
            this.Color = color;
            this.NoOfWheel = noOfWheels;
            this.VehTypes = veh;
            this.FuelTypes = FuelType.petrol;
        }
        public Vehicle(string name, string color)
        {
            this.Name = name;
            this.Color = color;
            this.VehTypes = VehType.car;
            this.NoOfWheel = 4;
            this.FuelTypes = FuelType.petrol;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int NoOfWheel
        {
            get { return this.noOfWheels; }
            set { this.noOfWheels = value; }
        }



        public VehType VehTypes
        {
            get { return this.vehType; }
            set { this.vehType = value; }
        }
        public FuelType FuelTypes
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

    }
}