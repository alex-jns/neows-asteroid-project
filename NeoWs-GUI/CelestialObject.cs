using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoWs_GUI
{
    /// <summary>
    /// Contains all of the properties that make up a small body object
    /// Created to clean up the code as well as demonstrate inheritance
    /// </summary>
    public class CelestialObject
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string AbsoluteMagnitude { get; set; }
        public string EstimatedDiameterMinInKilometers { get; set; }
        public string EstimatedDiameterMinInMeters { get; set; }
        public string EstimatedDiameterMinInMiles { get; set; }
        public string EstimatedDiameterMinInFeet { get; set; }
        public string EstimatedDiameterMaxInKilometers { get; set; }
        public string EstimatedDiameterMaxInMeters { get; set; }
        public string EstimatedDiameterMaxInMiles { get; set; }
        public string EstimatedDiameterMaxInFeet { get; set; }
        public string CloseApproachDate { get; set; }
        public string RelativeVelocityInKilometersPerSecond { get; set; }
        public string RelativeVelocityInKilometersPerHour { get; set; }
        public string RelativeVelocityInMilesPerHour { get; set; }
        public string MissDistanceAstronomical { get; set; }
        public string MissDistanceLunar { get; set; }
        public string MissDistanceKilometers { get; set; }
        public string MissDistanceMiles { get; set; }
        public string OrbitingBody { get; set; }
        public string IsPotentiallyHazardousAsteroid { get; set; }
        public string IsSentryObject { get; set; }
    }
}
