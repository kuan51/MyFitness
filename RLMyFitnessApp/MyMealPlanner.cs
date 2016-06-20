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
    public partial class MyMealPlanner : Form
    {
        // Private array from foodItem class
        private FoodItem[] myfoods;

        // String variable for foodFileName
        string foodFileName = "fooditems.txt";

        public MyMealPlanner()
        {
            InitializeComponent();

            // Create FoodItem array with a size of 1000
            myfoods = new FoodItem[1000];
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
        /// Method to load food items for meals
        /// </summary>
        private void LoadFoods()
        {
            // Varibale for foodItem
            string foodItem = "";

            // Variable for the index
            int index = 0;

            // Variable for the food array to split the files
            string[] splitFoodArray;

            // Try to open text from file
            try
            {
                // Declare stream reader variable
                StreamReader openFile;

                // Use open file to open text
                openFile = File.OpenText(foodFileName);

                // While not at the end of openfile
                while (!openFile.EndOfStream)
                {
                    // Use open file to read each line and assign to foodItem
                    foodItem = openFile.ReadLine();

                    // Split the read data on the commas
                    splitFoodArray = foodItem.Split(',');
                    
                    // Add the 0 index to the listbox                    
                    listBoxItem.Items.Add(splitFoodArray[0]);

                    // Increase the index by one and take string and pass it
                    myfoods[index++] = new FoodItem(splitFoodArray);                    
                }
                // Close openFile
                openFile.Close();
            }
            // Catch any exceptions
            catch (Exception ex)
            {
                // Show message box
                MessageBox.Show("Sorry, there was an error reading from file. \n\nCode: " + ex.Message);
            }
        }

        /// <summary>
        /// Load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyMealPlanner_Load(object sender, EventArgs e)
        {
            // Set calorie count to 0
            lblCalorieCount.Text = "0";

            // Display todays date on lblDate
            lblDate.Text = DateTime.Now.ToString("d");

            // Call LoadFoods method
            LoadFoods();
        }

        /// <summary>
        /// Shows calories of selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If there is a selected item in the listbox
            if (listBoxItem.SelectedIndex != -1)
            {
                // Set index variable to match the selected index in the listbox
                int index = listBoxItem.SelectedIndex;

                // Set calories label to show the calories of the selected index
                lblCalories.Text = myfoods[index].Calories.ToString();
            }
        }

        /// <summary>
        /// Click event to add selected items to the relative meal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToMeal_Click(object sender, EventArgs e)
        {
            // If listBoxItem has a selection
            if (listBoxItem.SelectedIndex != -1)
            {
                // If listBoxMeal has a selection
                if (listBoxMeal.SelectedIndex != -1)
                {
                    // Index variable for listBoxItems selected index
                    int index = listBoxItem.SelectedIndex;

                    // Try to convert Calorie Count string to int
                    try
                    {
                        // Set value variable for counting calories.
                        int value = int.Parse(lblCalorieCount.Text);

                        // Case statements for adding selected indexes to the correct meal listbox
                        switch (listBoxMeal.SelectedIndex)
                        {
                            case 0:
                                listBoxBreakfast.Items.Add(listBoxItem.SelectedItem + " for " + myfoods[index].Calories.ToString());
                                break;
                            case 1:
                                listBoxLunch.Items.Add(listBoxItem.SelectedItem + " for " + myfoods[index].Calories.ToString());
                                break;
                            case 2:
                                listBoxDinner.Items.Add(listBoxItem.SelectedItem + " for " + myfoods[index].Calories.ToString());
                                break;
                            case 3:
                                listBoxSnacks.Items.Add(listBoxItem.SelectedItem + " for " + myfoods[index].Calories.ToString());
                                break;
                        }

                        // Try to convert lblCalories string to int
                        try
                        {
                            // Set value to increment on lblCalories
                            value += int.Parse(lblCalories.Text);

                            // Set CalorieCount to equal 
                            lblCalorieCount.Text = value.ToString();
                        }
                        // Catch any errors converting lblCalories to int
                        catch (Exception ex)
                        {
                            MessageBox.Show("Could not convert the items calorie count to an integer. \n\nCode: " + ex.Message);
                        }

                    }
                    // Catch errors converting Calorie Count string to int
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not convert Calorie Count to an integer. \n\nCode: " + ex.Message);
                    }
                }
                // Else ask to select a meal
                else
                {
                    MessageBox.Show("Please select a meal.","No meal selected.");
                }
            }
            // Else ask to select a item
            else
            {
                MessageBox.Show("Please select a food item from the list.","No item selected.");
            }
        }

        /// <summary>
        /// CLick event to add a new food item to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create new object of MyFood
            MyFood foodForm = new MyFood();

            // Display MyFood form
            foodForm.ShowDialog();

            // Clear listBoxItem
            listBoxItem.Items.Clear();

            // Call loadFoods method
            LoadFoods();
        }

        /// <summary>
        /// Click event to clear all user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear daily calorie count
            lblCalorieCount.Text = "0";

            // Clear selected item value
            lblCalories.Text = "";

            // Deselect and/or clear listboxes
            listBoxItem.ClearSelected();
            listBoxMeal.ClearSelected();
            listBoxBreakfast.Items.Clear();
            listBoxLunch.Items.Clear();
            listBoxDinner.Items.Clear();
            listBoxSnacks.Items.Clear();
        }

        // Method to create the file name for saving the meals
        private string MealFileName()
        {
            // Get todays date and add it to a string
            string date = DateTime.Now.ToString("d");

            // Replace the / in date with _
            date = date.Replace('/','_');

            // Declare string for file name
            string fileName = "Meals for " + date + ".txt";

            // Return fileName
            return fileName;
        }
    }
}