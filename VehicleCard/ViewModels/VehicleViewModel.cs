﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using VehicleCard.Models;

namespace VehicleCard.ViewModels
{
    public partial class VehicleViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Vehicle> vehicles;

        public VehicleViewModel()
        {
            this.Vehicles = new ObservableCollection<Vehicle>();
            AddSampleData();



        }

        void AddSampleData()
        {
            Vehicles.Add(new Vehicle("Ford", "Fiesta", 300, 150, "dotnet_bot.png", 4));








        }

       






    }
}
