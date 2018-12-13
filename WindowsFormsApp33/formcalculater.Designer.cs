namespace WindowsFormsApp33
{
    partial class formcalculater
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
            this.firstnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondnumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Substarction = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstnumber
            // 
            this.firstnumber.Location = new System.Drawing.Point(248, 114);
            this.firstnumber.Multiline = true;
            this.firstnumber.Name = "firstnumber";
            this.firstnumber.Size = new System.Drawing.Size(133, 38);
            this.firstnumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter FirstNumber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter SecondNumber";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondnumber
            // 
            this.secondnumber.Location = new System.Drawing.Point(248, 178);
            this.secondnumber.Multiline = true;
            this.secondnumber.Name = "secondnumber";
            this.secondnumber.Size = new System.Drawing.Size(133, 35);
            this.secondnumber.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addition);
            this.groupBox1.Controls.Add(this.Substarction);
            this.groupBox1.Controls.Add(this.Division);
            this.groupBox1.Controls.Add(this.Multiplication);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(213, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Operater";
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(6, 28);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(87, 28);
            this.Addition.TabIndex = 4;
            this.Addition.Text = "Add";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Substarction
            // 
            this.Substarction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Substarction.Location = new System.Drawing.Point(109, 28);
            this.Substarction.Name = "Substarction";
            this.Substarction.Size = new System.Drawing.Size(100, 28);
            this.Substarction.TabIndex = 3;
            this.Substarction.Text = "Substraction";
            this.Substarction.UseVisualStyleBackColor = true;
            this.Substarction.Click += new System.EventHandler(this.Substarction_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(6, 86);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(87, 28);
            this.Division.TabIndex = 2;
            this.Division.Text = "Divide";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication.Location = new System.Drawing.Point(109, 86);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(100, 28);
            this.Multiplication.TabIndex = 1;
            this.Multiplication.Text = "Multiply";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer       ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(322, 362);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 56);
            this.result.TabIndex = 6;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CALCULATOR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formcalculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(644, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.secondnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstnumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formcalculater";
            this.Text = "formcalculater";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondnumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Substarction;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Label label4;
    }
}