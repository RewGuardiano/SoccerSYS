
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateFixture));
            this.grpTeams = new System.Windows.Forms.GroupBox();
            this.txtFixtureID = new System.Windows.Forms.TextBox();
            this.lblFixtureID = new System.Windows.Forms.Label();
            this.cobTeamID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdTeams = new System.Windows.Forms.DataGridView();
            this.dtpFixture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackbutton = new System.Windows.Forms.Button();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.grpTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTeams
            // 
            this.grpTeams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpTeams.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.grpTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTeams.Controls.Add(this.txtFixtureID);
            this.grpTeams.Controls.Add(this.lblFixtureID);
            this.grpTeams.Controls.Add(this.cobTeamID);
            this.grpTeams.Controls.Add(this.label2);
            this.grpTeams.Controls.Add(this.grdTeams);
            this.grpTeams.Controls.Add(this.dtpFixture);
            this.grpTeams.Controls.Add(this.label1);
            this.grpTeams.Controls.Add(this.btnBackbutton);
            this.grpTeams.Controls.Add(this.btnUpdateTeam);
            this.grpTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeams.Location = new System.Drawing.Point(0, 4);
            this.grpTeams.Name = "grpTeams";
            this.grpTeams.Size = new System.Drawing.Size(806, 462);
            this.grpTeams.TabIndex = 15;
            this.grpTeams.TabStop = false;
            this.grpTeams.Text = "Fixture Time";
            // 
            // txtFixtureID
            // 
            this.txtFixtureID.Location = new System.Drawing.Point(346, 246);
            this.txtFixtureID.Name = "txtFixtureID";
            this.txtFixtureID.ReadOnly = true;
            this.txtFixtureID.Size = new System.Drawing.Size(260, 26);
            this.txtFixtureID.TabIndex = 46;
            // 
            // lblFixtureID
            // 
            this.lblFixtureID.AutoSize = true;
            this.lblFixtureID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFixtureID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixtureID.Location = new System.Drawing.Point(189, 246);
            this.lblFixtureID.Name = "lblFixtureID";
            this.lblFixtureID.Size = new System.Drawing.Size(105, 25);
            this.lblFixtureID.TabIndex = 45;
            this.lblFixtureID.Text = "Fixture ID";
            // 
            // cobTeamID
            // 
            this.cobTeamID.FormattingEnabled = true;
            this.cobTeamID.Location = new System.Drawing.Point(346, 295);
            this.cobTeamID.Margin = new System.Windows.Forms.Padding(2);
            this.cobTeamID.Name = "cobTeamID";
            this.cobTeamID.Size = new System.Drawing.Size(260, 28);
            this.cobTeamID.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Team ID";
            // 
            // grdTeams
            // 
            this.grdTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdTeams.ColumnHeadersHeight = 40;
            this.grdTeams.Location = new System.Drawing.Point(101, 37);
            this.grdTeams.Margin = new System.Windows.Forms.Padding(2);
            this.grdTeams.Name = "grdTeams";
            this.grdTeams.RowHeadersWidth = 51;
            this.grdTeams.RowTemplate.Height = 24;
            this.grdTeams.Size = new System.Drawing.Size(614, 188);
            this.grdTeams.TabIndex = 42;
            this.grdTeams.SelectionChanged += new System.EventHandler(this.grdTeams_SelectionChanged);
            // 
            // dtpFixture
            // 
            this.dtpFixture.AllowDrop = true;
            this.dtpFixture.Location = new System.Drawing.Point(346, 347);
            this.dtpFixture.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFixture.Name = "dtpFixture";
            this.dtpFixture.Size = new System.Drawing.Size(260, 26);
            this.dtpFixture.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fixture Time";
            // 
            // btnBackbutton
            // 
            this.btnBackbutton.Location = new System.Drawing.Point(712, 6);
            this.btnBackbutton.Name = "btnBackbutton";
            this.btnBackbutton.Size = new System.Drawing.Size(78, 26);
            this.btnBackbutton.TabIndex = 23;
            this.btnBackbutton.Text = " < Back";
            this.btnBackbutton.UseVisualStyleBackColor = true;
            this.btnBackbutton.Click += new System.EventHandler(this.btnBackbutton_Click);
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateTeam.Location = new System.Drawing.Point(308, 392);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(145, 42);
            this.btnUpdateTeam.TabIndex = 19;
            this.btnUpdateTeam.Text = "Update";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // frmUpdateFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTeams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Button btnBackbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFixture;
        private System.Windows.Forms.DataGridView grdTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobTeamID;
        private System.Windows.Forms.Label lblFixtureID;
        private System.Windows.Forms.TextBox txtFixtureID;
    }
}