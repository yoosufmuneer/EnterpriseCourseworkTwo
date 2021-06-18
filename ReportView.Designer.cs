
namespace EnterpriseCourseworkTwo
{
    partial class ReportView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NetAssets = new System.Windows.Forms.Label();
            this.TotalLiabilities = new System.Windows.Forms.Label();
            this.TotalAssets = new System.Windows.Forms.Label();
            this.NetIncome = new System.Windows.Forms.Label();
            this.TotalExpense = new System.Windows.Forms.Label();
            this.TotalIncome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backBtnControl2 = new EnterpriseCourseworkTwo.BackBtnControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.NetAssets, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TotalLiabilities, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotalAssets, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NetIncome, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TotalExpense, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotalIncome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NetAssets
            // 
            this.NetAssets.AutoSize = true;
            this.NetAssets.Location = new System.Drawing.Point(193, 255);
            this.NetAssets.Name = "NetAssets";
            this.NetAssets.Size = new System.Drawing.Size(16, 17);
            this.NetAssets.TabIndex = 11;
            this.NetAssets.Text = "0";
            // 
            // TotalLiabilities
            // 
            this.TotalLiabilities.AutoSize = true;
            this.TotalLiabilities.Location = new System.Drawing.Point(193, 204);
            this.TotalLiabilities.Name = "TotalLiabilities";
            this.TotalLiabilities.Size = new System.Drawing.Size(16, 17);
            this.TotalLiabilities.TabIndex = 10;
            this.TotalLiabilities.Text = "0";
            // 
            // TotalAssets
            // 
            this.TotalAssets.AutoSize = true;
            this.TotalAssets.Location = new System.Drawing.Point(193, 153);
            this.TotalAssets.Name = "TotalAssets";
            this.TotalAssets.Size = new System.Drawing.Size(16, 17);
            this.TotalAssets.TabIndex = 9;
            this.TotalAssets.Text = "0";
            // 
            // NetIncome
            // 
            this.NetIncome.AutoSize = true;
            this.NetIncome.Location = new System.Drawing.Point(193, 102);
            this.NetIncome.Name = "NetIncome";
            this.NetIncome.Size = new System.Drawing.Size(16, 17);
            this.NetIncome.TabIndex = 8;
            this.NetIncome.Text = "0";
            // 
            // TotalExpense
            // 
            this.TotalExpense.AutoSize = true;
            this.TotalExpense.Location = new System.Drawing.Point(193, 51);
            this.TotalExpense.Name = "TotalExpense";
            this.TotalExpense.Size = new System.Drawing.Size(16, 17);
            this.TotalExpense.TabIndex = 7;
            this.TotalExpense.Text = "0";
            this.TotalExpense.Click += new System.EventHandler(this.TotalExpense_Click);
            // 
            // TotalIncome
            // 
            this.TotalIncome.AutoSize = true;
            this.TotalIncome.Location = new System.Drawing.Point(193, 0);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(16, 17);
            this.TotalIncome.TabIndex = 6;
            this.TotalIncome.Text = "0";
            this.TotalIncome.Click += new System.EventHandler(this.TotalIncome_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Net Assets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Liabilities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Income";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Net Income/Loss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Assets";
            // 
            // backBtnControl2
            // 
            this.backBtnControl2.Location = new System.Drawing.Point(21, 371);
            this.backBtnControl2.Name = "backBtnControl2";
            this.backBtnControl2.Size = new System.Drawing.Size(125, 65);
            this.backBtnControl2.TabIndex = 1;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 448);
            this.Controls.Add(this.backBtnControl2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NetAssets;
        private System.Windows.Forms.Label TotalLiabilities;
        private System.Windows.Forms.Label TotalAssets;
        private System.Windows.Forms.Label NetIncome;
        private System.Windows.Forms.Label TotalExpense;
        private System.Windows.Forms.Label TotalIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private BackBtnControl backBtnControl2;
    }
}