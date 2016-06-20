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
    public partial class MyExerciseLogForm : Form
    {
        string currentFile;

        public MyExerciseLogForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load operations to set time, open a file, and add it to the log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyExerciseLogForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Call the current date
                DateTime.Now.ToString("d");

                // Display date
                lblDate.Text = DateTime.Now.ToString("d");

                // Create StreamReader inputfile object
                StreamReader inputFile;

                // Set current file to an empty string
                currentFile = "";

                // Clear the items in the log
                lstBoxLog.Items.Clear();

                // If statement to open a file
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // Use StreamReader inputfile to open text
                    inputFile = File.OpenText(openFile.FileName);

                    // Set current file
                    currentFile = openFile.FileName; 
                                       
                    // Loop through file and add each line of text to the log
                    while (!inputFile.EndOfStream)
                    {
                        lstBoxLog.Items.Add(inputFile.ReadLine());
                    }
                    // Close file
                    inputFile.Close();
                }
                
                // Else statement to handle errors.
                else
                {
                    // Show dialog
                    MessageBox.Show("Process terminated.", "Canceled");
                }
            }

            // Catch statement to handle file open errors
            catch (Exception ex)
            {
                // Display open file error
                MessageBox.Show("Error reading file. \n\nCode: " + ex.Message, "Read Error!");
            }
        }

        /// <summary>
        /// Click event to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        /// <summary>
        /// Click event to add an exercise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If exercise, duration, and calories are not empty.
            if (txtBoxCalories.Text != "" && txtBoxDuration.Text != "" && txtBoxExercise.Text != "")
            {
                // Create a single log string
                string exercise = DateTime.Now.ToString("M/d/yyyy") + "     " + txtBoxExercise.Text + ", " + txtBoxDuration.Text + ", " + txtBoxCalories.Text;

                // Add string to log list box
                lstBoxLog.Items.Add(exercise);
            }

            // Else give error
            else
            {
                // Display error message
                MessageBox.Show("Please add values to all textboxes.", "Field Missing!");

                // Clear textboxes
                txtBoxCalories.Clear();
                txtBoxDuration.Clear();
                txtBoxExercise.Clear();

                // Place focus back to exercise textbox
                txtBoxExercise.Focus();
            }    
        }

        /// <summary>
        /// Click event to save log to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Declare StreamWriter object
            StreamWriter outputFile;

            // Try to write file
            try
            {
                // If current file is > 0
                if (currentFile.Length > 0)
                {
                   // Create output file using current file
                   outputFile = File.CreateText(currentFile);

                    // Loop through current file and write lines to output file
                    for (int i = 0; i < lstBoxLog.Items.Count; i++)
                    {
                        outputFile.WriteLine(lstBoxLog.Items[i].ToString());
                    }

                    // Close text file
                    outputFile.Close();
                }

                // Else open save dialog for user to save file
                else
                {
                    // If save file dialog is equal to dialog result
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        // Open output file object with create text
                        outputFile = File.CreateText(saveFile.FileName);

                        // Set currentFile to = savefile dialog
                        currentFile = saveFile.FileName;

                        // Loop through each line and write to file
                        for (int i = 0; i < lstBoxLog.Items.Count; i++)
                        {
                            outputFile.WriteLine(lstBoxLog.Items[i].ToString());
                        }

                        // Close text file
                        outputFile.Close();
                    }

                    // Else show error message
                    else
                    {
                        // Display message box dialog
                        MessageBox.Show("Cannot save file.", "Not Saved");
                    } 
                }
            }
            
            // Display error message.
            catch (Exception ex)
            {
                // Display message box dialog
                MessageBox.Show("Save canceled. \n\nCode: " + ex.Message, "Save Error!");
            }
        }
    }
}