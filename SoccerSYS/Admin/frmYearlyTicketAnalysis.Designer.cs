
namespace SoccerSYS
{
    partial class frmYearlyTicketAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyTicketAnalysis));
            this.btnbackYTA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnbackYTA
            // 
            this.btnbackYTA.Location = new System.Drawing.Point(3, 1);
            this.btnbackYTA.Margin = new System.Windows.Forms.Padding(4);
            this.btnbackYTA.Name = "btnbackYTA";
            this.btnbackYTA.Size = new System.Drawing.Size(100, 28);
            this.btnbackYTA.TabIndex = 16;
            this.btnbackYTA.Text = " < Back";
            this.btnbackYTA.UseVisualStyleBackColor = true;
            this.btnbackYTA.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SoccerSYS.Properties.Resources.TicketChart;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(74, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 355);
            this.panel1.TabIndex = 17;
            // 
            // frmYearlyTicketAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbackYTA);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmYearlyTicketAnalysis";
            this.Text = "YearlyTicketAnalysis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbackYTA;
        private System.Windows.Forms.Panel panel1;
    }
}