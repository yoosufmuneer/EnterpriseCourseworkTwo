
namespace EnterpriseCourseworkTwo
{
    partial class AddExpense
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
            this.Recurring = new System.Windows.Forms.Label();
            this.payee = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PayeeLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.expenseUpDown = new System.Windows.Forms.NumericUpDown();
            this.RecurringChkBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.expenseUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Recurring
            // 
            this.Recurring.AutoSize = true;
            this.Recurring.Location = new System.Drawing.Point(576, 5);
            this.Recurring.Name = "Recurring";
            this.Recurring.Size = new System.Drawing.Size(73, 19);
            this.Recurring.TabIndex = 35;
            this.Recurring.Text = "Recurring?";
            // 
            // payee
            // 
            this.payee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payee.FormattingEnabled = true;
            this.payee.Location = new System.Drawing.Point(128, 73);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(106, 25);
            this.payee.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 25);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Date";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(689, 73);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(83, 33);
            this.SubmitBtn.TabIndex = 29;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(277, 73);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(118, 25);
            this.DescriptionTxt.TabIndex = 28;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(277, 5);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(78, 19);
            this.DescriptionLabel.TabIndex = 26;
            this.DescriptionLabel.Text = "Description";
            // 
            // PayeeLabel
            // 
            this.PayeeLabel.AutoSize = true;
            this.PayeeLabel.Location = new System.Drawing.Point(128, 5);
            this.PayeeLabel.Name = "PayeeLabel";
            this.PayeeLabel.Size = new System.Drawing.Size(45, 19);
            this.PayeeLabel.TabIndex = 25;
            this.PayeeLabel.Text = "Payee";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(8, 5);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(59, 19);
            this.AmountLabel.TabIndex = 24;
            this.AmountLabel.Text = "Amount";
            // 
            // expenseUpDown
            // 
            this.expenseUpDown.Location = new System.Drawing.Point(8, 73);
            this.expenseUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.expenseUpDown.Name = "expenseUpDown";
            this.expenseUpDown.Size = new System.Drawing.Size(103, 25);
            this.expenseUpDown.TabIndex = 36;
            this.expenseUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // RecurringChkBox
            // 
            this.RecurringChkBox.AutoSize = true;
            this.RecurringChkBox.Location = new System.Drawing.Point(576, 73);
            this.RecurringChkBox.Name = "RecurringChkBox";
            this.RecurringChkBox.Size = new System.Drawing.Size(51, 23);
            this.RecurringChkBox.TabIndex = 37;
            this.RecurringChkBox.Text = "Yes";
            this.RecurringChkBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.91228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.00248F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36555F));
            this.tableLayoutPanel1.Controls.Add(this.expenseUpDown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SubmitBtn, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.RecurringChkBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.AmountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Recurring, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.payee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PayeeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 141);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 142);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)(this.expenseUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Recurring;
        private System.Windows.Forms.ComboBox payee;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PayeeLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.NumericUpDown expenseUpDown;
        private System.Windows.Forms.CheckBox RecurringChkBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}