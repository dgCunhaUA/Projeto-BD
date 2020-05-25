namespace SAA_Project
{
    partial class FormUC
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
            this.HomePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomePage
            // 
            this.HomePage.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.HomePage.AutoSize = true;
            this.HomePage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomePage.Font = new System.Drawing.Font("Arial", 9F);
            this.HomePage.Location = new System.Drawing.Point(708, 12);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(80, 25);
            this.HomePage.TabIndex = 1;
            this.HomePage.Text = "HomePage";
            this.HomePage.UseVisualStyleBackColor = true;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // FormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomePage);
            this.Name = "FormUC";
            this.Text = "FormUC";
            this.Load += new System.EventHandler(this.FormUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HomePage;
    }
}