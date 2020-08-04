using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samples;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Cielo", "red"); 
            car.Start();
            car.Stop();

            Vehicle truck = new Vehicle("Tata", "blue", VehType.Truck, 6, FuelType.Diesel,"Tata");
            truck.Start(); 
            truck.Stop();

            Vehicle smallcar = new Vehicle("Indica", "silver", VehType.Car, 4); 
            smallcar.Start();
            smallcar.Stop();
            Console.Read();
        }
    }
}