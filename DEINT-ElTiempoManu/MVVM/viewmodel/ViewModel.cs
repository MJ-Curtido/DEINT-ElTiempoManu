using DEINT_ElTiempoManu.MVVM.models;
using System.Text.Json;

namespace DEINT_ElTiempoManu.MVVM.viewmodel
{
    class ViewModel
    {
        HttpClient client;
        Tiempo tiempo;

        public ViewModel()
        {
            client = new HttpClient();
        }

        private async Task<Location> GetCoordinatesAsync(string adress)
        {
            var locations = await Geocoding.GetLocationsAsync(adress);
            var location = locations?.FirstOrDefault();
            return location;
        }

        private async Task GetWeather(Location location)
        {
            string longitud = (Math.Round(location.Longitude, 2).ToString().Replace(",", "."));
            string latitud = (Math.Round(location.Latitude, 2).ToString().Replace(",", "."));

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitud}&longitude={longitud}&daily=weathercode,temperature_2m_max,temperature_2m_min&current_weather=true&timezone=auto";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer
                        .DeserializeAsync<Tiempo>(responseStream);
                    tiempo = data;
                }
            }
        }
    }
}
