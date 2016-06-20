namespace RLMyFitnessApp
{
    partial class MainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.lblToday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnMyBmr = new System.Windows.Forms.Button();
            this.btnMyTimer = new System.Windows.Forms.Button();
            this.btnMyExerciseLog = new System.Windows.Forms.Button();
            this.btnMyWater = new System.Windows.Forms.Button();
            this.btnMyFood = new System.Windows.Forms.Button();
            this.btnMealPlanner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tempus Sans ITC", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(11, 21);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(212, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back Rex!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(224, 240);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.AutoSize = true;
            this.btnMyProfile.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.Location = new System.Drawing.Point(34, 121);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(99, 28);
            this.btnMyProfile.TabIndex = 1;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // lblToday
            // 
            this.lblToday.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(13, 69);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(125, 35);
            this.lblToday.TabIndex = 4;
            this.lblToday.Text = "Today is:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(90, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(178, 35);
            this.lblDate.TabIndex = 6;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMyBmr
            // 
            this.btnMyBmr.AutoSize = true;
            this.btnMyBmr.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBmr.Location = new System.Drawing.Point(34, 155);
            this.btnMyBmr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyBmr.Name = "btnMyBmr";
            this.btnMyBmr.Size = new System.Drawing.Size(99, 28);
            this.btnMyBmr.TabIndex = 2;
            this.btnMyBmr.Text = "My BMR";
            this.btnMyBmr.UseVisualStyleBackColor = true;
            this.btnMyBmr.Click += new System.EventHandler(this.btnMyBmr_Click);
            // 
            // btnMyTimer
            // 
            this.btnMyTimer.AutoSize = true;
            this.btnMyTimer.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyTimer.Location = new System.Drawing.Point(34, 189);
            this.btnMyTimer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyTimer.Name = "btnMyTimer";
            this.btnMyTimer.Size = new System.Drawing.Size(99, 28);
            this.btnMyTimer.TabIndex = 7;
            this.btnMyTimer.Text = "My Timer";
            this.btnMyTimer.UseVisualStyleBackColor = true;
            this.btnMyTimer.Click += new System.EventHandler(this.btnMyTimer_Click);
            // 
            // btnMyExerciseLog
            // 
            this.btnMyExerciseLog.AutoSize = true;
            this.btnMyExerciseLog.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyExerciseLog.Location = new System.Drawing.Point(149, 155);
            this.btnMyExerciseLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyExerciseLog.Name = "btnMyExerciseLog";
            this.btnMyExerciseLog.Size = new System.Drawing.Size(99, 28);
            this.btnMyExerciseLog.TabIndex = 9;
            this.btnMyExerciseLog.Text = "My Exercise";
            this.btnMyExerciseLog.UseVisualStyleBackColor = true;
            this.btnMyExerciseLog.Click += new System.EventHandler(this.btnMyExerciseLog_Click);
            // 
            // btnMyWater
            // 
            this.btnMyWater.AutoSize = true;
            this.btnMyWater.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyWater.Location = new System.Drawing.Point(149, 121);
            this.btnMyWater.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyWater.Name = "btnMyWater";
            this.btnMyWater.Size = new System.Drawing.Size(99, 28);
            this.btnMyWater.TabIndex = 10;
            this.btnMyWater.Text = "My Water";
            this.btnMyWater.UseVisualStyleBackColor = true;
            this.btnMyWater.Click += new System.EventHandler(this.btnMyWater_Click);
            // 
            // btnMyFood
            // 
            this.btnMyFood.AutoSize = true;
            this.btnMyFood.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyFood.Location = new System.Drawing.Point(149, 189);
            this.btnMyFood.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyFood.Name = "btnMyFood";
            this.btnMyFood.Size = new System.Drawing.Size(99, 28);
            this.btnMyFood.TabIndex = 11;
            this.btnMyFood.Text = "My Food";
            this.btnMyFood.UseVisualStyleBackColor = true;
            this.btnMyFood.Click += new System.EventHandler(this.btnMyFood_Click);
            // 
            // btnMealPlanner
            // 
            this.btnMealPlanner.AutoSize = true;
            this.btnMealPlanner.Font = new System.Drawing.Font("Tempus Sans ITC", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealPlanner.Location = new System.Drawing.Point(34, 240);
            this.btnMealPlanner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMealPlanner.Name = "btnMealPlanner";
            this.btnMealPlanner.Size = new System.Drawing.Size(135, 28);
            this.btnMealPlanner.TabIndex = 13;
            this.btnMealPlanner.Text = "My Meal Planner";
            this.btnMealPlanner.UseVisualStyleBackColor = true;
            this.btnMealPlanner.Click += new System.EventHandler(this.btnMealPlanner_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(280, 280);
            this.Controls.Add(this.btnMealPlanner);
            this.Controls.Add(this.btnMyFood);
            this.Controls.Add(this.btnMyWater);
            this.Controls.Add(this.btnMyExerciseLog);
            this.Controls.Add(this.btnMyTimer);
            this.Controls.Add(this.btnMyBmr);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Impact", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "My Fitness App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnMyBmr;
        private System.Windows.Forms.Button btnMyTimer;
        private System.Windows.Forms.Button btnMyExerciseLog;
        private System.Windows.Forms.Button btnMyWater;
        private System.Windows.Forms.Button btnMyFood;
        private System.Windows.Forms.Button btnMealPlanner;
    }
}

