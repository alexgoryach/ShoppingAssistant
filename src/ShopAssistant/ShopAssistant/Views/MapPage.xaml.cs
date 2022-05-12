using System;
using Newtonsoft.Json.Linq;
using RestSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAssistant.Views
{
    /// <summary>
    /// Page with map.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public MapPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        /// <inheritdoc />
        protected override async void OnAppearing()
        { 
            string url = "https://api.openweathermap.org/data/2.5/weather";
            using (var client = new RestClient(url))
            {
                try
                {
                    var request = new RestRequest();
                    request.AddParameter("lat", 56.00);
                    request.AddParameter("lon", 92.80);
                    request.AddParameter("appid", "a228dd1915ae0553bdf224a43e89f366");
                    request.AddParameter("units", "metric");
                    request.RequestFormat = DataFormat.Json;
                    request.Method = Method.Get;
                    var weather = (await client.ExecuteGetAsync(request));
                    JObject jObject = JObject.Parse(weather.Content);

                    weatherInfo.Text = $"Сейчас {jObject?["main"]?["temp"]} C°; Ощущается {jObject?["main"]?["feels_like"]}C°";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
