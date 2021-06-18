
namespace EnterpriseCourseworkTwo
{
    partial class ExpenseView
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
            this.button1 = new System.Windows.Forms.Button();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.ExpenseSubmit = new System.Windows.Forms.Button();
            this.ExpenseInput = new System.Windows.Forms.NumericUpDown();
            this.LabelTwo = new System.Windows.Forms.Label();
            this.backBtnControl1 = new EnterpriseCourseworkTwo.BackBtnControl();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseLabel.Location = new System.Drawing.Point(52, 43);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(102, 32);
            this.expenseLabel.TabIndex = 12;
            this.expenseLabel.Text = "Expense";
            // 
            // ExpenseSubmit
            // 
            this.ExpenseSubmit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseSubmit.Location = new System.Drawing.Point(368, 102);
            this.ExpenseSubmit.Name = "ExpenseSubmit";
            this.ExpenseSubmit.Size = new System.Drawing.Size(79, 29);
            this.ExpenseSubmit.TabIndex = 18;
            this.ExpenseSubmit.Text = "Submit";
            this.ExpenseSubmit.UseVisualStyleBackColor = true;
            this.ExpenseSubmit.Click += new System.EventHandler(this.ExpenseSubmit_Click);
            // 
            // ExpenseInput
            // 
            this.ExpenseInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseInput.Location = new System.Drawing.Point(236, 106);
            this.ExpenseInput.Name = "ExpenseInput";
            this.ExpenseInput.Size = new System.Drawing.Size(105, 25);
            this.ExpenseInput.TabIndex = 19;
            // 
            // LabelTwo
            // 
            this.LabelTwo.AutoSize = true;
            this.LabelTwo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTwo.Location = new System.Drawing.Point(68, 108);
            this.LabelTwo.Name = "LabelTwo";
            this.LabelTwo.Size = new System.Drawing.Size(142, 19);
            this.LabelTwo.TabIndex = 17;
            this.LabelTwo.Text = "Enter the No. of Rows";
            // 
            // backBtnControl1
            // 
            this.backBtnControl1.Location = new System.Drawing.Point(150, 413);
            this.backBtnControl1.Name = "backBtnControl1";
            this.backBtnControl1.Padding = new System.Windows.Forms.Padding(0, 48, 0, 0);
            this.backBtnControl1.Size = new System.Drawing.Size(85, 39);
            this.backBtnControl1.TabIndex = 16;
            // 
            // ExpenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.backBtnControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expenseLabel);
            this.Controls.Add(this.ExpenseSubmit);
            this.Controls.Add(this.ExpenseInput);
            this.Controls.Add(this.LabelTwo);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExpenseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BackBtnControl backBtnControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Button ExpenseSubmit;
        private System.Windows.Forms.NumericUpDown ExpenseInput;
        private System.Windows.Forms.Label LabelTwo;
    }
}