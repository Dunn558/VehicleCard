using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using VehicleCard.Models;

namespace VehicleCard.ViewModels
{
    public partial class AddVehicleViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Vehicle> vehicles;

        public AddVehicleViewModel()
        {
            this.Vehicles = new ObservableCollection<Vehicle>();
        }

        [RelayCommand]
        public void AddVehicle(Properties properties)
        {

        }
    }
}
