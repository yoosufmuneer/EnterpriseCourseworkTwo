
namespace EnterpriseCourseworkTwo
{
    partial class BackBtnControl
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
            this.BackBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBTN
            // 
            this.BackBTN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBTN.Location = new System.Drawing.Point(0, 0);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(105, 48);
            this.BackBTN.TabIndex = 0;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.Back_Click);
            // 
            // BackBtnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackBTN);
            this.Name = "BackBtnControl";
            this.Size = new System.Drawing.Size(110, 50);
            this.Load += new System.EventHandler(this.BackBtnControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBTN;
    }
}
