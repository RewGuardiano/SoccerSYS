
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
            this.btnBackCA = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.cobTeams = new System.Windows.Forms.ComboBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cobMatchDate = new System.Windows.Forms.ComboBox();
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
            this.grpCategory.Controls.Add(this.cobMatchDate);
            this.grpCategory.Controls.Add(this.lbDate);
            this.grpCategory.Controls.Add(this.cobTeams);
            this.grpCategory.Controls.Add(this.btnCheckAvailability);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbldescription);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCheckAvailability.Location = new System.Drawing.Point(336, 270);
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
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(203, 114);
            this.lbldescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(96, 29);
            this.lbldescription.TabIndex = 14;
            this.lbldescription.Text = "Teams";
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
            // cobMatchDate
            // 
            this.cobMatchDate.FormattingEnabled = true;
            this.cobMatchDate.Location = new System.Drawing.Point(336, 192);
            this.cobMatchDate.Name = "cobMatchDate";
            this.cobMatchDate.Size = new System.Drawing.Size(193, 33);
            this.cobMatchDate.TabIndex = 27;
            // 
            // frmCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnBackCA);
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
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.ComboBox cobMatchDate;
        private System.Windows.Forms.Label lbDate;
    }
}