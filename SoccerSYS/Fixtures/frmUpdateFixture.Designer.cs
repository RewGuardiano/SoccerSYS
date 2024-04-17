
namespace SoccerSYS
{
    partial class frmUpdateFixture
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
            this.btnSearchTeam = new System.Windows.Forms.Button();
            this.btnBackbutton = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.AwayTeam_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fixture_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEnterTeamID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTeams
            // 
            this.grpTeams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpTeams.Controls.Add(this.textBox1);
            this.grpTeams.Controls.Add(this.label1);
            this.grpTeams.Controls.Add(this.grdTeams);
            this.grpTeams.Controls.Add(this.txtEnterTeamID);
            this.grpTeams.Controls.Add(this.btnSearchTeam);
            this.grpTeams.Controls.Add(this.btnBackbutton);
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
            this.grpTeams.Text = "Fixture Time";
            // 
            // grdTeams
            // 
            this.grdTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwayTeam_ID,
            this.TeamName,
            this.Fixture_Time});
            this.grdTeams.Location = new System.Drawing.Point(295, 45);
            this.grdTeams.Margin = new System.Windows.Forms.Padding(4);
            this.grdTeams.Name = "grdTeams";
            this.grdTeams.RowHeadersWidth = 51;
            this.grdTeams.Size = new System.Drawing.Size(506, 156);
            this.grdTeams.TabIndex = 39;
            this.grdTeams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTeams_CellContentClick);
            // 
            // btnSearchTeam
            // 
            this.btnSearchTeam.Location = new System.Drawing.Point(846, 228);
            this.btnSearchTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchTeam.Name = "btnSearchTeam";
            this.btnSearchTeam.Size = new System.Drawing.Size(100, 28);
            this.btnSearchTeam.TabIndex = 36;
            this.btnSearchTeam.Text = "Select";
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
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTeam.Location = new System.Drawing.Point(453, 464);
            this.btnAddTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(193, 52);
            this.btnAddTeam.TabIndex = 19;
            this.btnAddTeam.Text = "Update";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(484, 325);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(279, 30);
            this.txtTeamName.TabIndex = 15;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(306, 326);
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
            this.lblTeamID.Location = new System.Drawing.Point(306, 248);
            this.lblTeamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(116, 29);
            this.lblTeamID.TabIndex = 13;
            this.lblTeamID.Text = "Team ID";
            // 
            // AwayTeam_ID
            // 
            this.AwayTeam_ID.HeaderText = "AwayTeam ID";
            this.AwayTeam_ID.MinimumWidth = 6;
            this.AwayTeam_ID.Name = "AwayTeam_ID";
            this.AwayTeam_ID.Width = 125;
            // 
            // TeamName
            // 
            this.TeamName.HeaderText = "Team Name ";
            this.TeamName.MinimumWidth = 6;
            this.TeamName.Name = "TeamName";
            this.TeamName.Width = 125;
            // 
            // Fixture_Time
            // 
            this.Fixture_Time.HeaderText = "Fixture Time";
            this.Fixture_Time.MinimumWidth = 6;
            this.Fixture_Time.Name = "Fixture_Time";
            this.Fixture_Time.Width = 125;
            // 
            // txtEnterTeamID
            // 
            this.txtEnterTeamID.Location = new System.Drawing.Point(476, 249);
            this.txtEnterTeamID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterTeamID.MaxLength = 1;
            this.txtEnterTeamID.Name = "txtEnterTeamID";
            this.txtEnterTeamID.Size = new System.Drawing.Size(284, 30);
            this.txtEnterTeamID.TabIndex = 38;
            this.txtEnterTeamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fixture Time";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 394);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 30);
            this.textBox1.TabIndex = 41;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUpdateFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpTeams);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateFixture";
            this.Text = "frmUpdateTeam";
            this.grpTeams.ResumeLayout(false);
            this.grpTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeams;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.Button btnBackbutton;
        private System.Windows.Forms.Button btnSearchTeam;
        private System.Windows.Forms.DataGridView grdTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTeam_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fixture_Time;
        private System.Windows.Forms.TextBox txtEnterTeamID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}