using CS2_Project;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoWs_GUI
{
    /// <summary>
    /// Small Body Object class derived from the Near Earth Object class
    /// This class was intended to hold the actual values of each actual asteroid rather than the functionality
    /// Updates the static list of near earth objects in the parent class
    /// </summary>
    internal class SmallBodyObject : NearEarthObject
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

        public static List<SmallBodyObject> ListOfSmallBodyObjects { get; set; } = new List<SmallBodyObject>();

        /// <summary>
        /// As each JObject is converted to an object, it is also anonymously added to a list.
        /// </summary>
        /// <param name="jsonObject">API Json string deserialized into a JObject.</param>
        /// <param name="startDate">Start date sent as part of the API GET request.</param>
        /// <returns>A list of near earth objects.</returns>
        public void ConvertJObjectToList(JObject jsonObject, string startDate)
        {
            // If the user wants to refresh, the list must be cleared to avoid duplicates.
            ListOfSmallBodyObjects.Clear();

            // Create an object for every near earth object returned from the API call.
            foreach (var jObject in jsonObject["near_earth_objects"][startDate])
            {
                // Initialization of the object.
                SmallBodyObject smallBodyObject = new SmallBodyObject
                {
                    ID = jObject["id"].ToString(),
                    Name = jObject["name"].ToString(),
                    URL = jObject["nasa_jpl_url"].ToString(),
                    AbsoluteMagnitude = jObject["absolute_magnitude_h"].ToString(),
                    EstimatedDiameterMinInKilometers = jObject["estimated_diameter"]["kilometers"]["estimated_diameter_min"].ToString(),
                    EstimatedDiameterMinInMeters = jObject["estimated_diameter"]["meters"]["estimated_diameter_min"].ToString(),
                    EstimatedDiameterMinInMiles = jObject["estimated_diameter"]["miles"]["estimated_diameter_min"].ToString(),
                    EstimatedDiameterMinInFeet = jObject["estimated_diameter"]["feet"]["estimated_diameter_min"].ToString(),
                    EstimatedDiameterMaxInKilometers = jObject["estimated_diameter"]["kilometers"]["estimated_diameter_max"].ToString(),
                    EstimatedDiameterMaxInMeters = jObject["estimated_diameter"]["meters"]["estimated_diameter_max"].ToString(),
                    EstimatedDiameterMaxInMiles = jObject["estimated_diameter"]["miles"]["estimated_diameter_max"].ToString(),
                    EstimatedDiameterMaxInFeet = jObject["estimated_diameter"]["feet"]["estimated_diameter_max"].ToString(),
                    CloseApproachDate = jObject["close_approach_data"][0]["close_approach_date_full"].ToString(),
                    RelativeVelocityInKilometersPerSecond = jObject["close_approach_data"][0]["relative_velocity"]["kilometers_per_second"].ToString(),
                    RelativeVelocityInKilometersPerHour = jObject["close_approach_data"][0]["relative_velocity"]["kilometers_per_hour"].ToString(),
                    RelativeVelocityInMilesPerHour = jObject["close_approach_data"][0]["relative_velocity"]["miles_per_hour"].ToString(),
                    MissDistanceAstronomical = jObject["close_approach_data"][0]["miss_distance"]["astronomical"].ToString(),
                    MissDistanceLunar = jObject["close_approach_data"][0]["miss_distance"]["lunar"].ToString(),
                    MissDistanceKilometers = jObject["close_approach_data"][0]["miss_distance"]["kilometers"].ToString(),
                    MissDistanceMiles = jObject["close_approach_data"][0]["miss_distance"]["miles"].ToString(),
                    OrbitingBody = jObject["close_approach_data"][0]["orbiting_body"].ToString(),
                };

                // Converts true or false values to yes or no values to be more user friendly.
                if (jObject["is_potentially_hazardous_asteroid"].ToObject<bool>())
                {
                    smallBodyObject.IsPotentiallyHazardousAsteroid = "Yes";
                }
                else
                {
                    smallBodyObject.IsPotentiallyHazardousAsteroid = "No";
                }

                if (jObject["is_sentry_object"].ToObject<bool>())
                {
                    smallBodyObject.IsSentryObject = "Yes";
                }
                else
                {
                    smallBodyObject.IsSentryObject = "No";
                }

                // Finally, add the created object to the list.
                ListOfSmallBodyObjects.Add(smallBodyObject);
            }
        }
    }
}
