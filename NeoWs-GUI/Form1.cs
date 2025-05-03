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
            Form2 form2 = new Form2(this);
            form2.Show();
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

        private void DefaultSearch()
        {
            // Clear the list box and update it using the list
            NeoListBox.Items.Clear();

            foreach (SmallBodyObject smallBodyObject in SmallBodyObject.ListOfSmallBodyObjects)
            {
                NeoListBox.Items.Add(smallBodyObject.Name);
            }

            // Update the date's element count and reset the cursor
            ElementCountTextBox.Text = NeoListBox.Items.Count.ToString();
        }

        internal void AdvancedSearch()
        {
            // Clear the list box and update it using the list
            NeoListBox.Items.Clear();

            foreach (SmallBodyObject smallBodyObject in SmallBodyObject.ListOfSmallBodyObjects)
            {
                NeoListBox.Items.Add(smallBodyObject.Name);
            }

            // Update the date's element count and reset the cursor
            ElementCountTextBox.Text = NeoListBox.Items.Count.ToString();
        }

        private void ShowInformation()
        {
            var selectedItem = NeoListBox.SelectedItem;

            // Need to find out how to do this without searching the list.
            // Maybe it's fine this way? It works.
            foreach (SmallBodyObject smallBodyObject in SmallBodyObject.ListOfSmallBodyObjects)
            {
                if (smallBodyObject.Name == selectedItem.ToString())
                {
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
            }
        }
    }
}
