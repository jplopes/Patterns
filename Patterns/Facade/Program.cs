namespace Facade
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            const string ZipCode = "SeattleZipCode";

            ITemperatureService temperatureService = new TemperatureService();
            LocalTemperature localTemp = temperatureService.GetTemperature(ZipCode);

            Console.WriteLine(
                "The current temperature is {0:F1}F/{1:F1}C. in {2}, {3}",
                localTemp.Farenheit,
                localTemp.Celcius,
                localTemp.City,
                localTemp.State);

            Console.ReadKey();
        }
    }
}
