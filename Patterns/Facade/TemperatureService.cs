namespace Facade
{
    public class TemperatureService : ITemperatureService
    {
        private readonly WeatherService weatherService;

        private readonly GeoLocService geoLocService;

        private readonly MetricConverterService converter;

        public TemperatureService()
            : this(new WeatherService(), new GeoLocService(), new MetricConverterService())
        {
        }

        public TemperatureService(
            WeatherService weatherService,
            GeoLocService geoLocService,
            MetricConverterService converter)
        {
            this.weatherService = weatherService;
            this.converter = converter;
            this.geoLocService = geoLocService;
        }

        public LocalTemperature GetTemperature(string zipCode)
        {
            Coordinates coords = this.geoLocService.GetCoordinatesForZipCode(zipCode);
            string city = this.geoLocService.GetCityForZipCode(zipCode);
            string state = this.geoLocService.GetStateForZipCode(zipCode);

            double farenheit = this.weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            double celcius = this.converter.FarenheitToCelcius(farenheit);

            LocalTemperature localTemperature = new LocalTemperature()
                                                    {
                                                        Farenheit = farenheit,
                                                        Celcius = celcius,
                                                        City = city,
                                                        State = state
                                                    };

            return localTemperature;
        }
    }
}