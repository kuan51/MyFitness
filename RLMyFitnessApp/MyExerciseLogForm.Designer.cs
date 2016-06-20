namespace RLMyFitnessApp
{
    partial class MyExerciseLogForm
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.txtBoxCalories = new System.Windows.Forms.TextBox();
            this.txtBoxExercise = new System.Windows.Forms.TextBox();
            this.lblExercise = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lstBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(184, 41);
            this.lblDate.TabIndex = 0;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Exercise";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Exercises";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.Location = new System.Drawing.Point(223, 77);
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(112, 20);
            this.txtBoxDuration.TabIndex = 4;
            // 
            // txtBoxCalories
            // 
            this.txtBoxCalories.Location = new System.Drawing.Point(341, 77);
            this.txtBoxCalories.Name = "txtBoxCalories";
            this.txtBoxCalories.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCalories.TabIndex = 5;
            // 
            // txtBoxExercise
            // 
            this.txtBoxExercise.Location = new System.Drawing.Point(12, 77);
            this.txtBoxExercise.Name = "txtBoxExercise";
            this.txtBoxExercise.Size = new System.Drawing.Size(205, 20);
            this.txtBoxExercise.TabIndex = 6;
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Location = new System.Drawing.Point(12, 61);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(47, 13);
            this.lblExercise.TabIndex = 7;
            this.lblExercise.Text = "Exercise";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(220, 61);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(338, 61);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(44, 13);
            this.lblCalories.TabIndex = 9;
            this.lblCalories.Text = "Calories";
            // 
            // lstBoxLog
            // 
            this.lstBoxLog.FormattingEnabled = true;
            this.lstBoxLog.Location = new System.Drawing.Point(12, 103);
            this.lstBoxLog.Name = "lstBoxLog";
            this.lstBoxLog.Size = new System.Drawing.Size(428, 121);
            this.lstBoxLog.TabIndex = 10;
            // 
            // MyExerciseLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 267);
            this.Controls.Add(this.lstBoxLog);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblExercise);
            this.Controls.Add(this.txtBoxExercise);
            this.Controls.Add(this.txtBoxCalories);
            this.Controls.Add(this.txtBoxDuration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDate);
            this.Name = "MyExerciseLogForm";
            this.Text = "My Exercise Log";
            this.Load += new System.EventHandler(this.MyExerciseLogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxDuration;
        private System.Windows.Forms.TextBox txtBoxCalories;
        private System.Windows.Forms.TextBox txtBoxExercise;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.ListBox lstBoxLog;
    }
}