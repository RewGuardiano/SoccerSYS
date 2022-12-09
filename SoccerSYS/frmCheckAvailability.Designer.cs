
namespace SoccerSYS
{
    partial class frmCheckAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckAvailability));
            this.btnBackCA = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.cobMatchDate = new System.Windows.Forms.ComboBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.cobTeams = new System.Windows.Forms.ComboBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbTeams = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackCA
            // 
            this.btnBackCA.Location = new System.Drawing.Point(4, 4);
            this.btnBackCA.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackCA.Name = "btnBackCA";
            this.btnBackCA.Size = new System.Drawing.Size(100, 28);
            this.btnBackCA.TabIndex = 12;
            this.btnBackCA.Text = " < Back";
            this.btnBackCA.UseVisualStyleBackColor = true;
            this.btnBackCA.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpCategory.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.grpCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpCategory.Controls.Add(this.cobMatchDate);
            this.grpCategory.Controls.Add(this.lbDate);
            this.grpCategory.Controls.Add(this.cobTeams);
            this.grpCategory.Controls.Add(this.btnCheckAvailability);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbTeams);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpCategory.Location = new System.Drawing.Point(73, 48);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(894, 401);
            this.grpCategory.TabIndex = 17;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Select Match:";
            this.grpCategory.Enter += new System.EventHandler(this.grpCategory_Enter);
            // 
            // cobMatchDate
            // 
            this.cobMatchDate.FormattingEnabled = true;
            this.cobMatchDate.Location = new System.Drawing.Point(336, 192);
            this.cobMatchDate.Name = "cobMatchDate";
            this.cobMatchDate.Size = new System.Drawing.Size(193, 33);
            this.cobMatchDate.TabIndex = 27;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(203, 196);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(70, 29);
            this.lbDate.TabIndex = 26;
            this.lbDate.Text = "Date";
            // 
            // cobTeams
            // 
            this.cobTeams.FormattingEnabled = true;
            this.cobTeams.Location = new System.Drawing.Point(336, 115);
            this.cobTeams.Name = "cobTeams";
            this.cobTeams.Size = new System.Drawing.Size(260, 33);
            this.cobTeams.TabIndex = 25;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAvailability.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckAvailability.Location = new System.Drawing.Point(336, 277);
            this.btnCheckAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(193, 72);
            this.btnCheckAvailability.TabIndex = 22;
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(53, 154);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 29);
            this.lblPrice.TabIndex = 16;
            // 
            // lbTeams
            // 
            this.lbTeams.AutoSize = true;
            this.lbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeams.Location = new System.Drawing.Point(203, 114);
            this.lbTeams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(96, 29);
            this.lbTeams.TabIndex = 14;
            this.lbTeams.Text = "Teams";
            // 
            // frmCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnBackCA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCheckAvailability";
            this.Text = "CheckAvailability";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackCA;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.ComboBox cobTeams;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbTeams;
        private System.Windows.Forms.ComboBox cobMatchDate;
        private System.Windows.Forms.Label lbDate;
    }
}