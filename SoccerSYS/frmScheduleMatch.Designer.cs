
namespace SoccerSYS
{
    partial class frmScheduleMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleMatch));
            this.button1 = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.dtpMatchDate = new System.Windows.Forms.DateTimePicker();
            this.lbvs = new System.Windows.Forms.Label();
            this.cobTeams2 = new System.Windows.Forms.ComboBox();
            this.cobTeams1 = new System.Windows.Forms.ComboBox();
            this.btnSubmitSchedule = new System.Windows.Forms.Button();
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.txtMatchTime = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbTeams = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.lblticketsold = new System.Windows.Forms.Label();
            this.numericTicketSold = new System.Windows.Forms.NumericUpDown();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicketSold)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = " < Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.numericTicketSold);
            this.grpCategory.Controls.Add(this.lblticketsold);
            this.grpCategory.Controls.Add(this.dtpMatchDate);
            this.grpCategory.Controls.Add(this.lbvs);
            this.grpCategory.Controls.Add(this.cobTeams2);
            this.grpCategory.Controls.Add(this.cobTeams1);
            this.grpCategory.Controls.Add(this.btnSubmitSchedule);
            this.grpCategory.Controls.Add(this.txtMatchID);
            this.grpCategory.Controls.Add(this.txtMatchTime);
            this.grpCategory.Controls.Add(this.lbTime);
            this.grpCategory.Controls.Add(this.lbDate);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbTeams);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(85, 31);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCategory.Size = new System.Drawing.Size(893, 534);
            this.grpCategory.TabIndex = 15;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Match Details:";
            this.grpCategory.Enter += new System.EventHandler(this.grpCategory_Enter);
            // 
            // dtpMatchDate
            // 
            this.dtpMatchDate.Location = new System.Drawing.Point(228, 283);
            this.dtpMatchDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMatchDate.Name = "dtpMatchDate";
            this.dtpMatchDate.Size = new System.Drawing.Size(265, 30);
            this.dtpMatchDate.TabIndex = 25;
            // 
            // lbvs
            // 
            this.lbvs.AutoSize = true;
            this.lbvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvs.Location = new System.Drawing.Point(479, 151);
            this.lbvs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbvs.Name = "lbvs";
            this.lbvs.Size = new System.Drawing.Size(49, 29);
            this.lbvs.TabIndex = 24;
            this.lbvs.Text = "VS";
            // 
            // cobTeams2
            // 
            this.cobTeams2.FormattingEnabled = true;
            this.cobTeams2.Location = new System.Drawing.Point(564, 148);
            this.cobTeams2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cobTeams2.Name = "cobTeams2";
            this.cobTeams2.Size = new System.Drawing.Size(256, 33);
            this.cobTeams2.TabIndex = 23;
            // 
            // cobTeams1
            // 
            this.cobTeams1.FormattingEnabled = true;
            this.cobTeams1.Location = new System.Drawing.Point(228, 146);
            this.cobTeams1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cobTeams1.Name = "cobTeams1";
            this.cobTeams1.Size = new System.Drawing.Size(215, 33);
            this.cobTeams1.TabIndex = 16;
            // 
            // btnSubmitSchedule
            // 
            this.btnSubmitSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitSchedule.Location = new System.Drawing.Point(270, 462);
            this.btnSubmitSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitSchedule.Name = "btnSubmitSchedule";
            this.btnSubmitSchedule.Size = new System.Drawing.Size(193, 48);
            this.btnSubmitSchedule.TabIndex = 22;
            this.btnSubmitSchedule.Text = "Submit";
            this.btnSubmitSchedule.UseVisualStyleBackColor = true;
            this.btnSubmitSchedule.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMatchID
            // 
            this.txtMatchID.Location = new System.Drawing.Point(228, 48);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.Size = new System.Drawing.Size(181, 30);
            this.txtMatchID.TabIndex = 21;
            // 
            // txtMatchTime
            // 
            this.txtMatchTime.Location = new System.Drawing.Point(228, 215);
            this.txtMatchTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatchTime.Name = "txtMatchTime";
            this.txtMatchTime.Size = new System.Drawing.Size(153, 30);
            this.txtMatchTime.TabIndex = 19;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(53, 216);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(74, 29);
            this.lbTime.TabIndex = 18;
            this.lbTime.Text = "Time";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(67, 284);
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
            this.lbTeams.Location = new System.Drawing.Point(53, 142);
            this.lbTeams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(96, 29);
            this.lbTeams.TabIndex = 14;
            this.lbTeams.Text = "Teams";
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.Location = new System.Drawing.Point(53, 47);
            this.lblCatCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(117, 29);
            this.lblCatCode.TabIndex = 13;
            this.lblCatCode.Text = "Match Id";
            // 
            // lblticketsold
            // 
            this.lblticketsold.AutoSize = true;
            this.lblticketsold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketsold.Location = new System.Drawing.Point(67, 349);
            this.lblticketsold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblticketsold.Name = "lblticketsold";
            this.lblticketsold.Size = new System.Drawing.Size(142, 29);
            this.lblticketsold.TabIndex = 26;
            this.lblticketsold.Text = "TicketSold";
            // 
            // numericTicketSold
            // 
            this.numericTicketSold.Location = new System.Drawing.Point(228, 351);
            this.numericTicketSold.Name = "numericTicketSold";
            this.numericTicketSold.Size = new System.Drawing.Size(120, 30);
            this.numericTicketSold.TabIndex = 27;
            // 
            // frmScheduleMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmScheduleMatch";
            this.Text = "ScheduleMatch";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicketSold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.TextBox txtMatchTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbTeams;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.Button btnSubmitSchedule;
        private System.Windows.Forms.Label lbvs;
        private System.Windows.Forms.ComboBox cobTeams2;
        private System.Windows.Forms.ComboBox cobTeams1;
        private System.Windows.Forms.DateTimePicker dtpMatchDate;
        private System.Windows.Forms.NumericUpDown numericTicketSold;
        private System.Windows.Forms.Label lblticketsold;
    }
}