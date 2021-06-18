
namespace EnterpriseCourseworkTwo.ViewsControllers
{
    partial class AssetsView
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
            this.button1 = new System.Windows.Forms.Button();
            this.Assets = new System.Windows.Forms.Label();
            this.SubmitAssets = new System.Windows.Forms.Button();
            this.incomeInput = new System.Windows.Forms.NumericUpDown();
            this.LabelTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtnControl1
            // 
            this.backBtnControl1.Location = new System.Drawing.Point(181, 378);
            this.backBtnControl1.Name = "backBtnControl1";
            this.backBtnControl1.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.backBtnControl1.Size = new System.Drawing.Size(97, 44);
            this.backBtnControl1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Assets
            // 
            this.Assets.AutoSize = true;
            this.Assets.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assets.Location = new System.Drawing.Point(50, 33);
            this.Assets.Name = "Assets";
            this.Assets.Size = new System.Drawing.Size(81, 32);
            this.Assets.TabIndex = 12;
            this.Assets.Text = "Assets";
            // 
            // SubmitAssets
            // 
            this.SubmitAssets.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitAssets.Location = new System.Drawing.Point(366, 92);
            this.SubmitAssets.Name = "SubmitAssets";
            this.SubmitAssets.Size = new System.Drawing.Size(79, 29);
            this.SubmitAssets.TabIndex = 18;
            this.SubmitAssets.Text = "Submit";
            this.SubmitAssets.UseVisualStyleBackColor = true;
            this.SubmitAssets.Click += new System.EventHandler(this.SubmitAssets_Click);
            // 
            // incomeInput
            // 
            this.incomeInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeInput.Location = new System.Drawing.Point(234, 96);
            this.incomeInput.Name = "incomeInput";
            this.incomeInput.Size = new System.Drawing.Size(105, 25);
            this.incomeInput.TabIndex = 19;
            // 
            // LabelTwo
            // 
            this.LabelTwo.AutoSize = true;
            this.LabelTwo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTwo.Location = new System.Drawing.Point(66, 98);
            this.LabelTwo.Name = "LabelTwo";
            this.LabelTwo.Size = new System.Drawing.Size(142, 19);
            this.LabelTwo.TabIndex = 17;
            this.LabelTwo.Text = "Enter the No. of Rows";
            // 
            // AssetsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtnControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Assets);
            this.Controls.Add(this.SubmitAssets);
            this.Controls.Add(this.incomeInput);
            this.Controls.Add(this.LabelTwo);
            this.Name = "AssetsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssetsView";
            ((System.ComponentModel.ISupportInitialize)(this.incomeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BackBtnControl backBtnControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Assets;
        private System.Windows.Forms.Button SubmitAssets;
        private System.Windows.Forms.NumericUpDown incomeInput;
        private System.Windows.Forms.Label LabelTwo;
    }
}