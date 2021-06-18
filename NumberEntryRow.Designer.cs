
namespace EnterpriseCourseworkTwo
{
    partial class NumberEntryRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RowNoEntry = new System.Windows.Forms.NumericUpDown();
            this.RowNoEntryLbl = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RowNoEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // RowNoEntry
            // 
            this.RowNoEntry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowNoEntry.Location = new System.Drawing.Point(197, 19);
            this.RowNoEntry.Name = "RowNoEntry";
            this.RowNoEntry.Size = new System.Drawing.Size(120, 25);
            this.RowNoEntry.TabIndex = 0;
            // 
            // RowNoEntryLbl
            // 
            this.RowNoEntryLbl.AutoSize = true;
            this.RowNoEntryLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowNoEntryLbl.Location = new System.Drawing.Point(14, 19);
            this.RowNoEntryLbl.Name = "RowNoEntryLbl";
            this.RowNoEntryLbl.Size = new System.Drawing.Size(147, 19);
            this.RowNoEntryLbl.TabIndex = 1;
            this.RowNoEntryLbl.Text = "Enter Number of Rows";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(351, 11);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(95, 37);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberEntryRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.RowNoEntryLbl);
            this.Controls.Add(this.RowNoEntry);
            this.Name = "NumberEntryRow";
            this.Size = new System.Drawing.Size(460, 58);
            ((System.ComponentModel.ISupportInitialize)(this.RowNoEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown RowNoEntry;
        private System.Windows.Forms.Label RowNoEntryLbl;
        private System.Windows.Forms.Button Submit;
    }
}
