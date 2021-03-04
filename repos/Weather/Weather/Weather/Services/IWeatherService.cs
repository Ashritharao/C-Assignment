using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public interface IWeatherService
    {
        Task<Forecast> GetForecast(double latitude, double longitude);
    }
    public async Task LoadData()
    {
        var location = await Geolocation.GetLocationAsync();
        var forecast = await weatherService.GetForecast(location.Latitude, location.Longitude);

    }
}
