namespace Facade
{
    public class GeoLocService
    {
        public Coordinates GetCoordinatesForZipCode(string zipCode)
        {
            return new Coordinates() { Latitude = 10, Longitude = 20 };
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Seattle";
        }

        public string GetStateForZipCode(string zipCode)
        {
            return "Washington";
        }
    }
}