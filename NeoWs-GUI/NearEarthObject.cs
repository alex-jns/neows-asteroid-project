using NeoWs_GUI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2_Project
{
    /// <summary>
    /// When a GET request is sent to the API, it returns a JSON string.
    /// In order to more easily access this data, it is deserialized into a JObject.
    /// This class serves to further organize the data from the JObject into a C# object.
    /// </summary>
    public class NearEarthObject
    {

        public async Task CallAPI(string date)
        {
            // NeoWs (Near Earth Object Web Service) is a RESTful web service for near earth Asteroid information.
            // With NeoWs a user can: search for Asteroids based on their closest approach date to Earth,
            // lookup a specific Asteroid with its NASA JPL small body id, as well as browse the overall data - set.
            // Data - set: All the data is from the NASA JPL Asteroid team (http://neo.jpl.nasa.gov/).
            // API is maintained by SpaceRocks (GitHub: https://github.com/SpaceRocks/)

            // Neo - Feed
            // Retrieve a list of Asteroids based on their closest approach date to Earth.
            // GET https://api.nasa.gov/neo/rest/v1/feed?start_date=START_DATE&end_date=END_DATE&api_key=API_KEY

            // Query Parameters
            // Parameter    Type        Default     Description
            // start_date   YYYY-MM-DD  none        Starting date for asteroid search
            // end_date     YYYY-MM-DD  7 days      after start_date Ending date for asteroid search
            // api_key      string      DEMO_KEY    api.nasa.gov key for expanded usage

            // Example query
            // https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=DEMO_KEY
            // https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=O5nkoPFJVe3BpMxCPRZysigCphgGjRubT936XYML

            string apiKey = "DEMO_KEY";
            RestClient client = new RestClient("https://api.nasa.gov/");
            RestRequest request = new RestRequest($"neo/rest/v1/feed?start_date={date}&end_date={date}&api_key={apiKey}");
            RestResponse response = await client.GetAsync(request);
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(response.Content);
            SmallBodyObject smallBody = new SmallBodyObject();
            smallBody.ConvertJObjectToList(jsonObject, date);
        }

        public string ValidateDate(string inputDate)
        {
            // If user accepts the default placeholder value of YYYY-MM-DD, set inputDate to today's date
            // If date text box is empty or has any white space, it will also use today's date
            if (inputDate == "YYYY-MM-DD" || inputDate.Trim() == "")
            {
                DateTime now = DateTime.Now;
                return now.ToString("yyyy-MM-dd");
            }

            // Test 1: RegEx expression verifies that the date format is correct for the API call (YYYY-MM-DD, digits 0-9 only)
            // However it will not check for real calendar dates, which means dates like 9999-99-99 will be valid
            string pattern = @"^\d{4}-\d{2}-\d{2}$";

            if (!Regex.IsMatch(inputDate, pattern))
            {
                try
                {
                    throw new FormatException($"Date must be in the YYYY-MM-DD format.");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    using (StreamWriter writer = new StreamWriter("error_log.txt", true))
                    {
                        writer.WriteLine($"[ERROR] [{DateTime.Now}] User attempted to use a date not in the YYYY-MM-DD format: {inputDate}");
                    }
                    return "Invalid";
                }
            }

            // Test 2: TryParse will attempt to convert the inputDate into a DateTime object, and return true if it succeeds
            // If it fails, it will return false and throw an exception
            if (!DateTime.TryParse(inputDate, out _))
            {
                try
                {
                    throw new FormatException($"Date must be a valid calendar date.");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    using (StreamWriter writer = new StreamWriter("error_log.txt", true))
                    {
                        writer.WriteLine($"[ERROR] [{DateTime.Now}] User attempted to use an non-calendar date: {inputDate}");
                    }
                    return "Invalid";
                }
            }

            // If all of the tests pass, the inputDate is ready to be used to call the API
            return inputDate;
        }
    }
}
