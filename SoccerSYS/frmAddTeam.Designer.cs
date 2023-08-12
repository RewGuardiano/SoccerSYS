
namespace SoccerSYS
{
    partial class frmAddTeam
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
            this.grpTeams = new System.Windows.Forms.GroupBox();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.btnBackbutton = new System.Windows.Forms.Button();
            this.grpTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTeams
            // 
            this.grpTeams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpTeams.Controls.Add(this.btnBackbutton);
            this.grpTeams.Controls.Add(this.txtTeamID);
            this.grpTeams.Controls.Add(this.btnAddTeam);
            this.grpTeams.Controls.Add(this.txtTeamName);
            this.grpTeams.Controls.Add(this.lblTeamName);
            this.grpTeams.Controls.Add(this.lblTeamID);
            this.grpTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeams.Location = new System.Drawing.Point(0, 5);
            this.grpTeams.Name = "grpTeams";
            this.grpTeams.Size = new System.Drawing.Size(801, 443);
            this.grpTeams.TabIndex = 14;
            this.grpTeams.TabStop = false;
            this.grpTeams.Text = "Enter Details";
            // 
            // txtTeamID
            // 
            this.txtTeamID.Location = new System.Drawing.Point(401, 104);
            this.txtTeamID.MaxLength = 20;
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(132, 26);
            this.txtTeamID.TabIndex = 21;
            this.txtTeamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTeam.Location = new System.Drawing.Point(324, 281);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(145, 42);
            this.btnAddTeam.TabIndex = 19;
            this.btnAddTeam.Text = "Confirm";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(229, 105);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(94, 25);
            this.lblTeamID.TabIndex = 13;
            this.lblTeamID.Text = "Team ID";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(229, 190);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(129, 25);
            this.lblTeamName.TabIndex = 14;
            this.lblTeamName.Text = "Team Name";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(401, 189);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(210, 26);
            this.txtTeamName.TabIndex = 15;
            // 
            // btnBackbutton
            // 
            this.btnBackbutton.Location = new System.Drawing.Point(707, 16);
            this.btnBackbutton.Name = "btnBackbutton";
            this.btnBackbutton.Size = new System.Drawing.Size(88, 28);
            this.btnBackbutton.TabIndex = 22;
            this.btnBackbutton.Text = " < Back";
            this.btnBackbutton.UseVisualStyleBackColor = true;
            this.btnBackbutton.Click += new System.EventHandler(this.btnBackbutton_Click);
            // 
            // frmAddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTeams);
            this.Name = "frmAddTeam";
            this.Text = "frmAddTeam";
            this.grpTeams.ResumeLayout(false);
            this.grpTeams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeams;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Button btnBackbutton;
    }
}