using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
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
            string elementCount = NeoListBox.Items.Count.ToString();
            ElementCountTextBox.Text = elementCount;
            MessageBox.Show($"Search complete. Results returned: {elementCount}");
        }

        private async void AdvancedSearch()
        {
            // Refresh the list, using the selected date
            await UpdateList();

            SearchAbsoluteMagnitude();
            SearchPotentiallyDangerousObjects();
            SearchSentryObjects();
            SearchRelativeVelocity();

            // This should be the very last thing this method does
            DefaultSearch();
        }

        /// <summary>
        /// This method should only fire if the user has selected a value from the Absolute Magnitude combo box
        /// </summary>
        private void SearchAbsoluteMagnitude()
        {
            // Exit if combo box is empty
            if (AbsoluteMagnitudeComboBox.SelectedItem == null) { return; }

            string absoluteMagnitudeSelectionBox = AbsoluteMagnitudeComboBox.SelectedItem.ToString();
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

        private void SearchRelativeVelocity()
        {
            // Both combo boxes must have a value selected in order to proceed
            if (RelativeVelocityComboBox1.SelectedItem == null) { return; }
            if (RelativeVelocityComboBox2.SelectedItem == null) { return; }

            string relativeVelocityType = RelativeVelocityComboBox1.SelectedItem.ToString();
            string relativeVelocityComparison = RelativeVelocityComboBox2.SelectedItem.ToString();
            string textBox = RelativeVelocityValueTextBox.Text.Trim();

            // Attempt to convert contents of the text box to a double
            if (double.TryParse(textBox, out double relativeVelocitySpeed))
            {
                // Method will exit if TryParse fails
                // Otherwise it will continue
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for Relative Velocity.");
                return;
            }

            // Nested switch cases handle the 9 different combinations of the two combo boxes
            switch (relativeVelocityType)
            {
                case "km/s":
                    switch (relativeVelocityComparison)
                    {
                        case ">":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInKilometersPerSecond) > relativeVelocitySpeed).ToList();
                            break;
                        case "<":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInKilometersPerSecond) < relativeVelocitySpeed).ToList();
                            break;
                        case "=":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInKilometersPerSecond) == relativeVelocitySpeed).ToList();
                            break;
                    }
                    break;

                case "km/h":
                    switch (relativeVelocityComparison)
                    {
                        case ">":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInKilometersPerHour) > relativeVelocitySpeed).ToList();
                            break;
                        case "<":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInKilometersPerHour) < relativeVelocitySpeed).ToList();
                            break;
                        case "=":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInKilometersPerHour) == relativeVelocitySpeed).ToList();
                            break;
                    }
                    break;

                case "mph":
                    switch (relativeVelocityComparison)
                    {
                        case ">":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInMilesPerHour) > relativeVelocitySpeed).ToList();
                            break;
                        case "<":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInMilesPerHour) < relativeVelocitySpeed).ToList();
                            break;
                        case "=":
                            SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                                .Where(obj => Convert.ToDouble(obj.RelativeVelocityInMilesPerHour) == relativeVelocitySpeed).ToList();
                            break;
                    }
                    break;
            }
        }

        private void SearchPotentiallyDangerousObjects()
        {
            if (IsPotentiallyHazardousCheckBox.Checked)
            {
                SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                        .Where(obj => obj.IsPotentiallyHazardousAsteroid == "Yes").ToList();
            }
            else
            {
                return;
            }
        }

        private void SearchSentryObjects()
        {
            if (IsPotentiallyHazardousCheckBox.Checked)
            {
                SmallBodyObjectManager.Instance.ListOfSmallBodyObjects = SmallBodyObjectManager.Instance.ListOfSmallBodyObjects
                        .Where(obj => obj.IsSentryObject == "Yes").ToList();
            }
            else
            {
                return;
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

        /// <summary>
        /// Clears any selected advanced search parameters
        /// </summary>
        private void AdvancedSearchClearButton_Click(object sender, EventArgs e)
        {
            AbsoluteMagnitudeComboBox.SelectedIndex = -1;
            AbsoluteMagnitudeValueBox.Text = "";
            RelativeVelocityComboBox1.SelectedIndex = -1;
            RelativeVelocityComboBox2.SelectedIndex = -1;
            RelativeVelocityValueTextBox.Text = "";
            IsPotentiallyHazardousCheckBox.Checked = false;
            IsSentryObjectCheckBox.Checked = false;
        }
    }
}
