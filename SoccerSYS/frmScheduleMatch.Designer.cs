
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
            this.btnSubmitSchedule = new System.Windows.Forms.Button();
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.txtMatchDate = new System.Windows.Forms.TextBox();
            this.txtMatchTime = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtTeams = new System.Windows.Forms.TextBox();
            this.lbTeams = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
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
            this.grpCategory.Controls.Add(this.btnSubmitSchedule);
            this.grpCategory.Controls.Add(this.txtMatchID);
            this.grpCategory.Controls.Add(this.txtMatchDate);
            this.grpCategory.Controls.Add(this.txtMatchTime);
            this.grpCategory.Controls.Add(this.lbTime);
            this.grpCategory.Controls.Add(this.lbDate);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.txtTeams);
            this.grpCategory.Controls.Add(this.lbTeams);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(86, 31);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(894, 493);
            this.grpCategory.TabIndex = 15;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Match Details:";
            // 
            // btnSubmitSchedule
            // 
            this.btnSubmitSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitSchedule.Location = new System.Drawing.Point(228, 413);
            this.btnSubmitSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitSchedule.Name = "btnSubmitSchedule";
            this.btnSubmitSchedule.Size = new System.Drawing.Size(193, 72);
            this.btnSubmitSchedule.TabIndex = 22;
            this.btnSubmitSchedule.Text = "Submit";
            this.btnSubmitSchedule.UseVisualStyleBackColor = true;
            this.btnSubmitSchedule.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMatchID
            // 
            this.txtMatchID.Location = new System.Drawing.Point(228, 48);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.Size = new System.Drawing.Size(181, 30);
            this.txtMatchID.TabIndex = 21;
            // 
            // txtMatchDate
            // 
            this.txtMatchDate.Location = new System.Drawing.Point(228, 336);
            this.txtMatchDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatchDate.Name = "txtMatchDate";
            this.txtMatchDate.Size = new System.Drawing.Size(305, 30);
            this.txtMatchDate.TabIndex = 20;
            // 
            // txtMatchTime
            // 
            this.txtMatchTime.Location = new System.Drawing.Point(228, 246);
            this.txtMatchTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatchTime.Name = "txtMatchTime";
            this.txtMatchTime.Size = new System.Drawing.Size(154, 30);
            this.txtMatchTime.TabIndex = 19;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(66, 247);
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
            this.lbDate.Location = new System.Drawing.Point(66, 335);
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
            // txtTeams
            // 
            this.txtTeams.Location = new System.Drawing.Point(228, 142);
            this.txtTeams.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeams.Name = "txtTeams";
            this.txtTeams.Size = new System.Drawing.Size(273, 30);
            this.txtTeams.TabIndex = 15;
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
            // frmScheduleMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScheduleMatch";
            this.Text = "ScheduleMatch";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.TextBox txtMatchDate;
        private System.Windows.Forms.TextBox txtMatchTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtTeams;
        private System.Windows.Forms.Label lbTeams;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.Button btnSubmitSchedule;
    }
}