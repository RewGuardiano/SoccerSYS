
namespace SoccerSYS
{
    partial class frmUpdateTeam
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
            this.grdTeams = new System.Windows.Forms.DataGridView();
            this.txtEnterTeamID = new System.Windows.Forms.TextBox();
            this.lblEnterTeamID = new System.Windows.Forms.Label();
            this.btnSearchTeam = new System.Windows.Forms.Button();
            this.btnBackbutton = new System.Windows.Forms.Button();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.grpTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTeams
            // 
            this.grpTeams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpTeams.Controls.Add(this.grdTeams);
            this.grpTeams.Controls.Add(this.txtEnterTeamID);
            this.grpTeams.Controls.Add(this.lblEnterTeamID);
            this.grpTeams.Controls.Add(this.btnSearchTeam);
            this.grpTeams.Controls.Add(this.btnBackbutton);
            this.grpTeams.Controls.Add(this.txtTeamID);
            this.grpTeams.Controls.Add(this.btnAddTeam);
            this.grpTeams.Controls.Add(this.txtTeamName);
            this.grpTeams.Controls.Add(this.lblTeamName);
            this.grpTeams.Controls.Add(this.lblTeamID);
            this.grpTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeams.Location = new System.Drawing.Point(0, 5);
            this.grpTeams.Margin = new System.Windows.Forms.Padding(4);
            this.grpTeams.Name = "grpTeams";
            this.grpTeams.Padding = new System.Windows.Forms.Padding(4);
            this.grpTeams.Size = new System.Drawing.Size(1068, 545);
            this.grpTeams.TabIndex = 15;
            this.grpTeams.TabStop = false;
            this.grpTeams.Text = "Enter Details";
            // 
            // grdTeams
            // 
            this.grdTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeams.Location = new System.Drawing.Point(98, 100);
            this.grdTeams.Margin = new System.Windows.Forms.Padding(4);
            this.grdTeams.Name = "grdTeams";
            this.grdTeams.RowHeadersWidth = 51;
            this.grdTeams.Size = new System.Drawing.Size(877, 158);
            this.grdTeams.TabIndex = 39;
            this.grdTeams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTeams_CellContentClick);
            // 
            // txtEnterTeamID
            // 
            this.txtEnterTeamID.Location = new System.Drawing.Point(413, 41);
            this.txtEnterTeamID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterTeamID.MaxLength = 1;
            this.txtEnterTeamID.Name = "txtEnterTeamID";
            this.txtEnterTeamID.Size = new System.Drawing.Size(284, 30);
            this.txtEnterTeamID.TabIndex = 38;
            this.txtEnterTeamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterTeamID
            // 
            this.lblEnterTeamID.AutoSize = true;
            this.lblEnterTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTeamID.Location = new System.Drawing.Point(181, 42);
            this.lblEnterTeamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterTeamID.Name = "lblEnterTeamID";
            this.lblEnterTeamID.Size = new System.Drawing.Size(189, 29);
            this.lblEnterTeamID.TabIndex = 37;
            this.lblEnterTeamID.Text = "Enter Team ID";
            // 
            // btnSearchTeam
            // 
            this.btnSearchTeam.Location = new System.Drawing.Point(742, 41);
            this.btnSearchTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchTeam.Name = "btnSearchTeam";
            this.btnSearchTeam.Size = new System.Drawing.Size(100, 28);
            this.btnSearchTeam.TabIndex = 36;
            this.btnSearchTeam.Text = "Search";
            this.btnSearchTeam.UseVisualStyleBackColor = true;
            this.btnSearchTeam.Click += new System.EventHandler(this.btnSearchTeam_Click);
            // 
            // btnBackbutton
            // 
            this.btnBackbutton.Location = new System.Drawing.Point(951, 10);
            this.btnBackbutton.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackbutton.Name = "btnBackbutton";
            this.btnBackbutton.Size = new System.Drawing.Size(117, 34);
            this.btnBackbutton.TabIndex = 23;
            this.btnBackbutton.Text = " < Back";
            this.btnBackbutton.UseVisualStyleBackColor = true;
            this.btnBackbutton.Click += new System.EventHandler(this.btnBackbutton_Click);
            // 
            // txtTeamID
            // 
            this.txtTeamID.Location = new System.Drawing.Point(522, 299);
            this.txtTeamID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeamID.MaxLength = 1;
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(175, 30);
            this.txtTeamID.TabIndex = 21;
            this.txtTeamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTeam.Location = new System.Drawing.Point(444, 453);
            this.btnAddTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(193, 52);
            this.btnAddTeam.TabIndex = 19;
            this.btnAddTeam.Text = "Update";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(522, 379);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(279, 30);
            this.txtTeamName.TabIndex = 15;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(325, 380);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(162, 29);
            this.lblTeamName.TabIndex = 14;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(325, 298);
            this.lblTeamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(116, 29);
            this.lblTeamID.TabIndex = 13;
            this.lblTeamID.Text = "Team ID";
            // 
            // frmUpdateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpTeams);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateTeam";
            this.Text = "frmUpdateTeam";
            this.grpTeams.ResumeLayout(false);
            this.grpTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeams;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.Button btnBackbutton;
        private System.Windows.Forms.TextBox txtEnterTeamID;
        private System.Windows.Forms.Label lblEnterTeamID;
        private System.Windows.Forms.Button btnSearchTeam;
        private System.Windows.Forms.DataGridView grdTeams;
    }
}