using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VehicleCard.Models
{
    public partial class Vehicle : Properties
    {
       private Guid id;

       public Guid Id
        {
            get { return id; }
            set { id = value; }
        }


        public Vehicle(string make, string model, int horsepower, int topSpeed, string imageUrl, int wheels) : base(make, model, horsepower, topSpeed, imageUrl, wheels)
        {
            this.id = Guid.NewGuid();
            this.Make = make;
            this.Model = model;
            this.Horsepower = horsepower;
            this.Topspeed = topSpeed;
            this.Imageurl = imageUrl;
            this.Wheels = wheels;

        }
         
       

        

        

    }

}
