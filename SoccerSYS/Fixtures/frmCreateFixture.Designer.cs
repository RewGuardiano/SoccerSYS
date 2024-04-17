
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
            this.cobTeams1 = new System.Windows.Forms.ComboBox();
            this.btnSubmitSchedule = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbTeams = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = " < Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.dtpFixture);
            this.grpCategory.Controls.Add(this.label1);
            this.grpCategory.Controls.Add(this.label2);
            this.grpCategory.Controls.Add(this.cobTeams1);
            this.grpCategory.Controls.Add(this.btnSubmitSchedule);
            this.grpCategory.Controls.Add(this.lbDate);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbTeams);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(84, 80);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(884, 412);
            this.grpCategory.TabIndex = 15;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Match Details:";
            // 
            // dtpFixture
            // 
            this.dtpFixture.AllowDrop = true;
            this.dtpFixture.Location = new System.Drawing.Point(270, 190);
            this.dtpFixture.Name = "dtpFixture";
            this.dtpFixture.Size = new System.Drawing.Size(330, 30);
            this.dtpFixture.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "LiverPool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vs";
            // 
            // cobTeams1
            // 
            this.cobTeams1.FormattingEnabled = true;
            this.cobTeams1.Location = new System.Drawing.Point(566, 66);
            this.cobTeams1.Margin = new System.Windows.Forms.Padding(4);
            this.cobTeams1.Name = "cobTeams1";
            this.cobTeams1.Size = new System.Drawing.Size(215, 33);
            this.cobTeams1.TabIndex = 16;
            // 
            // btnSubmitSchedule
            // 
            this.btnSubmitSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitSchedule.Location = new System.Drawing.Point(277, 283);
            this.btnSubmitSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitSchedule.Name = "btnSubmitSchedule";
            this.btnSubmitSchedule.Size = new System.Drawing.Size(193, 48);
            this.btnSubmitSchedule.TabIndex = 22;
            this.btnSubmitSchedule.Text = "Submit";
            this.btnSubmitSchedule.UseVisualStyleBackColor = true;
            this.btnSubmitSchedule.Click += new System.EventHandler(this.btnSubmitSchedule_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(90, 191);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(70, 29);
            this.lbDate.TabIndex = 17;
            this.lbDate.Text = "Date";
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
            this.lbTeams.Location = new System.Drawing.Point(53, 70);
            this.lbTeams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(117, 29);
            this.lbTeams.TabIndex = 14;
            this.lbTeams.Text = "Matchup";
            // 
            // frmCreateFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateFixture";
            this.Text = "ScheduleMatch";
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
        private System.Windows.Forms.ComboBox cobTeams1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFixture;
    }
}