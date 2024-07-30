
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
            this.dtpFixture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchTeam = new System.Windows.Forms.Button();
            this.btnBackbutton = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.grpTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTeams
            // 
            this.grpTeams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpTeams.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.grpTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTeams.Controls.Add(this.grdTeams);
            this.grpTeams.Controls.Add(this.dtpFixture);
            this.grpTeams.Controls.Add(this.label1);
            this.grpTeams.Controls.Add(this.btnSearchTeam);
            this.grpTeams.Controls.Add(this.btnBackbutton);
            this.grpTeams.Controls.Add(this.btnAddTeam);
            this.grpTeams.Controls.Add(this.txtTeamName);
            this.grpTeams.Controls.Add(this.lblTeamName);
            this.grpTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeams.Location = new System.Drawing.Point(0, 5);
            this.grpTeams.Margin = new System.Windows.Forms.Padding(4);
            this.grpTeams.Name = "grpTeams";
            this.grpTeams.Padding = new System.Windows.Forms.Padding(4);
            this.grpTeams.Size = new System.Drawing.Size(1075, 568);
            this.grpTeams.TabIndex = 15;
            this.grpTeams.TabStop = false;
            this.grpTeams.Text = "Fixture Time";
            // 
            // grdTeams
            // 
            this.grdTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdTeams.ColumnHeadersHeight = 40;
            this.grdTeams.Location = new System.Drawing.Point(209, 39);
            this.grdTeams.Name = "grdTeams";
            this.grdTeams.RowHeadersWidth = 51;
            this.grdTeams.RowTemplate.Height = 24;
            this.grdTeams.Size = new System.Drawing.Size(676, 232);
            this.grdTeams.TabIndex = 42;
            // 
            // dtpFixture
            // 
            this.dtpFixture.AllowDrop = true;
            this.dtpFixture.Location = new System.Drawing.Point(462, 379);
            this.dtpFixture.Name = "dtpFixture";
            this.dtpFixture.Size = new System.Drawing.Size(345, 30);
            this.dtpFixture.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fixture Time";
            // 
            // btnSearchTeam
            // 
            this.btnSearchTeam.Location = new System.Drawing.Point(916, 149);
            this.btnSearchTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchTeam.Name = "btnSearchTeam";
            this.btnSearchTeam.Size = new System.Drawing.Size(100, 28);
            this.btnSearchTeam.TabIndex = 36;
            this.btnSearchTeam.Text = "Select";
            this.btnSearchTeam.UseVisualStyleBackColor = true;
            // 
            // btnBackbutton
            // 
            this.btnBackbutton.Location = new System.Drawing.Point(950, 8);
            this.btnBackbutton.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackbutton.Name = "btnBackbutton";
            this.btnBackbutton.Size = new System.Drawing.Size(104, 32);
            this.btnBackbutton.TabIndex = 23;
            this.btnBackbutton.Text = " < Back";
            this.btnBackbutton.UseVisualStyleBackColor = true;
            this.btnBackbutton.Click += new System.EventHandler(this.btnBackbutton_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTeam.Location = new System.Drawing.Point(413, 452);
            this.btnAddTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(193, 52);
            this.btnAddTeam.TabIndex = 19;
            this.btnAddTeam.Text = "Update";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(462, 298);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(345, 30);
            this.txtTeamName.TabIndex = 15;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(271, 297);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(162, 29);
            this.lblTeamName.TabIndex = 14;
            this.lblTeamName.Text = "Team Name";
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
            this.Load += new System.EventHandler(this.frmUpdateFixture_Load);
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
        private System.Windows.Forms.Button btnBackbutton;
        private System.Windows.Forms.Button btnSearchTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFixture;
        private System.Windows.Forms.DataGridView grdTeams;
    }
}