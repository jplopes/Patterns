namespace Facade
{
    public interface ITemperatureService
    {
        LocalTemperature GetTemperature(string zipCode);
    }
}