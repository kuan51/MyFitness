namespace RLMyFitnessApp
{
    partial class MyTimer
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
            this.grpBoxStopWatch = new System.Windows.Forms.GroupBox();
            this.grpBoxExerciseQueue = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.lblCurrentExercise = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblExercise = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtBoxExercise = new System.Windows.Forms.TextBox();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxRest = new System.Windows.Forms.TextBox();
            this.lstBoxTime = new System.Windows.Forms.ListBox();
            this.lstBoxExercise = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxStopWatch.SuspendLayout();
            this.grpBoxExerciseQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxStopWatch
            // 
            this.grpBoxStopWatch.Controls.Add(this.lblTimer);
            this.grpBoxStopWatch.Controls.Add(this.lblStopWatch);
            this.grpBoxStopWatch.Controls.Add(this.lblCurrentExercise);
            this.grpBoxStopWatch.Controls.Add(this.btnStart);
            this.grpBoxStopWatch.Controls.Add(this.btnClose);
            this.grpBoxStopWatch.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStopWatch.Name = "grpBoxStopWatch";
            this.grpBoxStopWatch.Size = new System.Drawing.Size(266, 368);
            this.grpBoxStopWatch.TabIndex = 0;
            this.grpBoxStopWatch.TabStop = false;
            this.grpBoxStopWatch.Text = "Workout Timer";
            // 
            // grpBoxExerciseQueue
            // 
            this.grpBoxExerciseQueue.Controls.Add(this.btnClear);
            this.grpBoxExerciseQueue.Controls.Add(this.btnSubmit);
            this.grpBoxExerciseQueue.Controls.Add(this.btnAdd);
            this.grpBoxExerciseQueue.Controls.Add(this.lstBoxExercise);
            this.grpBoxExerciseQueue.Controls.Add(this.lstBoxTime);
            this.grpBoxExerciseQueue.Controls.Add(this.txtBoxRest);
            this.grpBoxExerciseQueue.Controls.Add(this.txtBoxTime);
            this.grpBoxExerciseQueue.Controls.Add(this.txtBoxExercise);
            this.grpBoxExerciseQueue.Controls.Add(this.lblExercise);
            this.grpBoxExerciseQueue.Controls.Add(this.lblRest);
            this.grpBoxExerciseQueue.Controls.Add(this.lblTime);
            this.grpBoxExerciseQueue.Location = new System.Drawing.Point(284, 12);
            this.grpBoxExerciseQueue.Name = "grpBoxExerciseQueue";
            this.grpBoxExerciseQueue.Size = new System.Drawing.Size(413, 368);
            this.grpBoxExerciseQueue.TabIndex = 0;
            this.grpBoxExerciseQueue.TabStop = false;
            this.grpBoxExerciseQueue.Text = "Queue";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(83, 22);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(89, 20);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "StopWatch";
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopWatch.Location = new System.Drawing.Point(32, 114);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(200, 45);
            this.lblStopWatch.TabIndex = 2;
            this.lblStopWatch.Text = "00:00";
            this.lblStopWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentExercise
            // 
            this.lblCurrentExercise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentExercise.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentExercise.Location = new System.Drawing.Point(32, 55);
            this.lblCurrentExercise.Name = "lblCurrentExercise";
            this.lblCurrentExercise.Size = new System.Drawing.Size(200, 45);
            this.lblCurrentExercise.TabIndex = 3;
            this.lblCurrentExercise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(49, 184);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(141, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Location = new System.Drawing.Point(6, 29);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(50, 13);
            this.lblExercise.TabIndex = 6;
            this.lblExercise.Text = "Exercise:";
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Location = new System.Drawing.Point(6, 339);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(84, 13);
            this.lblRest.TabIndex = 7;
            this.lblRest.Text = "Interval Rest: (s)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(192, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time: (s)";
            // 
            // txtBoxExercise
            // 
            this.txtBoxExercise.Location = new System.Drawing.Point(9, 45);
            this.txtBoxExercise.Name = "txtBoxExercise";
            this.txtBoxExercise.Size = new System.Drawing.Size(155, 20);
            this.txtBoxExercise.TabIndex = 9;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(195, 45);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTime.TabIndex = 10;
            // 
            // txtBoxRest
            // 
            this.txtBoxRest.Location = new System.Drawing.Point(96, 336);
            this.txtBoxRest.Name = "txtBoxRest";
            this.txtBoxRest.Size = new System.Drawing.Size(68, 20);
            this.txtBoxRest.TabIndex = 11;
            // 
            // lstBoxTime
            // 
            this.lstBoxTime.FormattingEnabled = true;
            this.lstBoxTime.Location = new System.Drawing.Point(195, 71);
            this.lstBoxTime.Name = "lstBoxTime";
            this.lstBoxTime.Size = new System.Drawing.Size(100, 238);
            this.lstBoxTime.TabIndex = 12;
            // 
            // lstBoxExercise
            // 
            this.lstBoxExercise.FormattingEnabled = true;
            this.lstBoxExercise.Location = new System.Drawing.Point(9, 71);
            this.lstBoxExercise.Name = "lstBoxExercise";
            this.lstBoxExercise.Size = new System.Drawing.Size(155, 238);
            this.lstBoxExercise.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(317, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(317, 257);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 393);
            this.Controls.Add(this.grpBoxExerciseQueue);
            this.Controls.Add(this.grpBoxStopWatch);
            this.Name = "MyTimer";
            this.Text = "My Timer";
            this.grpBoxStopWatch.ResumeLayout(false);
            this.grpBoxStopWatch.PerformLayout();
            this.grpBoxExerciseQueue.ResumeLayout(false);
            this.grpBoxExerciseQueue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStopWatch;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Label lblCurrentExercise;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBoxExerciseQueue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstBoxExercise;
        private System.Windows.Forms.ListBox lstBoxTime;
        private System.Windows.Forms.TextBox txtBoxRest;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.TextBox txtBoxExercise;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label lblTime;
    }
}