namespace Facade.Problem
{
    using System;

    public class Program
    {
        private static void Main_Problem(string[] args)
        {
            const string ZipCode = "SeattleZipCode";

            GeoLocService geoLookupService = new GeoLocService();

            string city = geoLookupService.GetCityForZipCode(ZipCode);
            string state = geoLookupService.GetStateForZipCode(ZipCode);
            Coordinates coords = geoLookupService.GetCoordinatesForZipCode(ZipCode);

            WeatherService weatherService = new WeatherService();
            double farenheit = weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);

            MetricConverterService metricConverter = new MetricConverterService();
            double celcius = metricConverter.FarenheitToCelcius(farenheit);

            Console.WriteLine(
                "The current temperature is {0:F1}F/{1:F1}C. in {2}, {3}",
                farenheit,
                celcius,
                city,
                state);
            Console.ReadKey();
        }
    }
}
