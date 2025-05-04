using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoWs_GUI
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Form2Search_Click(object sender, EventArgs e)
        {
            AdvancedSearch();
            this.Close();
        }

        private void Form2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Searches the list using user selected parameters
        /// </summary>
        private async void AdvancedSearch()
        {
            // Refresh the list, using the selected date
            await mainForm.UpdateList();

            // If any Absolute Magnitude filters are selected, filter the list
            if (!string.IsNullOrEmpty(AbsoluteMagnitudeComboBox.SelectedItem.ToString()))
            {
                string absoluteMagnitudeSelectionBox = AbsoluteMagnitudeComboBox.SelectedItem.ToString();
                SearchAbsoluteMagnitude(absoluteMagnitudeSelectionBox);
            }

            // This should be the very last thing this method does
            mainForm.DefaultSearch();
        }

        /// <summary>
        /// This method should only fire if the user has selected a value from the Absolute Magnitude combo box
        /// </summary>
        private void SearchAbsoluteMagnitude(string absoluteMagnitudeSelectionBox)
        {
            string textBox = AbsoluteMagnitudeValueTextBox.Text.Trim();

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
    }
}
