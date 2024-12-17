using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCard.Models
{
    public class Properties : Base
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; NotifyPropertyChanged(); }
        }
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; NotifyPropertyChanged(); }
        }
        private int horsepower;

        public int Horsepower
        {
            get { return horsepower; }
            set { horsepower = value; NotifyPropertyChanged(); }
        }
        private int topspeed;

        public int Topspeed
        {
            get { return topspeed; }
            set { topspeed = value; NotifyPropertyChanged(); }
        }
        private string imageurl;

        public string Imageurl
        {
            get { return imageurl; }
            set { imageurl = value; NotifyPropertyChanged(); }
        }
        private int wheels;

        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; NotifyPropertyChanged(); }
        }

        public Properties(string make, string model, int horsepower, int topSpeed, string imageUrl, int wheels)
        {
            this.Make = make;
            this.Model = model;
            this.Horsepower = horsepower;
            this.Topspeed = topSpeed;
            this.Imageurl = imageUrl;
            this.Wheels = wheels;
        }
    }
}
