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
using System.Threading;
using System.Media;

namespace RLMyFitnessApp
{
    public partial class MyTimer : Form
    {
        // Declare variables for time.
        int time;
        int restTime;

        public MyTimer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event to add an exercise to the queue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate exercise
            if (txtBoxExercise.Text != "")
            {
                // Validate time
                if (int.TryParse(txtBoxTime.Text, out time))
                {
                    // Take input from text boxes and add to listboxes.
                    lstBoxExercise.Items.Add(txtBoxExercise.Text);
                    lstBoxTime.Items.Add(txtBoxTime.Text);

                    // Clear and reset focus.
                    txtBoxExercise.Clear();
                    txtBoxTime.Clear();
                    txtBoxExercise.Focus();

                }
                // If no time, show dialog
                else
                {
                    // Highlight the textbox that raised the error
                    txtBoxTime.BackColor = Color.LightCoral;

                    // Show dialog asking to input time
                    MessageBox.Show("Please enter a time.", "No Time!");

                    // Clear time textbox.
                    txtBoxTime.Clear();

                    // Set focus back to time text box
                    txtBoxTime.Focus();

                    // Reset backcolor
                    txtBoxTime.BackColor = SystemColors.Window;
                }
            }

            // If no exercise, show dialog
            else
            {
                // Highlight the textbox that raised the error.
                txtBoxExercise.BackColor = Color.LightCoral;

                // Shows dialog asking to input exercise.
                MessageBox.Show("Please enter an exercise.", "No Exercise!");

                // Clear the exercise txtbox. 
                txtBoxExercise.Clear();

                // Set the focus back to the exercise textbox. 
                txtBoxExercise.Focus();

                // Reset backcolor
                txtBoxExercise.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Click event to submit list boxes and restTime to the stopwatch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate restTime
            if (int.TryParse(txtBoxRest.Text, out restTime) && restTime > 0)
            {
                // Validate AddExercise listbox
                if (lstBoxExercise.Items.Count > 0)
                {
                    // Validate time list box
                    if (lstBoxTime.Items.Count > 0)
                    {
                        MessageBox.Show("Workout Timer is ready to go!", "Get Some!");
                    }

                    // Show dialog
                    else
                    {
                        MessageBox.Show("Please add a time to the queue.", "No Input!");

                        // Clear and place focus on time txtBox.
                        txtBoxTime.Clear();
                        txtBoxTime.Focus();
                    }
                }

                // Show dialog
                else
                {
                    MessageBox.Show("Please add a exercise to the queue.", "No Input!");

                    // Clear and place focus on exercise txtBox.
                    txtBoxExercise.Clear();
                    txtBoxExercise.Focus();
                }
            }

            // Show dialog
            else
            {
                MessageBox.Show("Please add a rest time.", "No Input!");

                // Clear and place focus on Rest txtBox.
                txtBoxRest.Clear();
                txtBoxRest.Focus();
            }
        }

        /// <summary>
        /// Click event to clear all textboxes and list boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear listboxes
            lstBoxTime.Items.Clear();
            lstBoxExercise.Items.Clear();

            // Clear txtBoxes
            txtBoxExercise.Clear();
            txtBoxRest.Clear();
            txtBoxTime.Clear();
        }

        /// <summary>
        /// Click event to begin the queue that was submitted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Loop through each exercise
            for (int i = 0; i < lstBoxExercise.Items.Count; i++)
            {
                lblCurrentExercise.Text = lstBoxExercise.Items[i].ToString();
                time = int.Parse(lstBoxTime.Items[i].ToString());

                // Loop through the time
                for (int j = time; j >= 0; j--)
                {
                    // Declare time span variable and assign attributes
                    TimeSpan myTime = new TimeSpan(0, 0, j);

                    // Update stopwatch
                    lblStopWatch.Text = myTime.ToString(@"mm\:ss");
                    Thread.Sleep(1000);
                    Application.DoEvents();

                    // If last 3 seconds then beep
                    if (j < 3)
                    {
                        SystemSounds.Question.Play();
                    }
                }

                // Loop through the rest time
                for (int k = restTime; k >= 0; k--)
                {
                    TimeSpan myRestTime = new TimeSpan(0, 0, k);

                    // Display rest on lblCurrentExercise
                    lblCurrentExercise.Text = "Rest Time"; 

                    // Update stopwatch
                    lblStopWatch.Text = myRestTime.ToString(@"mm\:ss");
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    
                    // If last 3 seconds then beep
                    if (k < 3)
                    {
                        SystemSounds.Beep.Play();
                    }
                }
            }                   
            // Display done
            lblCurrentExercise.Text = "Workout Finished!";
        }

        /// <summary>
        /// Click event to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }
    }
}
