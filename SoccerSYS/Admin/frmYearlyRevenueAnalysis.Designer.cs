
namespace SoccerSYS
{
    partial class frrmYearlyRevenueAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frrmYearlyRevenueAnalysis));
            this.btnbackYRA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnbackYRA
            // 
            this.btnbackYRA.Location = new System.Drawing.Point(1, 2);
            this.btnbackYRA.Margin = new System.Windows.Forms.Padding(4);
            this.btnbackYRA.Name = "btnbackYRA";
            this.btnbackYRA.Size = new System.Drawing.Size(100, 28);
            this.btnbackYRA.TabIndex = 15;
            this.btnbackYRA.Text = " < Back";
            this.btnbackYRA.UseVisualStyleBackColor = true;
            this.btnbackYRA.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SoccerSYS.Properties.Resources.RevenueChart1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(174, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 431);
            this.panel1.TabIndex = 16;
            // 
            // frrmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbackYRA);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frrmYearlyRevenueAnalysis";
            this.Text = "YearlyRevenueAnalysis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbackYRA;
        private System.Windows.Forms.Panel panel1;
    }
}