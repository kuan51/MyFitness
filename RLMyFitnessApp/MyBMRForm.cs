// Name: Rex Linder
// Class: INFO 1200
// Section: 002
// Professor: Crandall
// Date: 4/20/2016
// Project #: 10
// I declare that the source code contained in this assignment was written solely by me.
// I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLMyFitnessApp
{
    public partial class MyBMRForm : Form
    {
        // Declared constants for calculating BMR
        const double FMETABOLISM = 655;
        const double MMETABOLISM = 66;
        const double HBWF = 4.35;
        const double HBWM = 6.23;
        const double HBHF = 4.7;
        const double HBHM = 12.7;
        const double HBAF = 4.7;
        const double HBAM = 6.8;

        public MyBMRForm()
        {
            InitializeComponent();

            // Sets listbox default selection to "little"
            listBoxActivity.SelectedIndex = 0;
        }

        /// <summary>
        /// Click event to close MyBMRForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        /// <summary>
        /// Click event to calculate BMR results using input from the MyProfileForm dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcBmr_Click(object sender, EventArgs e)
        {
            // Call MyProfileForm class
            MyProfileForm profile = new MyProfileForm();

            // Show MyProfileForm Dialog for user to input weight, age, and height
            profile.ShowDialog();

            // Declare BMR variables
            double BMR;
            if (radioBtnFemale.Checked)
            {
                // Calculate Female BMR
                BMR = FMETABOLISM + (HBWF * profile.Weight) + (HBHF * profile.Height) - (HBAF * profile.Age);
            }
            else
            {
                // Calculate Male BMR
              BMR = MMETABOLISM + (HBWM * profile.Weight) + (HBHM * profile.Height) - (HBAM * profile.Age);
            }

            // Declared variables for measuring activity levels
            int workout = listBoxActivity.SelectedIndex;
            double little = 1.2;
            double light = 1.375;
            double moderate = 1.55;
            double heavy = 1.725;
            double intense = 1.9;

            // Switch statement to set user selected variable in BMR equation
            switch (workout)
            {
                case 0:
                    BMR *= little;
                    break;
                case 1:
                    BMR *= light;
                    break;
                case 2:
                    BMR *= moderate;
                    break;
                case 3:
                    BMR *= heavy;
                    break;
                case 4:
                    BMR *= intense;
                    break;
                default:
                    MessageBox.Show("Please select a workout.", "No Workout Selected!");
                    break;
            }

            // Set BMR Result label to display switch statement results
            lblBmrResult.Text = BMR.ToString("n2");
        }
    }
}
