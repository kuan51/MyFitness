namespace RLMyFitnessApp
{
    partial class MyBMRForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblMyBMR = new System.Windows.Forms.Label();
            this.lblActivityLevel = new System.Windows.Forms.Label();
            this.btnCalcBmr = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBmrResult = new System.Windows.Forms.Label();
            this.listBoxActivity = new System.Windows.Forms.ListBox();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMyBMR
            // 
            this.lblMyBMR.AutoSize = true;
            this.lblMyBMR.Location = new System.Drawing.Point(107, 139);
            this.lblMyBMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyBMR.Name = "lblMyBMR";
            this.lblMyBMR.Size = new System.Drawing.Size(51, 13);
            this.lblMyBMR.TabIndex = 0;
            this.lblMyBMR.Text = "My BMR:";
            // 
            // lblActivityLevel
            // 
            this.lblActivityLevel.AutoSize = true;
            this.lblActivityLevel.Location = new System.Drawing.Point(11, 9);
            this.lblActivityLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivityLevel.Name = "lblActivityLevel";
            this.lblActivityLevel.Size = new System.Drawing.Size(122, 13);
            this.lblActivityLevel.TabIndex = 1;
            this.lblActivityLevel.Text = "Choose an activity level:";
            // 
            // btnCalcBmr
            // 
            this.btnCalcBmr.Location = new System.Drawing.Point(14, 132);
            this.btnCalcBmr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcBmr.Name = "btnCalcBmr";
            this.btnCalcBmr.Size = new System.Drawing.Size(60, 27);
            this.btnCalcBmr.TabIndex = 1;
            this.btnCalcBmr.Text = "Calculate";
            this.btnCalcBmr.UseVisualStyleBackColor = true;
            this.btnCalcBmr.Click += new System.EventHandler(this.btnCalcBmr_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(14, 167);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBmrResult
            // 
            this.lblBmrResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBmrResult.Location = new System.Drawing.Point(110, 167);
            this.lblBmrResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBmrResult.Name = "lblBmrResult";
            this.lblBmrResult.Size = new System.Drawing.Size(118, 27);
            this.lblBmrResult.TabIndex = 4;
            // 
            // listBoxActivity
            // 
            this.listBoxActivity.FormattingEnabled = true;
            this.listBoxActivity.Items.AddRange(new object[] {
            "Little to no exercise",
            "Light exercise (1-3 days per week)",
            "Moderate Exercise (3-5 days per week)",
            "Heavy Exercise (6-7 days per week)",
            "Very Intense (Twice per day)"});
            this.listBoxActivity.Location = new System.Drawing.Point(12, 32);
            this.listBoxActivity.Name = "listBoxActivity";
            this.listBoxActivity.Size = new System.Drawing.Size(216, 95);
            this.listBoxActivity.TabIndex = 6;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Checked = true;
            this.radioBtnMale.Location = new System.Drawing.Point(33, 19);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMale.TabIndex = 7;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(33, 42);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnFemale.TabIndex = 8;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioBtnFemale);
            this.groupBoxGender.Controls.Add(this.radioBtnMale);
            this.groupBoxGender.Location = new System.Drawing.Point(236, 27);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(123, 100);
            this.groupBoxGender.TabIndex = 9;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(233, 174);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(44, 13);
            this.lblCalories.TabIndex = 10;
            this.lblCalories.Text = "Calories";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyBMRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 207);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.listBoxActivity);
            this.Controls.Add(this.lblBmrResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalcBmr);
            this.Controls.Add(this.lblActivityLevel);
            this.Controls.Add(this.lblMyBMR);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MyBMRForm";
            this.Text = "My BMR";
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblMyBMR;
        private System.Windows.Forms.Label lblActivityLevel;
        private System.Windows.Forms.Button btnCalcBmr;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBmrResult;
        private System.Windows.Forms.ListBox listBoxActivity;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.Label lblCalories;
    }
}