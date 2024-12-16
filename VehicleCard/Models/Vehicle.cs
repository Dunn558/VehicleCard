using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VehicleCard.Models
{
    public partial class Vehicle: ObservableObject
    {
        [ObservableProperty]
        private Guid id;
        [ObservableProperty]
        private string make;
        [ObservableProperty]
        private string model;
        [ObservableProperty]
        private int horsepower;
        [ObservableProperty]
        private int wheels;
        [ObservableProperty]
        private int topSpeed;
        [ObservableProperty]
        private string imageUrl;
        public Vehicle(string make, string model, int horsepower, int topSpeed, string imageUrl, int wheels)
        {
            this.Id = Guid.NewGuid();
            this.Make = make;
            this.Model = model;
            this.Horsepower = horsepower;
            this.Wheels = wheels;
            this.TopSpeed = topSpeed;
            this.ImageUrl = imageUrl;
        }
        public virtual void Horn()
        {
            // Beep the horn
            
        }

        

        

    }

}
