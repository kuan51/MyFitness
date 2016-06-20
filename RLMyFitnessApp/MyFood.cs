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
    public partial class MyFood : Form
    {
        // Variable for Food Items txt file
        string foodFileName = "fooditems.txt";

        public MyFood()
        {
            InitializeComponent();
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
        /// Click event to add food to listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Decalre Bool variable for if statement
            bool correctInput;

            // Create new instance of FoodItem
            FoodItem profile = new FoodItem();

            // Call check food method
            correctInput = CheckFood(profile);

            // If input is correct, add to list box
            if(correctInput)
            {
                // Add validated string to list box
                listBoxFood.Items.Add(profile.foodItem());

                // CLear textBoxes
                ClearTxtBoxes();
            }

            // Else show MessageBox
            else
            {
                // Show message box
                MessageBox.Show("Please fill in all fields with the correct values.", "Missing/Incorrect Fields!");
            }
        }

        /// <summary>
        /// Method to validate user input in MyFood
        /// </summary>
        private bool CheckFood(FoodItem foodItem)
        {
            // Reset Back Color of textboxes
            BackColorReset();

            // Declare temp variables
            int calories;
            double servings;
            int fat;
            int fiber;
            int sugar;
            int protein;

            // If txtBoxFood is not empty
            if (txtBoxFood.Text != "")
            {
                // Set txtbox input to backing field property
                foodItem.FoodName = txtBoxFood.Text;
            }

            // Else
            else
            {
                // Set focus to FoodName txtbox
                txtBoxFood.Focus();

                // Set txtbox back color to indicate error
                txtBoxFood.BackColor = System.Drawing.Color.Salmon;

                // Return false
                return false;
            }

            // Validate calories
            if (int.TryParse(txtBoxCalories.Text, out calories))
            {
                // Set value of calories
                foodItem.Calories = calories;
            }

            // Else
            else
            {
                // Set focus to calories txtbox
                txtBoxCalories.Focus();

                // Set txt box back color for error
                txtBoxCalories.BackColor = System.Drawing.Color.Salmon;

                // Return false
                return false;
            }
            
            // Validate servings
            if (double.TryParse(txtBoxServings.Text, out servings) && servings > 0)
            {
                // Set backing field property to txt box input
                foodItem.Servings = servings;
            }

            //Else
            else
            {
                // Set focus to sevings txtbox
                txtBoxServings.Focus();

                // Set error color for savings txtbox
                txtBoxServings.BackColor = System.Drawing.Color.Salmon;

                // Return false
                return false;
            }

            // Validate fat
            if (int.TryParse(txtBoxFat.Text, out fat))
            {
                // Set fat variable
                foodItem.TotalFat = fat;
            }

            // Else
            else
            {
                // Set focus to fat txtbox
                txtBoxFat.Focus();

                // Set fat back color
                txtBoxFat.BackColor = System.Drawing.Color.Salmon;

                // Return false
                return false;
            }

            // Validate protein
            if (int.TryParse(txtBoxProtein.Text, out protein))
            {
                // Set protein variable
                foodItem.Protein = protein;
            }

            // Else return false
            else
            {
                // Set txtbox focus for protein
                txtBoxProtein.Focus();

                // Set backcolor
                txtBoxProtein.BackColor = System.Drawing.Color.Salmon;

                // Return false
                return false;
            }

            // Validate sugar
            if (int.TryParse(txtBoxSugar.Text, out sugar))
            {
                // Set sugar variable
                foodItem.Sugars = sugar;
            }

            // Else return false
            else
            {
                // Set txtbox focus for sugar
                txtBoxSugar.Focus();

                // Set backcolor for error
                txtBoxSugar.BackColor = System.Drawing.Color.Salmon;

                // Return false
                return false;
            }

            // Validate fiber
            if (int.TryParse(txtBoxFiber.Text, out fiber))
            {
                // Set fiber variable
                foodItem.Fiber = fiber;

                // Return true
                return true;
            }

            // Else return false
            else
            {
                // Set focus to fiber
                txtBoxFiber.Focus();

                // Set backcolor for error
                txtBoxFiber.BackColor = System.Drawing.Color.Salmon;

                // Return false
                return false;
            }
        }

        /// <summary>
        /// Click event to clear list box and text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear list box items
            listBoxFood.Items.Clear();

            // Call ClearTextBoxes method
            ClearTxtBoxes();

            // Reset textbox Back Color
            BackColorReset();
        }

        /// <summary>
        /// Custom method to clear textboxes
        /// </summary>
        private void ClearTxtBoxes()
        {
            // Clear textboxes
            txtBoxFood.Clear();
            txtBoxServings.Clear();
            txtBoxCalories.Clear();
            txtBoxFat.Clear();
            txtBoxProtein.Clear();
            txtBoxSugar.Clear();
            txtBoxFiber.Clear();
        }

        /// <summary>
        /// Custom method to reset the back color of textboxes
        /// </summary>
        private void BackColorReset()
        {
            // Reset textbox's back color
            txtBoxFood.BackColor = System.Drawing.Color.White;
            txtBoxServings.BackColor = System.Drawing.Color.White;
            txtBoxCalories.BackColor = System.Drawing.Color.White;
            txtBoxFat.BackColor = System.Drawing.Color.White;
            txtBoxProtein.BackColor = System.Drawing.Color.White;
            txtBoxSugar.BackColor = System.Drawing.Color.White;
            txtBoxFiber.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Click event to save meal to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare stream writer variable
                StreamWriter saveFile;

                // Create file
                saveFile = File.CreateText(foodFileName);

                // For Loop through items in FoodList and write to file
                for (int i = 0; i < listBoxFood.Items.Count; i++)
                {
                    saveFile.WriteLine(listBoxFood.Items[i].ToString());
                }

                // Close saveFile
                saveFile.Close();

                // Close form
                this.Close();
            }           
            // Catch any failure to create new txt file.
            catch (Exception)
            {
                // Display message box error
                MessageBox.Show("There was an error while creating the file. Error: /n/nCode");
            }
        }

        /// <summary>
        /// Form load event to open any existing file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyFood_Load(object sender, EventArgs e)
        {
            // Try to open file
            try
            {
                // Declare stream reader variable
                StreamReader openFile;

                // Open foodFileName
                openFile = File.OpenText(foodFileName);

                // Clear listbox
                listBoxFood.Items.Clear();

                // While loop to add open file to listbox
                while (!openFile.EndOfStream)
                {
                    listBoxFood.Items.Add(openFile.ReadLine());
                }

                // CLose openFile
                openFile.Close();
            }
            // Error messae for failed open
            catch (Exception)
            {
                // Show message box error
                MessageBox.Show("Sorry, there was an error loading the file. Error: /n/nCode");
            }
        }
    }
}
