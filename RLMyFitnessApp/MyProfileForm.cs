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
    public partial class MyProfileForm : Form
    {
        // Declares variables for weight, height, and age for user input from the xorresponding textboxes.
        public int Weight;
        public new int Height;
        public int Age;

        // Declared constant variables for controlling the value range that a user can input.
        public const int MIN_WEIGHT = 50;
        public const int MAX_WEIGHT = 1000;
        public const int MIN_HEIGHT = 48;
        public const int MAX_HEIGHT = 96;
        public const int MIN_AGE = 12;
        public const int MAX_AGE = 120;

        public MyProfileForm()
        {
            InitializeComponent();

            // Put focus on textBoxFirstName on load.
            this.ActiveControl = textBoxFirstName;
            textBoxFirstName.Focus();
        }

        /// <summary>
        /// Click event to close the form and store input in the declared public int's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseProfile_Click(object sender, EventArgs e)
        {
            // Validate user input for Weight.
            if (int.TryParse(textBoxWeight.Text, out Weight))
            {
                // Validate user input for weight is in the acceptable range.
                if (Weight >= MIN_WEIGHT && Weight <= MAX_WEIGHT)
                {
                    // Validate user input for Height.
                    if (int.TryParse(textBoxHeight.Text, out Height))
                    {
                        // Validate user input for Height is in the acceptable range.
                        if (Height >= MIN_HEIGHT && Height <= MAX_HEIGHT)
                        {
                            // Validate user input for Age.
                            if (int.TryParse(textBoxAge.Text, out Age))
                            {
                                // Validate user input for Age is in the acceptable range.
                                if (Age >= MIN_AGE && Age <= MAX_AGE)
                                {
                                    // Closes form.
                                    this.Close();
                                }

                                // Displays corresponding input error statement.
                                else
                                {
                                    MessageBox.Show("Please enter an integer between 12 and 120.", "Numeric Range Error");
                                    textBoxAge.Focus();
                                }
                            }

                            // Displays corresponding input error statement.
                            else
                            {
                                MessageBox.Show("Please enter an integer.", "INPUT ERROR!");
                                textBoxAge.Focus();
                            }
                        }

                        // Displays corresponding input error statement.
                        else
                        {
                            MessageBox.Show("Please enter an integer between 48 and 96.", "Numeric Range Error!");
                            textBoxHeight.Focus();
                        }
                    }

                    // Displays corresponding input error statement.
                    else
                    {
                        MessageBox.Show("Please enter an integer.", "INPUT ERROR!");
                        textBoxHeight.Focus();
                    }
                }

                // Displays corresponding input error statement.
                else
                {
                    MessageBox.Show("Please insert an integer between 50 and 1,000.", "Numeric Range Error!");
                    textBoxWeight.Focus();
                }
            }

            // Displays corresponding input error statement.
            else
            {
                MessageBox.Show("Please insert an integer.", "INPUT ERROR!");
                textBoxWeight.Focus();
            }
        }

        /// <summary>
        /// Click event to show picBoxBefore and hide picBoxAfter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBefore_Click(object sender, EventArgs e)
        {
            //Set picBoxBefore visible property to true
            picBoxBefore.Visible = (true);

            //Set picBoxAfter visible property to false
            picBoxAfter.Visible = (false);
        }

        /// <summary>
        /// Click event to show picBoxAfter and hid picBoxBefore.
        /// Also shows a congratulatory message when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfter_Click(object sender, EventArgs e)
        {
            //Set picBoxAfter visible property to true.
            picBoxAfter.Visible = (true);

            //Set picBoxBefore visible property to false.
            picBoxBefore.Visible = (false);

            //Show message box with congratulatory message.
            MessageBox.Show("Congratulations! You're making waves, continue strong and keep that girl in mind!");
        }

        /// <summary>
        /// Click event to clear all user input in MyProfileForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // Clear textboxes.
            textBoxWeight.Clear();
            textBoxHeight.Clear();
            textBoxAge.Clear();

            // Set public int values to 0.
            Weight = 0;
            Height = 0;
            Age = 0;

            // Prevent form from closing when click event is initiated. (Cancel button property tries to close form).
            this.DialogResult = DialogResult.None;
        }
    }
}
