
namespace EnterpriseCourseworkTwo
{
    partial class IncomeView
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelTwo = new System.Windows.Forms.Label();
            this.submitTwo = new System.Windows.Forms.Button();
            this.incomeInput = new System.Windows.Forms.NumericUpDown();
            this.backBtnControl1 = new EnterpriseCourseworkTwo.BackBtnControl();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incomeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelTwo
            // 
            this.LabelTwo.AutoSize = true;
            this.LabelTwo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTwo.Location = new System.Drawing.Point(48, 101);
            this.LabelTwo.Name = "LabelTwo";
            this.LabelTwo.Size = new System.Drawing.Size(142, 19);
            this.LabelTwo.TabIndex = 9;
            this.LabelTwo.Text = "Enter the No. of Rows";
            // 
            // submitTwo
            // 
            this.submitTwo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTwo.Location = new System.Drawing.Point(348, 95);
            this.submitTwo.Name = "submitTwo";
            this.submitTwo.Size = new System.Drawing.Size(79, 29);
            this.submitTwo.TabIndex = 10;
            this.submitTwo.Text = "Submit";
            this.submitTwo.UseVisualStyleBackColor = true;
            this.submitTwo.Click += new System.EventHandler(this.submitTwo_Click);
            // 
            // incomeInput
            // 
            this.incomeInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeInput.Location = new System.Drawing.Point(216, 99);
            this.incomeInput.Name = "incomeInput";
            this.incomeInput.Size = new System.Drawing.Size(105, 25);
            this.incomeInput.TabIndex = 11;
            // 
            // backBtnControl1
            // 
            this.backBtnControl1.Location = new System.Drawing.Point(345, 408);
            this.backBtnControl1.Name = "backBtnControl1";
            this.backBtnControl1.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.backBtnControl1.Size = new System.Drawing.Size(82, 37);
            this.backBtnControl1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(249, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(140, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IncomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 478);
            this.Controls.Add(this.backBtnControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitTwo);
            this.Controls.Add(this.incomeInput);
            this.Controls.Add(this.LabelTwo);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IncomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income";
            this.Load += new System.EventHandler(this.IncomeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelTwo;
        private System.Windows.Forms.Button submitTwo;
        private System.Windows.Forms.NumericUpDown incomeInput;
        private BackBtnControl backBtnControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}