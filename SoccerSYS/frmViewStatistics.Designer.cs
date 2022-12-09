
namespace SoccerSYS
{
    partial class frmViewStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewStatistics));
            this.button1 = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.lbPossessions = new System.Windows.Forms.Label();
            this.lbRedCard = new System.Windows.Forms.Label();
            this.lbYellowCard = new System.Windows.Forms.Label();
            this.lbOffSides = new System.Windows.Forms.Label();
            this.lbCorners = new System.Windows.Forms.Label();
            this.lbShotsTarget = new System.Windows.Forms.Label();
            this.lbShots = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cobShots = new System.Windows.Forms.ComboBox();
            this.cobShots2 = new System.Windows.Forms.ComboBox();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.lbTeamName2 = new System.Windows.Forms.Label();
            this.cobShotsTarget = new System.Windows.Forms.ComboBox();
            this.cobCorners = new System.Windows.Forms.ComboBox();
            this.cobOffSides = new System.Windows.Forms.ComboBox();
            this.cobYellowCards = new System.Windows.Forms.ComboBox();
            this.cobRedCards = new System.Windows.Forms.ComboBox();
            this.cobShotsTarget2 = new System.Windows.Forms.ComboBox();
            this.cobCorners2 = new System.Windows.Forms.ComboBox();
            this.cobOffSides2 = new System.Windows.Forms.ComboBox();
            this.cobYellowCards2 = new System.Windows.Forms.ComboBox();
            this.cobRedCards2 = new System.Windows.Forms.ComboBox();
            this.cobPossessions2 = new System.Windows.Forms.ComboBox();
            this.cobPossessions = new System.Windows.Forms.ComboBox();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = " < Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpCategory.Controls.Add(this.cobPossessions);
            this.grpCategory.Controls.Add(this.cobPossessions2);
            this.grpCategory.Controls.Add(this.cobRedCards2);
            this.grpCategory.Controls.Add(this.cobYellowCards2);
            this.grpCategory.Controls.Add(this.cobOffSides2);
            this.grpCategory.Controls.Add(this.cobCorners2);
            this.grpCategory.Controls.Add(this.cobShotsTarget2);
            this.grpCategory.Controls.Add(this.cobRedCards);
            this.grpCategory.Controls.Add(this.cobYellowCards);
            this.grpCategory.Controls.Add(this.cobOffSides);
            this.grpCategory.Controls.Add(this.cobCorners);
            this.grpCategory.Controls.Add(this.cobShotsTarget);
            this.grpCategory.Controls.Add(this.lbTeamName2);
            this.grpCategory.Controls.Add(this.lbTeamName);
            this.grpCategory.Controls.Add(this.cobShots2);
            this.grpCategory.Controls.Add(this.cobShots);
            this.grpCategory.Controls.Add(this.lbPossessions);
            this.grpCategory.Controls.Add(this.lbRedCard);
            this.grpCategory.Controls.Add(this.lbYellowCard);
            this.grpCategory.Controls.Add(this.lbOffSides);
            this.grpCategory.Controls.Add(this.lbCorners);
            this.grpCategory.Controls.Add(this.lbShotsTarget);
            this.grpCategory.Controls.Add(this.lbShots);
            this.grpCategory.Controls.Add(this.label1);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpCategory.Location = new System.Drawing.Point(32, 38);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(958, 584);
            this.grpCategory.TabIndex = 18;
            this.grpCategory.TabStop = false;
            // 
            // lbPossessions
            // 
            this.lbPossessions.AutoSize = true;
            this.lbPossessions.Location = new System.Drawing.Point(331, 525);
            this.lbPossessions.Name = "lbPossessions";
            this.lbPossessions.Size = new System.Drawing.Size(307, 36);
            this.lbPossessions.TabIndex = 35;
            this.lbPossessions.Text = "BALL POSSESSION";
            // 
            // lbRedCard
            // 
            this.lbRedCard.AutoSize = true;
            this.lbRedCard.Location = new System.Drawing.Point(374, 454);
            this.lbRedCard.Name = "lbRedCard";
            this.lbRedCard.Size = new System.Drawing.Size(200, 36);
            this.lbRedCard.TabIndex = 34;
            this.lbRedCard.Text = "RED CARDS";
            // 
            // lbYellowCard
            // 
            this.lbYellowCard.AutoSize = true;
            this.lbYellowCard.Location = new System.Drawing.Point(349, 384);
            this.lbYellowCard.Name = "lbYellowCard";
            this.lbYellowCard.Size = new System.Drawing.Size(265, 36);
            this.lbYellowCard.TabIndex = 33;
            this.lbYellowCard.Text = "YELLOW CARDS";
            // 
            // lbOffSides
            // 
            this.lbOffSides.AutoSize = true;
            this.lbOffSides.Location = new System.Drawing.Point(386, 313);
            this.lbOffSides.Name = "lbOffSides";
            this.lbOffSides.Size = new System.Drawing.Size(170, 36);
            this.lbOffSides.TabIndex = 32;
            this.lbOffSides.Text = "OFFSIDES";
            // 
            // lbCorners
            // 
            this.lbCorners.AutoSize = true;
            this.lbCorners.Location = new System.Drawing.Point(385, 246);
            this.lbCorners.Name = "lbCorners";
            this.lbCorners.Size = new System.Drawing.Size(171, 36);
            this.lbCorners.TabIndex = 31;
            this.lbCorners.Text = "CORNERS";
            // 
            // lbShotsTarget
            // 
            this.lbShotsTarget.AutoSize = true;
            this.lbShotsTarget.Location = new System.Drawing.Point(325, 174);
            this.lbShotsTarget.Name = "lbShotsTarget";
            this.lbShotsTarget.Size = new System.Drawing.Size(313, 36);
            this.lbShotsTarget.TabIndex = 30;
            this.lbShotsTarget.Text = "SHOTS ON TARGET";
            // 
            // lbShots
            // 
            this.lbShots.AutoSize = true;
            this.lbShots.Location = new System.Drawing.Point(402, 89);
            this.lbShots.Name = "lbShots";
            this.lbShots.Size = new System.Drawing.Size(121, 36);
            this.lbShots.TabIndex = 29;
            this.lbShots.Text = "SHOTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Match Statistics";
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
            // cobShots
            // 
            this.cobShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobShots.FormattingEnabled = true;
            this.cobShots.Items.AddRange(new object[] {
            "Liverpool - 5 ",
            "Man UTD - 9",
            "Real Madrid - 7"});
            this.cobShots.Location = new System.Drawing.Point(58, 81);
            this.cobShots.Name = "cobShots";
            this.cobShots.Size = new System.Drawing.Size(254, 37);
            this.cobShots.TabIndex = 36;
            // 
            // cobShots2
            // 
            this.cobShots2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobShots2.FormattingEnabled = true;
            this.cobShots2.Items.AddRange(new object[] {
            "8 - Spurs",
            "6 - Chelsea",
            "8 - Barcelona"});
            this.cobShots2.Location = new System.Drawing.Point(661, 86);
            this.cobShots2.Name = "cobShots2";
            this.cobShots2.Size = new System.Drawing.Size(246, 37);
            this.cobShots2.TabIndex = 37;
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Location = new System.Drawing.Point(101, 33);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(108, 36);
            this.lbTeamName.TabIndex = 38;
            this.lbTeamName.Text = "Teams";
            // 
            // lbTeamName2
            // 
            this.lbTeamName2.AutoSize = true;
            this.lbTeamName2.Location = new System.Drawing.Point(718, 38);
            this.lbTeamName2.Name = "lbTeamName2";
            this.lbTeamName2.Size = new System.Drawing.Size(108, 36);
            this.lbTeamName2.TabIndex = 39;
            this.lbTeamName2.Text = "Teams";
            // 
            // cobShotsTarget
            // 
            this.cobShotsTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobShotsTarget.FormattingEnabled = true;
            this.cobShotsTarget.Items.AddRange(new object[] {
            "Liverpool - 5 ",
            "Man UTD - 6",
            "Real Madrid - 7"});
            this.cobShotsTarget.Location = new System.Drawing.Point(58, 161);
            this.cobShotsTarget.Name = "cobShotsTarget";
            this.cobShotsTarget.Size = new System.Drawing.Size(254, 37);
            this.cobShotsTarget.TabIndex = 40;
            // 
            // cobCorners
            // 
            this.cobCorners.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobCorners.FormattingEnabled = true;
            this.cobCorners.Items.AddRange(new object[] {
            "Liverpool - 4",
            "Man UTD - 5",
            "Real Madrid - 7"});
            this.cobCorners.Location = new System.Drawing.Point(58, 238);
            this.cobCorners.Name = "cobCorners";
            this.cobCorners.Size = new System.Drawing.Size(254, 37);
            this.cobCorners.TabIndex = 41;
            // 
            // cobOffSides
            // 
            this.cobOffSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobOffSides.FormattingEnabled = true;
            this.cobOffSides.Items.AddRange(new object[] {
            "Liverpool - 5 ",
            "Man UTD - 6",
            "Real Madrid - 7"});
            this.cobOffSides.Location = new System.Drawing.Point(58, 305);
            this.cobOffSides.Name = "cobOffSides";
            this.cobOffSides.Size = new System.Drawing.Size(254, 37);
            this.cobOffSides.TabIndex = 42;
            // 
            // cobYellowCards
            // 
            this.cobYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobYellowCards.FormattingEnabled = true;
            this.cobYellowCards.Items.AddRange(new object[] {
            "Liverpool - 2",
            "Man UTD - 3",
            "Real Madrid - 2"});
            this.cobYellowCards.Location = new System.Drawing.Point(58, 376);
            this.cobYellowCards.Name = "cobYellowCards";
            this.cobYellowCards.Size = new System.Drawing.Size(254, 37);
            this.cobYellowCards.TabIndex = 43;
            // 
            // cobRedCards
            // 
            this.cobRedCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobRedCards.FormattingEnabled = true;
            this.cobRedCards.Items.AddRange(new object[] {
            "Liverpool - 1",
            "Man UTD - 0",
            "Real Madrid - 1"});
            this.cobRedCards.Location = new System.Drawing.Point(58, 446);
            this.cobRedCards.Name = "cobRedCards";
            this.cobRedCards.Size = new System.Drawing.Size(254, 37);
            this.cobRedCards.TabIndex = 44;
            // 
            // cobShotsTarget2
            // 
            this.cobShotsTarget2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobShotsTarget2.FormattingEnabled = true;
            this.cobShotsTarget2.Items.AddRange(new object[] {
            "4 - Spurs",
            "5 - Chelsea",
            "3 - Barcelona"});
            this.cobShotsTarget2.Location = new System.Drawing.Point(661, 166);
            this.cobShotsTarget2.Name = "cobShotsTarget2";
            this.cobShotsTarget2.Size = new System.Drawing.Size(246, 37);
            this.cobShotsTarget2.TabIndex = 45;
            // 
            // cobCorners2
            // 
            this.cobCorners2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobCorners2.FormattingEnabled = true;
            this.cobCorners2.Items.AddRange(new object[] {
            "4 - Spurs",
            "5 - Chelsea",
            "7 - Barcelona"});
            this.cobCorners2.Location = new System.Drawing.Point(661, 243);
            this.cobCorners2.Name = "cobCorners2";
            this.cobCorners2.Size = new System.Drawing.Size(246, 37);
            this.cobCorners2.TabIndex = 46;
            // 
            // cobOffSides2
            // 
            this.cobOffSides2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobOffSides2.FormattingEnabled = true;
            this.cobOffSides2.Items.AddRange(new object[] {
            "5 - Spurs",
            "6 - Chelsea",
            "6 - Barcelona"});
            this.cobOffSides2.Location = new System.Drawing.Point(661, 305);
            this.cobOffSides2.Name = "cobOffSides2";
            this.cobOffSides2.Size = new System.Drawing.Size(246, 37);
            this.cobOffSides2.TabIndex = 47;
            // 
            // cobYellowCards2
            // 
            this.cobYellowCards2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobYellowCards2.FormattingEnabled = true;
            this.cobYellowCards2.Items.AddRange(new object[] {
            "2 - Spurs",
            "4 - Chelsea",
            "3 - Barcelona"});
            this.cobYellowCards2.Location = new System.Drawing.Point(661, 381);
            this.cobYellowCards2.Name = "cobYellowCards2";
            this.cobYellowCards2.Size = new System.Drawing.Size(246, 37);
            this.cobYellowCards2.TabIndex = 48;
            // 
            // cobRedCards2
            // 
            this.cobRedCards2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobRedCards2.FormattingEnabled = true;
            this.cobRedCards2.Items.AddRange(new object[] {
            "1 - Spurs",
            "0 - Chelsea",
            "0 - Barcelona"});
            this.cobRedCards2.Location = new System.Drawing.Point(661, 446);
            this.cobRedCards2.Name = "cobRedCards2";
            this.cobRedCards2.Size = new System.Drawing.Size(246, 37);
            this.cobRedCards2.TabIndex = 49;
            // 
            // cobPossessions2
            // 
            this.cobPossessions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobPossessions2.FormattingEnabled = true;
            this.cobPossessions2.Items.AddRange(new object[] {
            "40% - Spurs",
            "60% - Chelsea",
            "80% - Barcelona"});
            this.cobPossessions2.Location = new System.Drawing.Point(661, 517);
            this.cobPossessions2.Name = "cobPossessions2";
            this.cobPossessions2.Size = new System.Drawing.Size(246, 37);
            this.cobPossessions2.TabIndex = 50;
            // 
            // cobPossessions
            // 
            this.cobPossessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cobPossessions.FormattingEnabled = true;
            this.cobPossessions.Items.AddRange(new object[] {
            "Liverpool - 60%",
            "Man UTD - 40%",
            "Real Madrid - 20%"});
            this.cobPossessions.Location = new System.Drawing.Point(58, 522);
            this.cobPossessions.Name = "cobPossessions";
            this.cobPossessions.Size = new System.Drawing.Size(254, 37);
            this.cobPossessions.TabIndex = 51;
            // 
            // frmViewStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 641);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewStatistics";
            this.Text = "ViewStatistics";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPossessions;
        private System.Windows.Forms.Label lbRedCard;
        private System.Windows.Forms.Label lbYellowCard;
        private System.Windows.Forms.Label lbOffSides;
        private System.Windows.Forms.Label lbCorners;
        private System.Windows.Forms.Label lbShotsTarget;
        private System.Windows.Forms.Label lbShots;
        private System.Windows.Forms.ComboBox cobShots2;
        private System.Windows.Forms.ComboBox cobShots;
        private System.Windows.Forms.Label lbTeamName2;
        private System.Windows.Forms.Label lbTeamName;
        private System.Windows.Forms.ComboBox cobPossessions;
        private System.Windows.Forms.ComboBox cobPossessions2;
        private System.Windows.Forms.ComboBox cobRedCards2;
        private System.Windows.Forms.ComboBox cobYellowCards2;
        private System.Windows.Forms.ComboBox cobOffSides2;
        private System.Windows.Forms.ComboBox cobCorners2;
        private System.Windows.Forms.ComboBox cobShotsTarget2;
        private System.Windows.Forms.ComboBox cobRedCards;
        private System.Windows.Forms.ComboBox cobYellowCards;
        private System.Windows.Forms.ComboBox cobOffSides;
        private System.Windows.Forms.ComboBox cobCorners;
        private System.Windows.Forms.ComboBox cobShotsTarget;
    }
}