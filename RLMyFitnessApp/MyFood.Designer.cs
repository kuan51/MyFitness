namespace RLMyFitnessApp
{
    partial class MyFood
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
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblServings = new System.Windows.Forms.Label();
            this.lblFoodList = new System.Windows.Forms.Label();
            this.txtBoxFood = new System.Windows.Forms.TextBox();
            this.txtBoxServings = new System.Windows.Forms.TextBox();
            this.txtBoxCalories = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxFiber = new System.Windows.Forms.TextBox();
            this.txtBoxFat = new System.Windows.Forms.TextBox();
            this.txtBoxProtein = new System.Windows.Forms.TextBox();
            this.txtBoxSugar = new System.Windows.Forms.TextBox();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblFiber = new System.Windows.Forms.Label();
            this.lblSugars = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.listBoxFood = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(9, 19);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(34, 13);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Food:";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(9, 64);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(102, 13);
            this.lblCalories.TabIndex = 1;
            this.lblCalories.Text = "Calories Per Serving";
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Location = new System.Drawing.Point(9, 107);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(51, 13);
            this.lblServings.TabIndex = 2;
            this.lblServings.Text = "Servings:";
            // 
            // lblFoodList
            // 
            this.lblFoodList.AutoSize = true;
            this.lblFoodList.Location = new System.Drawing.Point(9, 155);
            this.lblFoodList.Name = "lblFoodList";
            this.lblFoodList.Size = new System.Drawing.Size(50, 13);
            this.lblFoodList.TabIndex = 3;
            this.lblFoodList.Text = "Food List";
            // 
            // txtBoxFood
            // 
            this.txtBoxFood.Location = new System.Drawing.Point(12, 35);
            this.txtBoxFood.Name = "txtBoxFood";
            this.txtBoxFood.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFood.TabIndex = 1;
            // 
            // txtBoxServings
            // 
            this.txtBoxServings.Location = new System.Drawing.Point(12, 123);
            this.txtBoxServings.Name = "txtBoxServings";
            this.txtBoxServings.Size = new System.Drawing.Size(100, 20);
            this.txtBoxServings.TabIndex = 3;
            // 
            // txtBoxCalories
            // 
            this.txtBoxCalories.Location = new System.Drawing.Point(12, 80);
            this.txtBoxCalories.Name = "txtBoxCalories";
            this.txtBoxCalories.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCalories.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBoxFiber);
            this.groupBox1.Controls.Add(this.txtBoxFat);
            this.groupBox1.Controls.Add(this.txtBoxProtein);
            this.groupBox1.Controls.Add(this.txtBoxSugar);
            this.groupBox1.Controls.Add(this.lblProtein);
            this.groupBox1.Controls.Add(this.lblFiber);
            this.groupBox1.Controls.Add(this.lblSugars);
            this.groupBox1.Controls.Add(this.lblFat);
            this.groupBox1.Location = new System.Drawing.Point(148, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 153);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nutritional Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(157, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxFiber
            // 
            this.txtBoxFiber.Location = new System.Drawing.Point(157, 88);
            this.txtBoxFiber.Name = "txtBoxFiber";
            this.txtBoxFiber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFiber.TabIndex = 7;
            // 
            // txtBoxFat
            // 
            this.txtBoxFat.Location = new System.Drawing.Point(22, 39);
            this.txtBoxFat.Name = "txtBoxFat";
            this.txtBoxFat.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFat.TabIndex = 4;
            // 
            // txtBoxProtein
            // 
            this.txtBoxProtein.Location = new System.Drawing.Point(22, 88);
            this.txtBoxProtein.Name = "txtBoxProtein";
            this.txtBoxProtein.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProtein.TabIndex = 5;
            // 
            // txtBoxSugar
            // 
            this.txtBoxSugar.Location = new System.Drawing.Point(157, 39);
            this.txtBoxSugar.Name = "txtBoxSugar";
            this.txtBoxSugar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSugar.TabIndex = 6;
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(19, 72);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(43, 13);
            this.lblProtein.TabIndex = 3;
            this.lblProtein.Text = "Protein:";
            // 
            // lblFiber
            // 
            this.lblFiber.AutoSize = true;
            this.lblFiber.Location = new System.Drawing.Point(154, 72);
            this.lblFiber.Name = "lblFiber";
            this.lblFiber.Size = new System.Drawing.Size(33, 13);
            this.lblFiber.TabIndex = 2;
            this.lblFiber.Text = "Fiber:";
            // 
            // lblSugars
            // 
            this.lblSugars.AutoSize = true;
            this.lblSugars.Location = new System.Drawing.Point(154, 23);
            this.lblSugars.Name = "lblSugars";
            this.lblSugars.Size = new System.Drawing.Size(38, 13);
            this.lblSugars.TabIndex = 1;
            this.lblSugars.Text = "Sugar:";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(19, 23);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(52, 13);
            this.lblFat.TabIndex = 0;
            this.lblFat.Text = "Total Fat:";
            // 
            // listBoxFood
            // 
            this.listBoxFood.FormattingEnabled = true;
            this.listBoxFood.Location = new System.Drawing.Point(12, 171);
            this.listBoxFood.Name = "listBoxFood";
            this.listBoxFood.Size = new System.Drawing.Size(409, 147);
            this.listBoxFood.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(346, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MyFood
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 358);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBoxFood);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxCalories);
            this.Controls.Add(this.txtBoxServings);
            this.Controls.Add(this.txtBoxFood);
            this.Controls.Add(this.lblFoodList);
            this.Controls.Add(this.lblServings);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblFoodName);
            this.Name = "MyFood";
            this.Text = "MyFood";
            this.Load += new System.EventHandler(this.MyFood_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.Label lblFoodList;
        private System.Windows.Forms.TextBox txtBoxFood;
        private System.Windows.Forms.TextBox txtBoxServings;
        private System.Windows.Forms.TextBox txtBoxCalories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxFiber;
        private System.Windows.Forms.TextBox txtBoxProtein;
        private System.Windows.Forms.TextBox txtBoxFat;
        private System.Windows.Forms.TextBox txtBoxSugar;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblFiber;
        private System.Windows.Forms.Label lblSugars;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.ListBox listBoxFood;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}