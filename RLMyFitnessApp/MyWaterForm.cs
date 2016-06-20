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
using System.IO;

namespace RLMyFitnessApp
{
    public partial class MyWaterForm : Form
    {
        // Constant integer for 8oz
        const int WATER_GOAL = 8;

        public MyWaterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method for making the saved MyWater filename
        /// </summary>
        /// <returns></returns>
        public string GetFileName()
        {
            // Declare string with todays date stored in it.
            string today = DateTime.Now.ToString("d");

            // Replace the / in the date with _
            today = today.Replace('/', '_');

            // Concatenate the string to produce the filename
            string filename = today + "water" + ".txt";

            // Return filename
            return filename;
        }

        /// <summary>
        /// Method to hide all water pic boxes
        /// </summary>
        public void HideWater()
        {
            // Hide all water picture boxes
            picBoxWater1.Hide();
            picBoxWater2.Hide();
            picBoxWater3.Hide();
            picBoxWater4.Hide();
            picBoxWater5.Hide();
            picBoxWater6.Hide();
            picBoxWater7.Hide();
            picBoxWater8.Hide();
        }

        /// <summary>
        /// Method to show water in pic boxes
        /// </summary>
        public void ShowWater(int show)
        {
            // Switch statement to show water picboxes
            switch (show)
            {
                case 1:
                    picBoxWater1.Show();
                    break;
                case 2:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    break;
                case 3:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    break;
                case 4:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    break;
                case 5:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    break;
                case 6:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    break;
                case 7:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Show();
                    break;
                case 8:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Show();
                    picBoxWater8.Show();
                    break;
            }
        }

        /// <summary>
        /// Method to read water count and write to file
        /// </summary>
        public void ReadWater(ref int count)
        {
            // Try to get file name
            try
            {
                // Call GetFileName method
                string filename = GetFileName();

                // Declare stream reader variable
                StreamReader openfile;

                // If there is a text file for today
                if (File.Exists(filename))
                {
                    // Open text file
                    openfile = File.OpenText(filename);

                    // While loop to read through water count
                    while (!openfile.EndOfStream)
                    {
                        // Read from open file and add to a string
                        String line = openfile.ReadLine();

                        // TryParse string as int
                        int.TryParse(line, out count);

                        // Assign int to lbl result
                        lblResult.Text = count.ToString();
                    }
                    
                    // Close openfile
                    openfile.Close();
                }

                // Show message box
                else
                {
                    // Message box display
                    MessageBox.Show("No file for today!","No File");
                }

            }

            // Catch any errors
            catch (Exception ex)
            {
                // Show message box
                MessageBox.Show("Sorry, there was a read error. \n\nCode: " + ex.Message, "Read Error!");
            }
        }

        /// <summary>
        /// Method to determine count of water to write to file
        /// </summary>
        /// <param name="write"></param>
        public void WriteWater(int count)
        {
            // Try to write to text file
            try
            {
                // Call GetFile method and set it to a string variable
                string filename = GetFileName();

                // Call stream writer variable and create a txt file
                StreamWriter outputFile;

                // Create file to write text to
                outputFile = File.CreateText(filename);

                // WriteLine to txt file
                outputFile.WriteLine(count);

                // Close text file
                outputFile.Close();
            }

            // Else show error message
            catch (Exception ex)
            {
                // Show message box
                MessageBox.Show("Sorry, there was a write error. \n\nCode: " + ex.Message, "Write Error!");
            }
        }

        /// <summary>
        /// Sets what the form loads at the start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyWaterForm_Load(object sender, EventArgs e)
        {
            // Declare count variable and assign default value
            int count = 0;

            // Display date on lblDate
            lblDate.Text = DateTime.Now.ToString("d");

            // Call hidewater method to hide the pictureboxes
            HideWater();

            // Call readwater method to read from existing file and reference count
            ReadWater(ref count);

            // Call showwater method
            ShowWater(count);
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

        /// <summary>
        /// Click event to add water count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Declare water variable
            int water;

            // If lblResult is a int and < Water_Goal
            if (int.TryParse(lblResult.Text, out water) && water < WATER_GOAL)
            {
                // Plus 1 to water
                water++;

                // Display water on lblResult
                lblResult.Text = water.ToString();

                // Call writewater method
                WriteWater(water);

                // Call show water method
                ShowWater(water);
            }
        }
    }
}
