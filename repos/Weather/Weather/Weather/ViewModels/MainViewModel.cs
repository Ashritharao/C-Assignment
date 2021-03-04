using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Weather.Models;
using Weather.Services;

namespace Weather.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private string city;
        public string City
        {
            get => city;
            set => Set(ref city, value);
        }
        private ObservableCollection<ForecastGroup> days;
        public ObservableCollection<ForecastGroup> Days
        {
            get => days;
            set => Set(ref days, value);
        }
        //Rest of the class is omitted for brevity
    }
    // private readonly IWeatherService weatherService;
    //public MainViewModel(IWeatherService weatherService)
    //{
    //this.weatherService = IWeatherService;
    //}
}
