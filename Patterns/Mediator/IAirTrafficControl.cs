namespace Mediator
{
    public interface IAirTrafficControl
    {
        void ReceiveAircraftLocation(Aircraft location);

        void RegisterAircraftUnderGuidance(Aircraft aircraft);
    }
}