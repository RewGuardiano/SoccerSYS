
namespace SoccerSYS
{
    partial class frmCreateFixture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateFixture));
            this.button1 = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.dtpFixture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cobAwayTeam = new System.Windows.Forms.ComboBox();
            this.btnSubmitSchedule = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbTeams = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = " < Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCategory.Controls.Add(this.dtpFixture);
            this.grpCategory.Controls.Add(this.label1);
            this.grpCategory.Controls.Add(this.label2);
            this.grpCategory.Controls.Add(this.cobAwayTeam);
            this.grpCategory.Controls.Add(this.btnSubmitSchedule);
            this.grpCategory.Controls.Add(this.lbDate);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbTeams);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(63, 65);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(663, 335);
            this.grpCategory.TabIndex = 15;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Match Details:";
            // 
            // dtpFixture
            // 
            this.dtpFixture.AllowDrop = true;
            this.dtpFixture.Location = new System.Drawing.Point(202, 154);
            this.dtpFixture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFixture.Name = "dtpFixture";
            this.dtpFixture.Size = new System.Drawing.Size(248, 26);
            this.dtpFixture.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "LiverPool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vs";
            // 
            // cobAwayTeam
            // 
            this.cobAwayTeam.FormattingEnabled = true;
            this.cobAwayTeam.Location = new System.Drawing.Point(388, 58);
            this.cobAwayTeam.Name = "cobAwayTeam";
            this.cobAwayTeam.Size = new System.Drawing.Size(260, 28);
            this.cobAwayTeam.TabIndex = 16;
            this.cobAwayTeam.SelectedIndexChanged += new System.EventHandler(this.cobAwayTeam_SelectedIndexChanged);
            // 
            // btnSubmitSchedule
            // 
            this.btnSubmitSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitSchedule.Location = new System.Drawing.Point(208, 230);
            this.btnSubmitSchedule.Name = "btnSubmitSchedule";
            this.btnSubmitSchedule.Size = new System.Drawing.Size(145, 39);
            this.btnSubmitSchedule.TabIndex = 22;
            this.btnSubmitSchedule.Text = "Schedule";
            this.btnSubmitSchedule.UseVisualStyleBackColor = true;
            this.btnSubmitSchedule.Click += new System.EventHandler(this.btnSubmitSchedule_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(68, 155);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 25);
            this.lbDate.TabIndex = 17;
            this.lbDate.Text = "Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(40, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 25);
            this.lblPrice.TabIndex = 16;
            // 
            // lbTeams
            // 
            this.lbTeams.AutoSize = true;
            this.lbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeams.Location = new System.Drawing.Point(40, 57);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(95, 25);
            this.lbTeams.TabIndex = 14;
            this.lbTeams.Text = "Matchup";
            // 
            // frmCreateFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateFixture";
            this.Text = "Create Fixture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateFixture_FormClosed);
            this.Load += new System.EventHandler(this.frmCreateFixture_Load);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbTeams;
        private System.Windows.Forms.Button btnSubmitSchedule;
        private System.Windows.Forms.ComboBox cobAwayTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFixture;
    }
}