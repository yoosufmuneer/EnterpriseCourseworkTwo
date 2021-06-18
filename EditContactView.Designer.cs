
namespace EnterpriseCourseworkTwo
{
    partial class EditContactView
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
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.ContactsSubmitBtn = new System.Windows.Forms.Button();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(3, 60);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(120, 22);
            this.FNameTxt.TabIndex = 2;
            // 
            // ContactsSubmitBtn
            // 
            this.ContactsSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsSubmitBtn.Location = new System.Drawing.Point(446, 60);
            this.ContactsSubmitBtn.Name = "ContactsSubmitBtn";
            this.ContactsSubmitBtn.Size = new System.Drawing.Size(89, 35);
            this.ContactsSubmitBtn.TabIndex = 4;
            this.ContactsSubmitBtn.Text = "Submit";
            this.ContactsSubmitBtn.UseVisualStyleBackColor = true;
            this.ContactsSubmitBtn.Click += new System.EventHandler(this.ContactsSubmitBtn_Click);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(293, 60);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(120, 22);
            this.EmailTxt.TabIndex = 6;
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLbl.Location = new System.Drawing.Point(3, 0);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(75, 19);
            this.FNameLbl.TabIndex = 0;
            this.FNameLbl.Text = "First Name";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(293, 0);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(41, 19);
            this.EmailLbl.TabIndex = 5;
            this.EmailLbl.Text = "Email";
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(144, 60);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(120, 22);
            this.LNameTxt.TabIndex = 3;
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLbl.Location = new System.Drawing.Point(144, 0);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(74, 19);
            this.LNameLbl.TabIndex = 1;
            this.LNameLbl.Text = "Last Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.47328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.52672F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.FNameTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ContactsSubmitBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.EmailTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.FNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmailLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LNameTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LNameLbl, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.57627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.42373F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 236);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // EditContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditContactView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditContactView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.Button ContactsSubmitBtn;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}