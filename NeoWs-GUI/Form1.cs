using CS2_Project;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoWs_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await UpdateList();
            DefaultSearch();
        }

        private void ShowInformationButton_Click(object sender, EventArgs e)
        {
            ShowInformation();
        }

        private void DatabaseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;

            if (!string.IsNullOrEmpty(target))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                });
            }
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {
            AdvancedSearch();
        }

        internal async Task UpdateList()
        {
            NearEarthObject NeoWs = new NearEarthObject();

            // Get a valid date and update the text box
            string date = NeoWs.ValidateDate(DateTextBox.Text);
            if (date == "Invalid")
            {
                return;
            }
            DateTextBox.Text = date;

            // Call the API and create a list of objects
            await NeoWs.CallAPI(date);
        }

        public void DefaultSearch()
        {
            // Clear the list box and update it using the list
            NeoListBox.Items.Clear();

            foreach (SmallBodyObject smallBodyObject in SmallBodyObjectManager.Instance.ListOfSmallBodyObjects)
            {
                NeoListBox.Items.Add(smallBodyObject.Name);
            }

            // Update the date's element count and reset the cursor
            ElementCountTextBox.Text = NeoListBox.Items.Count.ToString();
        }

        private async void AdvancedSearch()
        {
            // Refresh the list, using the selected date
            await UpdateList();

            // If any Absolute Magnitude filters are selected, filter the list
            if (!string.IsNullOrEmpty(AbsoluteMagnitudeComboBox.SelectedItem.ToString()))
            {
                string absoluteMagnitudeSelectionBox = AbsoluteMagnitudeComboBox.SelectedItem.ToString();
                SearchAbsoluteMagnitude(absoluteMagnitudeSelectionBox);
            }

            // This should be the very last thing this method does
            DefaultSearch();
        }

        /// <summary>
        /// This method should only fire if the user has selected a value from the Absolute Magnitude combo box
        /// </summary>
        private void SearchAbsoluteMagnitude(string absoluteMagnitudeSelectionBox)
        {
            string textBox = AbsoluteMagnitudeValueBox.Text.Trim();

            if (double.TryParse(textBox, out double absoluteMagnitudeValueBox))
            {
                // Method will exit if TryParse fails
                // Otherwise it will continue
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for Absolute Magnitude.");
                return;
            }

            // Should only reach this point if TryParse is successful
            switch (absoluteMagnitudeSelectionBox)
            {
                case ("is greater than"):
                    SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                        .Where(obj => Convert.ToDouble(obj.AbsoluteMagnitude) > absoluteMagnitudeValueBox).ToList();
                    break;
                case ("is less than"):
                    SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                        .Where(obj => Convert.ToDouble(obj.AbsoluteMagnitude) < absoluteMagnitudeValueBox).ToList();
                    break;
                case ("is equal to"):
                    SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                        .Where(obj => Convert.ToDouble(obj.AbsoluteMagnitude) == absoluteMagnitudeValueBox).ToList();
                    break;
            }
        }

        private void ShowInformation()
        {
            var selectedItem = NeoListBox.SelectedItem;

            // Check if an item is selected
            // If no item is selected, instruct user and exit method
            if (selectedItem == null)
            {
                MessageBox.Show("Please select an item from the list.");
                return;
            }

            // Use LINQ to find the matching SmallBodyObject
            // Uses FirstOrDefault to find the first matching object,
            // as there should only be one, and the search can stop after it is found
            var smallBodyObject = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                .FirstOrDefault(obj => obj.Name == selectedItem.ToString());

            // Check to make sure a matching object was found
            if (smallBodyObject != null)
            {
                // Populate the text boxes with the object's properties
                NameTextBox.Text = smallBodyObject.Name;
                IDTextBox.Text = smallBodyObject.ID;
                OrbitingBodyTextBox.Text = smallBodyObject.OrbitingBody;
                CloseApproachDateTextBox.Text = smallBodyObject.CloseApproachDate;
                AbsoluteMagnitudeTextBox.Text = smallBodyObject.AbsoluteMagnitude;
                PotentiallyHazardousTextBox.Text = smallBodyObject.IsPotentiallyHazardousAsteroid;
                SentryObjectTextBox.Text = smallBodyObject.IsPotentiallyHazardousAsteroid;
                MinimumFeetTextBox.Text = smallBodyObject.EstimatedDiameterMinInFeet;
                MinimumMetersTextBox.Text = smallBodyObject.EstimatedDiameterMinInMeters;
                MinimumMilesTextBox.Text = smallBodyObject.EstimatedDiameterMinInMiles;
                MinimumKilometersTextBox.Text = smallBodyObject.EstimatedDiameterMinInKilometers;
                MaximumFeetTextBox.Text = smallBodyObject.EstimatedDiameterMaxInFeet;
                MaximumMetersTextBox.Text = smallBodyObject.EstimatedDiameterMaxInMeters;
                MaximumMilesTextBox.Text = smallBodyObject.EstimatedDiameterMaxInMiles;
                MaximumKilometersTextBox.Text = smallBodyObject.EstimatedDiameterMaxInKilometers;
                MissDistanceMilesTextBox.Text = smallBodyObject.MissDistanceMiles;
                MissDistanceKilometersTextBox.Text = smallBodyObject.MissDistanceKilometers;
                MissDistanceLunarTextBox.Text = smallBodyObject.MissDistanceLunar;
                MissDistanceAstronomicalTextBox.Text = smallBodyObject.MissDistanceAstronomical;
                KilometersPerSecondTextBox.Text = smallBodyObject.RelativeVelocityInKilometersPerSecond;
                KilometersPerHourTextBox.Text = smallBodyObject.RelativeVelocityInKilometersPerHour;
                MilesPerHourTextBox.Text = smallBodyObject.RelativeVelocityInMilesPerHour;
                DatabaseLinkLabel.Text = $"Small-Body Database Lookup for: {smallBodyObject.Name}";
                DatabaseLinkLabel.Links.Clear();
                DatabaseLinkLabel.Links.Add(0, DatabaseLinkLabel.Text.Length, smallBodyObject.URL);
            }
            else
            {
                MessageBox.Show("No matching object found.");
            }
        }
    }
}
