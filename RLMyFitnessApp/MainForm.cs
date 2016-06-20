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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

            // Sets lblDate.Text to display today's date
            lblDate.Text = DateTime.Now.ToString("d");
        }

        /// <summary>
        /// Click event to open myProfile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            // calls the form’s constructor.             
            MyProfileForm myprofile = new MyProfileForm();
            
            //  shows the form as a dialog
            myprofile.Show();
        }

        /// <summary>
        /// Click event to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        /// <summary>
        /// Click event to open MyBMRForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyBmr_Click(object sender, EventArgs e)
        {
            // Call forms constructor
            MyBMRForm profile = new MyBMRForm();

            // Displays form.
            profile.ShowDialog();
        }

        /// <summary>
        /// Click event to open MyTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyTimer_Click(object sender, EventArgs e)
        {
            // Create new instance of MyTimer.
            MyTimer profile = new MyTimer();

            // Display form.
            profile.Show();
        }

        /// <summary>
        /// Click event to open My Exercise Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyExerciseLog_Click(object sender, EventArgs e)
        {
            // Create new instance of My exercise log
            MyExerciseLogForm profile = new MyExerciseLogForm();

            // Display form
            profile.ShowDialog();
        }

        /// <summary>
        /// Click event to call new instance of MyWater
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyWater_Click(object sender, EventArgs e)
        {
            // Create new instance
            MyWaterForm profile = new MyWaterForm();

            // Show dialog
            profile.Show();
        }

        /// <summary>
        /// Click event to open MyFood form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyFood_Click(object sender, EventArgs e)
        {
            // Create new instance
            MyFood profile = new MyFood();

            // Show dialog
            profile.Show();
        }

        /// <summary>
        /// Click event to open the Meal Planner form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMealPlanner_Click(object sender, EventArgs e)
        {
            // Create new instance of Meal Planner
            MyMealPlanner profile = new MyMealPlanner();

            // Load form
            profile.Show();
        }
    }
}
