using System;
using System.Text.Json;

namespace AS2425._4G.MouniriYousef.Meteo
{
    public class Temperatura
    {
        public string Città { get; set; }
        public string Descrizione { get; set; }
        public string Emoji { get; set; }
        public string GradiCelsius { get; set; }
        public string IconUrl { get; set; }

        public string Orario { get; set; }
        public string Data { get; set; }
        public string Json { get; set; } // Solo per debug/test
        private DateTime timeOfCreation = DateTime.Now;

        public Temperatura()
        {
            timeOfCreation = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Città}: {GradiCelsius}°C {Emoji} - {Descrizione}";
        }

        public bool IsExpired()
        {
            return (DateTime.Now - timeOfCreation).TotalSeconds > 20;
        }

        public async void Renew()
        {
            try
            {
                string url = $"https://wttr.in/{Città}?format=j1";

                using var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    using var stream = await response.Content.ReadAsStreamAsync();
                    var json = await JsonDocument.ParseAsync(stream);

                    var current = json.RootElement.GetProperty("current_condition")[0];

                    string description = current
                        .GetProperty("weatherDesc")[0]
                        .GetProperty("value").GetString() ?? "";

                    string temp = current
                        .GetProperty("temp_C").GetString() ?? "";

                    string emoji = description.Contains("cloud", StringComparison.OrdinalIgnoreCase) ? "☁️" :
                                   description.Contains("rain", StringComparison.OrdinalIgnoreCase) ? "🌧️" :
                                   description.Contains("clear", StringComparison.OrdinalIgnoreCase) ? "☀️" :
                                   description.Contains("snow", StringComparison.OrdinalIgnoreCase) ? "❄️" :
                                   "🌡️";

                    string iconUrl = IconUrl;

                    Descrizione = description;
                    Emoji = emoji;
                    IconUrl = iconUrl;
                    GradiCelsius = temp;
                    Json = json.RootElement.ToString();

                }
                else
                {
                    //da togliere MessageBox.Show("Errore nel recupero meteo.");
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
