using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCard.Models
{
    public class Car : Vehicle
    {
        public Car(string make, string model, int horsepower, int topSpeed, string imageUrl, int wheels) : base(make, model, horsepower, topSpeed, imageUrl, wheels)
        {
        }

        public override void Horn()
        {
            // Truck horn
        }
    }
}
