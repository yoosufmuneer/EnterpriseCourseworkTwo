
namespace EnterpriseCourseworkTwo
{
    partial class HomeScreen
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.IncomeBtn = new System.Windows.Forms.Button();
            this.ExpensesBtn = new System.Windows.Forms.Button();
            this.ContactsBtn = new System.Windows.Forms.Button();
            this.AssetsBtn = new System.Windows.Forms.Button();
            this.LiabilitiesBtn = new System.Windows.Forms.Button();
            this.GenReportBtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PredictionBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(28, 25);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(128, 32);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome!";
            // 
            // IncomeBtn
            // 
            this.IncomeBtn.Location = new System.Drawing.Point(28, 121);
            this.IncomeBtn.Name = "IncomeBtn";
            this.IncomeBtn.Size = new System.Drawing.Size(109, 36);
            this.IncomeBtn.TabIndex = 1;
            this.IncomeBtn.Text = "Income";
            this.IncomeBtn.UseVisualStyleBackColor = true;
            this.IncomeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpensesBtn
            // 
            this.ExpensesBtn.Location = new System.Drawing.Point(209, 121);
            this.ExpensesBtn.Name = "ExpensesBtn";
            this.ExpensesBtn.Size = new System.Drawing.Size(109, 36);
            this.ExpensesBtn.TabIndex = 2;
            this.ExpensesBtn.Text = "Expenses";
            this.ExpensesBtn.UseVisualStyleBackColor = true;
            this.ExpensesBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContactsBtn
            // 
            this.ContactsBtn.Location = new System.Drawing.Point(390, 121);
            this.ContactsBtn.Name = "ContactsBtn";
            this.ContactsBtn.Size = new System.Drawing.Size(109, 36);
            this.ContactsBtn.TabIndex = 3;
            this.ContactsBtn.Text = "Contacts";
            this.ContactsBtn.UseVisualStyleBackColor = true;
            this.ContactsBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AssetsBtn
            // 
            this.AssetsBtn.Location = new System.Drawing.Point(28, 214);
            this.AssetsBtn.Name = "AssetsBtn";
            this.AssetsBtn.Size = new System.Drawing.Size(109, 36);
            this.AssetsBtn.TabIndex = 4;
            this.AssetsBtn.Text = "Assets";
            this.AssetsBtn.UseVisualStyleBackColor = true;
            this.AssetsBtn.Click += new System.EventHandler(this.AssetsBtn_Click);
            // 
            // LiabilitiesBtn
            // 
            this.LiabilitiesBtn.Location = new System.Drawing.Point(209, 214);
            this.LiabilitiesBtn.Name = "LiabilitiesBtn";
            this.LiabilitiesBtn.Size = new System.Drawing.Size(109, 36);
            this.LiabilitiesBtn.TabIndex = 5;
            this.LiabilitiesBtn.Text = "Liabilities";
            this.LiabilitiesBtn.UseVisualStyleBackColor = true;
            this.LiabilitiesBtn.Click += new System.EventHandler(this.LiabilitiesBtn_Click);
            // 
            // GenReportBtn
            // 
            this.GenReportBtn.Location = new System.Drawing.Point(390, 214);
            this.GenReportBtn.Name = "GenReportBtn";
            this.GenReportBtn.Size = new System.Drawing.Size(128, 36);
            this.GenReportBtn.TabIndex = 6;
            this.GenReportBtn.Text = "Generate Report";
            this.GenReportBtn.UseVisualStyleBackColor = true;
            this.GenReportBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Location = new System.Drawing.Point(209, 307);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(109, 36);
            this.SignOutBtn.TabIndex = 7;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            this.SignOutBtn.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(250, 0);
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.PredictionBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SignOutBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AssetsBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LiabilitiesBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.GenReportBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ContactsBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExpensesBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IncomeBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WelcomeLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(25);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 424);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // PredictionBtn
            // 
            this.PredictionBtn.Location = new System.Drawing.Point(28, 307);
            this.PredictionBtn.Name = "PredictionBtn";
            this.PredictionBtn.Size = new System.Drawing.Size(109, 36);
            this.PredictionBtn.TabIndex = 8;
            this.PredictionBtn.Text = "Prediction";
            this.PredictionBtn.UseVisualStyleBackColor = true;
            this.PredictionBtn.Click += new System.EventHandler(this.PredictionBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Manager";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button IncomeBtn;
        private System.Windows.Forms.Button ExpensesBtn;
        private System.Windows.Forms.Button ContactsBtn;
        private System.Windows.Forms.Button AssetsBtn;
        private System.Windows.Forms.Button LiabilitiesBtn;
        private System.Windows.Forms.Button GenReportBtn;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PredictionBtn;
    }
}