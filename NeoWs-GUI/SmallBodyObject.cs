using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace NeoWs_GUI
{
    /// <summary>
    /// Small Body Object class derived from the Near Earth Object class
    /// This class was intended to hold the actual values of each actual asteroid rather than the functionality
    /// Updates the static list of near earth objects in the parent class
    /// </summary>
    public class SmallBodyObject : CelestialObject
    {
        /// <summary>
        /// As each JObject is converted to an object, it is also anonymously added to a list.
        /// </summary>
        /// <param name="jsonObject">API Json string deserialized into a JObject.</param>
        /// <param name="startDate">Start date sent as part of the API GET request.</param>
        /// <returns>A list of near earth objects.</returns>
        public void ConvertJObjectToList(JObject jsonObject, string startDate)
        {
            // If the user wants to refresh, the list must be cleared to avoid duplicates.
            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects.Clear();

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
                SmallBodyObjectManager.Instance.ListOfSmallBodyObjects.Add(smallBodyObject);
            }
        }
    }

    /// <summary>
    /// Singleton design pattern to ensure that only one instance of the SmallBodyObjectManager exists
    /// The list is a central part of this application, and it is also used frequently
    /// It's important to have a single point of access to this list
    /// </summary>
    public class SmallBodyObjectManager
    {
        // This holds the instance of the singleton class
        // It is static because it belongs to the class itself, not an instance of it
        // It's private, so it can only be changed within the class
        private static SmallBodyObjectManager _instance;

        // Since _instance is private, it can only be accessed through the public Instance property
        public static SmallBodyObjectManager Instance
        {
            // get specifies what happens if the instance is trying to be read
            get
            {
                // If _instance is null, mostly likely because it hasn't been created yet,
                if (_instance == null)
                {
                    // So it will create a new one
                    _instance = new SmallBodyObjectManager();
                }
                // Then return it
                return _instance;
            }
        }

        // This is the list of small body objects
        // If the contents of the list are manipulated in any way, it will refer to the Instance of this class
        public List<SmallBodyObject> ListOfSmallBodyObjects { get; set; } = new List<SmallBodyObject>();
    }
}
