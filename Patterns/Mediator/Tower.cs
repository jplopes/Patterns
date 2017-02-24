namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tower : IAirTrafficControl
    {
        private readonly IList<Aircraft> aircraftUnderGuidance = new List<Aircraft>();

        public void ReceiveAircraftLocation(Aircraft reportingAircraft)
        {
            foreach (
                Aircraft currentAircraftUnderGuidance in this.aircraftUnderGuidance.Where(x => x != reportingAircraft))
            {
                if (Math.Abs(currentAircraftUnderGuidance.Altitude - reportingAircraft.Altitude) < 1000)
                {
                    reportingAircraft.Climb(1000);

                    // communicate to the class
                    currentAircraftUnderGuidance.WarnOfAirspaceIntrusionBy(reportingAircraft);
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!this.aircraftUnderGuidance.Contains(aircraft))
            {
                this.aircraftUnderGuidance.Add(aircraft);
            }
        }
    }
}