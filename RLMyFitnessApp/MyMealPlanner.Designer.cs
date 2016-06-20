namespace RLMyFitnessApp
{
    partial class MyMealPlanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTodayIs = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDailyCal = new System.Windows.Forms.Label();
            this.lblCalorieCount = new System.Windows.Forms.Label();
            this.listBoxMeal = new System.Windows.Forms.ListBox();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblItemCalories = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.btnAddToMeal = new System.Windows.Forms.Button();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblSnack = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBoxBreakfast = new System.Windows.Forms.ListBox();
            this.listBoxLunch = new System.Windows.Forms.ListBox();
            this.listBoxDinner = new System.Windows.Forms.ListBox();
            this.listBoxSnacks = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTodayIs
            // 
            this.lblTodayIs.Location = new System.Drawing.Point(12, 9);
            this.lblTodayIs.Name = "lblTodayIs";
            this.lblTodayIs.Size = new System.Drawing.Size(55, 23);
            this.lblTodayIs.TabIndex = 0;
            this.lblTodayIs.Text = "Today is:";
            this.lblTodayIs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(73, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 1;
            // 
            // lblDailyCal
            // 
            this.lblDailyCal.Location = new System.Drawing.Point(196, 9);
            this.lblDailyCal.Name = "lblDailyCal";
            this.lblDailyCal.Size = new System.Drawing.Size(101, 23);
            this.lblDailyCal.TabIndex = 4;
            this.lblDailyCal.Text = "Daily Calorie Count:";
            this.lblDailyCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalorieCount
            // 
            this.lblCalorieCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalorieCount.Location = new System.Drawing.Point(304, 9);
            this.lblCalorieCount.Name = "lblCalorieCount";
            this.lblCalorieCount.Size = new System.Drawing.Size(100, 23);
            this.lblCalorieCount.TabIndex = 5;
            // 
            // listBoxMeal
            // 
            this.listBoxMeal.FormattingEnabled = true;
            this.listBoxMeal.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.listBoxMeal.Location = new System.Drawing.Point(15, 68);
            this.listBoxMeal.Name = "listBoxMeal";
            this.listBoxMeal.Size = new System.Drawing.Size(69, 108);
            this.listBoxMeal.TabIndex = 6;
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(127, 68);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(150, 108);
            this.listBoxItem.TabIndex = 7;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Location = new System.Drawing.Point(12, 52);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(102, 13);
            this.lblMeal.TabIndex = 8;
            this.lblMeal.Text = "Select a Meal Type:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(124, 52);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(99, 13);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Select a Food Item:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New Food to List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblItemCalories
            // 
            this.lblItemCalories.AutoSize = true;
            this.lblItemCalories.Location = new System.Drawing.Point(301, 52);
            this.lblItemCalories.Name = "lblItemCalories";
            this.lblItemCalories.Size = new System.Drawing.Size(102, 13);
            this.lblItemCalories.TabIndex = 11;
            this.lblItemCalories.Text = "Item\'s Caloric Value:";
            // 
            // lblCalories
            // 
            this.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalories.Location = new System.Drawing.Point(304, 68);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(99, 23);
            this.lblCalories.TabIndex = 12;
            // 
            // btnAddToMeal
            // 
            this.btnAddToMeal.Location = new System.Drawing.Point(305, 94);
            this.btnAddToMeal.Name = "btnAddToMeal";
            this.btnAddToMeal.Size = new System.Drawing.Size(99, 53);
            this.btnAddToMeal.TabIndex = 13;
            this.btnAddToMeal.Text = "Add to Meal";
            this.btnAddToMeal.UseVisualStyleBackColor = true;
            this.btnAddToMeal.Click += new System.EventHandler(this.btnAddToMeal_Click);
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(83, 194);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(52, 13);
            this.lblBreakfast.TabIndex = 14;
            this.lblBreakfast.Text = "Breakfast";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(291, 194);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(37, 13);
            this.lblLunch.TabIndex = 15;
            this.lblLunch.Text = "Lunch";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(90, 326);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(38, 13);
            this.lblDinner.TabIndex = 16;
            this.lblDinner.Text = "Dinner";
            // 
            // lblSnack
            // 
            this.lblSnack.AutoSize = true;
            this.lblSnack.Location = new System.Drawing.Point(288, 326);
            this.lblSnack.Name = "lblSnack";
            this.lblSnack.Size = new System.Drawing.Size(43, 13);
            this.lblSnack.TabIndex = 17;
            this.lblSnack.Text = "Snacks";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(343, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBoxBreakfast
            // 
            this.listBoxBreakfast.FormattingEnabled = true;
            this.listBoxBreakfast.Location = new System.Drawing.Point(15, 210);
            this.listBoxBreakfast.Name = "listBoxBreakfast";
            this.listBoxBreakfast.Size = new System.Drawing.Size(188, 95);
            this.listBoxBreakfast.TabIndex = 19;
            // 
            // listBoxLunch
            // 
            this.listBoxLunch.FormattingEnabled = true;
            this.listBoxLunch.Location = new System.Drawing.Point(215, 210);
            this.listBoxLunch.Name = "listBoxLunch";
            this.listBoxLunch.Size = new System.Drawing.Size(188, 95);
            this.listBoxLunch.TabIndex = 20;
            // 
            // listBoxDinner
            // 
            this.listBoxDinner.FormattingEnabled = true;
            this.listBoxDinner.Location = new System.Drawing.Point(15, 342);
            this.listBoxDinner.Name = "listBoxDinner";
            this.listBoxDinner.Size = new System.Drawing.Size(188, 95);
            this.listBoxDinner.TabIndex = 21;
            // 
            // listBoxSnacks
            // 
            this.listBoxSnacks.FormattingEnabled = true;
            this.listBoxSnacks.Location = new System.Drawing.Point(215, 342);
            this.listBoxSnacks.Name = "listBoxSnacks";
            this.listBoxSnacks.Size = new System.Drawing.Size(188, 95);
            this.listBoxSnacks.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(294, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(43, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyMealPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 491);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBoxSnacks);
            this.Controls.Add(this.listBoxDinner);
            this.Controls.Add(this.listBoxLunch);
            this.Controls.Add(this.listBoxBreakfast);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSnack);
            this.Controls.Add(this.lblDinner);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblBreakfast);
            this.Controls.Add(this.btnAddToMeal);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblItemCalories);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.listBoxMeal);
            this.Controls.Add(this.lblCalorieCount);
            this.Controls.Add(this.lblDailyCal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTodayIs);
            this.Name = "MyMealPlanner";
            this.Text = "MyMealPlanner";
            this.Load += new System.EventHandler(this.MyMealPlanner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTodayIs;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDailyCal;
        private System.Windows.Forms.Label lblCalorieCount;
        private System.Windows.Forms.ListBox listBoxMeal;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblItemCalories;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Button btnAddToMeal;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblSnack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBoxBreakfast;
        private System.Windows.Forms.ListBox listBoxLunch;
        private System.Windows.Forms.ListBox listBoxDinner;
        private System.Windows.Forms.ListBox listBoxSnacks;
        private System.Windows.Forms.Button btnClear;
    }
}