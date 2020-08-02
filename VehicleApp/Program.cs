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
            car.Start(car.VehTypes);
            //car.Stop(car.VehTypes);

            Vehicle truck = new Vehicle("Tata", "blue", VehType.truck, 6, FuelType.diesel);
            truck.Start(truck.VehTypes); 
            //truck.Stop(truck.VehTypes);

            Vehicle smallcar = new Vehicle("Indica", "silver", VehType.car, 4); 
            smallcar.Start(smallcar.VehTypes);
            //smallcar.Stop(smallcar.VehTypes);
        }
    }
}