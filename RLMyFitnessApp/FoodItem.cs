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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLMyFitnessApp
{
    class FoodItem
    {
        // Private backing fields
        private string _foodName;
        private int _calories;
        private double _servings;
        private int _totalFat;
        private int _protein;
        private int _sugars;
        private int _fiber;

        /// <summary>
        /// Default constructor
        /// </summary>
        public FoodItem()
        {
            // Set default values for backing fields
            _foodName = "";
            _calories = 0;
            _servings = 0.0;
            _totalFat = 0;
            _protein = 0; 
            _sugars = 0;
            _fiber = 0;
        }

        /// <summary>
        /// Multi argument constructor to pass user input to backing field properties
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="calories"></param>
        /// <param name="servings"></param>
        /// <param name="totalFat"></param>
        /// <param name="protein"></param>
        /// <param name="sugars"></param>
        /// <param name="fiber"></param>
        public FoodItem(string foodName, int calories, double servings, int totalFat, int protein, int sugars, int fiber)
        {
            // Recieve parameter values for backing fields
            _foodName = foodName;
            _calories = calories;
            _servings = servings;
            _totalFat = totalFat;
            _protein = protein;
            _sugars = sugars;
            _fiber = fiber;
        }

        // Variable to get and set foodName
        public string FoodName
        {
            // Get statement
            get { return _foodName; }

            // Set statement
            set { _foodName = value; }
        }

        // Variable to get and set calories
        public int Calories
        {
            // Get statement
            get { return _calories; }

            // Set statement
            set { _calories = value; }
        }

        // Variable to get and set servings
        public double Servings
        {
            // Get statement
            get { return _servings; }

            // Set statement
            set { _servings = value; }
        }

        // Variable to get and set totalFat
        public int TotalFat
        {
            // Get statement
            get { return _totalFat; }

            // Set statement
            set { _totalFat = value; }
        }

        // Variable to get and set protein
        public int Protein
        {
            // Get statement
            get { return _protein; }

            // Set statement
            set { _protein = value; }
        }

        // Variable to get and set sugars
        public int Sugars
        {
            // Get statement
            get { return _sugars; }

            // Set statement
            set { _sugars = value; }
        }

        // Variable to get and set fiber
        public int Fiber
        {
            // Get statement
            get { return _fiber; }

            // Set statement
            set { _fiber = value; }
        }

        // Method to create a temporary string with backing fields
        public string foodItem()
        {
            // Declare string
            string foodItem;

            // Concatenate string with backing fields
            foodItem = FoodName +"," + Calories + "," + Servings + "," + TotalFat + "," + Protein + "," + Sugars + "," + Fiber;

            // Return foodItem variable
            return foodItem;
        }

        // Array for containing a string of food items.
        public FoodItem(string[ ] foodArray)
        {
            // Use backing fields to set values to be added to the array.
            _foodName = foodArray[0].ToString();
            _calories = int.Parse(foodArray[1]);
            _servings = double.Parse(foodArray[2]);
            _totalFat = int.Parse(foodArray[3]);
            _protein = int.Parse(foodArray[4]);
            _sugars = int.Parse(foodArray[5]);
            _fiber = int.Parse(foodArray[6]);
        }
    }
}
