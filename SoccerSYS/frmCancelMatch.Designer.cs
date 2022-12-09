
namespace SoccerSYS
{
    partial class frmCancelMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelMatch));
            this.btnCancelMatch = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.txtMatchDate = new System.Windows.Forms.TextBox();
            this.cobMatchTime = new System.Windows.Forms.ComboBox();
            this.cobTeams = new System.Windows.Forms.ComboBox();
            this.cobMatchID = new System.Windows.Forms.ComboBox();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbdescription = new System.Windows.Forms.Label();
            this.lbMatchID = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelMatch
            // 
            this.btnCancelMatch.Location = new System.Drawing.Point(1, 4);
            this.btnCancelMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelMatch.Name = "btnCancelMatch";
            this.btnCancelMatch.Size = new System.Drawing.Size(100, 28);
            this.btnCancelMatch.TabIndex = 12;
            this.btnCancelMatch.Text = " < Back";
            this.btnCancelMatch.UseVisualStyleBackColor = true;
            this.btnCancelMatch.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.txtMatchDate);
            this.grpCategory.Controls.Add(this.cobMatchTime);
            this.grpCategory.Controls.Add(this.cobTeams);
            this.grpCategory.Controls.Add(this.cobMatchID);
            this.grpCategory.Controls.Add(this.btnCancelSubmit);
            this.grpCategory.Controls.Add(this.lbTime);
            this.grpCategory.Controls.Add(this.lbDate);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbdescription);
            this.grpCategory.Controls.Add(this.lbMatchID);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(86, 31);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(894, 493);
            this.grpCategory.TabIndex = 16;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Match Details:";
            this.grpCategory.Enter += new System.EventHandler(this.grpCategory_Enter);
            // 
            // txtMatchDate
            // 
            this.txtMatchDate.Location = new System.Drawing.Point(257, 328);
            this.txtMatchDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatchDate.Name = "txtMatchDate";
            this.txtMatchDate.Size = new System.Drawing.Size(305, 30);
            this.txtMatchDate.TabIndex = 27;
            // 
            // cobMatchTime
            // 
            this.cobMatchTime.FormattingEnabled = true;
            this.cobMatchTime.Location = new System.Drawing.Point(257, 242);
            this.cobMatchTime.Name = "cobMatchTime";
            this.cobMatchTime.Size = new System.Drawing.Size(171, 33);
            this.cobMatchTime.TabIndex = 26;
            // 
            // cobTeams
            // 
            this.cobTeams.FormattingEnabled = true;
            this.cobTeams.Location = new System.Drawing.Point(257, 142);
            this.cobTeams.Name = "cobTeams";
            this.cobTeams.Size = new System.Drawing.Size(260, 33);
            this.cobTeams.TabIndex = 25;
            // 
            // cobMatchID
            // 
            this.cobMatchID.FormattingEnabled = true;
            this.cobMatchID.Location = new System.Drawing.Point(257, 48);
            this.cobMatchID.Name = "cobMatchID";
            this.cobMatchID.Size = new System.Drawing.Size(121, 33);
            this.cobMatchID.TabIndex = 24;
            // 
            // btnCancelSubmit
            // 
            this.btnCancelSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelSubmit.Location = new System.Drawing.Point(257, 413);
            this.btnCancelSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSubmit.Name = "btnCancelSubmit";
            this.btnCancelSubmit.Size = new System.Drawing.Size(193, 72);
            this.btnCancelSubmit.TabIndex = 22;
            this.btnCancelSubmit.Text = "Submit";
            this.btnCancelSubmit.UseVisualStyleBackColor = true;
            this.btnCancelSubmit.Click += new System.EventHandler(this.btnCancelSubmit_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(89, 246);
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
            this.lbDate.Location = new System.Drawing.Point(93, 327);
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
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescription.Location = new System.Drawing.Point(89, 146);
            this.lbdescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(96, 29);
            this.lbdescription.TabIndex = 14;
            this.lbdescription.Text = "Teams";
            // 
            // lbMatchID
            // 
            this.lbMatchID.AutoSize = true;
            this.lbMatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatchID.Location = new System.Drawing.Point(89, 52);
            this.lbMatchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatchID.Name = "lbMatchID";
            this.lbMatchID.Size = new System.Drawing.Size(117, 29);
            this.lbMatchID.TabIndex = 13;
            this.lbMatchID.Text = "Match Id";
            // 
            // frmCancelMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnCancelMatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCancelMatch";
            this.Text = "CancelMatch";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMatch;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Button btnCancelSubmit;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.Label lbMatchID;
        private System.Windows.Forms.ComboBox cobMatchTime;
        private System.Windows.Forms.ComboBox cobTeams;
        private System.Windows.Forms.ComboBox cobMatchID;
        private System.Windows.Forms.TextBox txtMatchDate;
    }
}