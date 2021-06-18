
namespace EnterpriseCourseworkTwo
{
    partial class ContactsView
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
            this.backBtnControl1 = new EnterpriseCourseworkTwo.BackBtnControl();
            this.AddContactBtn = new System.Windows.Forms.Button();
            this.ContactsLbl = new System.Windows.Forms.Label();
            this.SubmitNumofRows = new System.Windows.Forms.Button();
            this.inputNumofRows = new System.Windows.Forms.NumericUpDown();
            this.NumofRowsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumofRows)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtnControl1
            // 
            this.backBtnControl1.Location = new System.Drawing.Point(146, 399);
            this.backBtnControl1.Name = "backBtnControl1";
            this.backBtnControl1.Padding = new System.Windows.Forms.Padding(0, 48, 0, 0);
            this.backBtnControl1.Size = new System.Drawing.Size(100, 39);
            this.backBtnControl1.TabIndex = 16;
            // 
            // AddContactBtn
            // 
            this.AddContactBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContactBtn.Location = new System.Drawing.Point(44, 398);
            this.AddContactBtn.Name = "AddContactBtn";
            this.AddContactBtn.Size = new System.Drawing.Size(72, 37);
            this.AddContactBtn.TabIndex = 13;
            this.AddContactBtn.Text = "Add";
            this.AddContactBtn.UseVisualStyleBackColor = true;
            this.AddContactBtn.Click += new System.EventHandler(this.AddContactsBtn_Click);
            // 
            // ContactsLbl
            // 
            this.ContactsLbl.AutoSize = true;
            this.ContactsLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsLbl.Location = new System.Drawing.Point(38, 26);
            this.ContactsLbl.Name = "ContactsLbl";
            this.ContactsLbl.Size = new System.Drawing.Size(107, 32);
            this.ContactsLbl.TabIndex = 12;
            this.ContactsLbl.Text = "Contacts";
            // 
            // SubmitNumofRows
            // 
            this.SubmitNumofRows.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitNumofRows.Location = new System.Drawing.Point(354, 85);
            this.SubmitNumofRows.Name = "SubmitNumofRows";
            this.SubmitNumofRows.Size = new System.Drawing.Size(79, 29);
            this.SubmitNumofRows.TabIndex = 18;
            this.SubmitNumofRows.Text = "Submit";
            this.SubmitNumofRows.UseVisualStyleBackColor = true;
            this.SubmitNumofRows.Click += new System.EventHandler(this.SubmitNumofRows_Click);
            // 
            // inputNumofRows
            // 
            this.inputNumofRows.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumofRows.Location = new System.Drawing.Point(222, 89);
            this.inputNumofRows.Name = "inputNumofRows";
            this.inputNumofRows.Size = new System.Drawing.Size(105, 25);
            this.inputNumofRows.TabIndex = 19;
            // 
            // NumofRowsLbl
            // 
            this.NumofRowsLbl.AutoSize = true;
            this.NumofRowsLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumofRowsLbl.Location = new System.Drawing.Point(54, 91);
            this.NumofRowsLbl.Name = "NumofRowsLbl";
            this.NumofRowsLbl.Size = new System.Drawing.Size(142, 19);
            this.NumofRowsLbl.TabIndex = 17;
            this.NumofRowsLbl.Text = "Enter the No. of Rows";
            // 
            // ContactsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 478);
            this.Controls.Add(this.backBtnControl1);
            this.Controls.Add(this.AddContactBtn);
            this.Controls.Add(this.ContactsLbl);
            this.Controls.Add(this.SubmitNumofRows);
            this.Controls.Add(this.inputNumofRows);
            this.Controls.Add(this.NumofRowsLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ContactsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumofRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BackBtnControl backBtnControl1;
        private System.Windows.Forms.Button AddContactBtn;
        private System.Windows.Forms.Label ContactsLbl;
        private System.Windows.Forms.Button SubmitNumofRows;
        private System.Windows.Forms.NumericUpDown inputNumofRows;
        private System.Windows.Forms.Label NumofRowsLbl;
    }
}