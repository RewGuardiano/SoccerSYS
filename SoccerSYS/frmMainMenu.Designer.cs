
namespace SoccerSYS
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblSoccerTitle = new System.Windows.Forms.Label();
            this.mbaManageCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mbasetCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mbaRemoveCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mbaUpdateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mbaUpdateFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.mbascheduleMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mbaCancelMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mbaProcessSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mbaSellTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mbaPerformAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mbayearlyTicketRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoccerTitle
            // 
            this.lblSoccerTitle.AutoSize = true;
            this.lblSoccerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSoccerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoccerTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoccerTitle.Location = new System.Drawing.Point(282, 58);
            this.lblSoccerTitle.Name = "lblSoccerTitle";
            this.lblSoccerTitle.Size = new System.Drawing.Size(255, 37);
            this.lblSoccerTitle.TabIndex = 2;
            this.lblSoccerTitle.Text = "Soccer Booking";
            // 
            // mbaManageCategories
            // 
            this.mbaManageCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbasetCategory,
            this.mbaRemoveCategory,
            this.mbaUpdateCategory});
            this.mbaManageCategories.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic);
            this.mbaManageCategories.Name = "mbaManageCategories";
            this.mbaManageCategories.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.mbaManageCategories.Size = new System.Drawing.Size(228, 30);
            this.mbaManageCategories.Text = "Manage Categories";
            this.mbaManageCategories.Click += new System.EventHandler(this.mbuManageCategories_Click);
            // 
            // mbasetCategory
            // 
            this.mbasetCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbasetCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbasetCategory.Name = "mbasetCategory";
            this.mbasetCategory.Size = new System.Drawing.Size(195, 24);
            this.mbasetCategory.Text = "Set Category";
            this.mbasetCategory.Click += new System.EventHandler(this.setCategoryToolStripMenuItem_Click);
            // 
            // mbaRemoveCategory
            // 
            this.mbaRemoveCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbaRemoveCategory.Name = "mbaRemoveCategory";
            this.mbaRemoveCategory.Size = new System.Drawing.Size(195, 24);
            this.mbaRemoveCategory.Text = "Remove Category";
            this.mbaRemoveCategory.Click += new System.EventHandler(this.removeCategoryToolStripMenuItem_Click);
            // 
            // mbaUpdateCategory
            // 
            this.mbaUpdateCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbaUpdateCategory.Name = "mbaUpdateCategory";
            this.mbaUpdateCategory.Size = new System.Drawing.Size(195, 24);
            this.mbaUpdateCategory.Text = "Update Category";
            this.mbaUpdateCategory.Click += new System.EventHandler(this.mbuUpdateCategory_Click);
            // 
            // mbaUpdateFixtures
            // 
            this.mbaUpdateFixtures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbascheduleMatch,
            this.mbaCancelMatch});
            this.mbaUpdateFixtures.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic);
            this.mbaUpdateFixtures.Name = "mbaUpdateFixtures";
            this.mbaUpdateFixtures.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.mbaUpdateFixtures.Size = new System.Drawing.Size(204, 30);
            this.mbaUpdateFixtures.Text = "Manage Fixtures";
            // 
            // mbascheduleMatch
            // 
            this.mbascheduleMatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbascheduleMatch.Name = "mbascheduleMatch";
            this.mbascheduleMatch.Size = new System.Drawing.Size(192, 26);
            this.mbascheduleMatch.Text = "Schedule Match";
            this.mbascheduleMatch.Click += new System.EventHandler(this.scheduleMatchToolStripMenuItem_Click);
            // 
            // mbaCancelMatch
            // 
            this.mbaCancelMatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbaCancelMatch.Name = "mbaCancelMatch";
            this.mbaCancelMatch.Size = new System.Drawing.Size(192, 26);
            this.mbaCancelMatch.Text = "Cancel Match";
            this.mbaCancelMatch.Click += new System.EventHandler(this.cancelMatchToolStripMenuItem_Click);
            // 
            // mbaProcessSales
            // 
            this.mbaProcessSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbaSellTickets});
            this.mbaProcessSales.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic);
            this.mbaProcessSales.Name = "mbaProcessSales";
            this.mbaProcessSales.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.mbaProcessSales.Size = new System.Drawing.Size(173, 30);
            this.mbaProcessSales.Text = "Process Sales";
            this.mbaProcessSales.Click += new System.EventHandler(this.mbuProcessSales_Click);
            // 
            // mbaSellTickets
            // 
            this.mbaSellTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbaSellTickets.Name = "mbaSellTickets";
            this.mbaSellTickets.Size = new System.Drawing.Size(158, 26);
            this.mbaSellTickets.Text = "Sell Tickets";
            this.mbaSellTickets.Click += new System.EventHandler(this.sellTicketsToolStripMenuItem_Click);
            // 
            // mbaPerformAdmin
            // 
            this.mbaPerformAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysis,
            this.mbayearlyTicketRevenueAnalysis});
            this.mbaPerformAdmin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic);
            this.mbaPerformAdmin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.mbaPerformAdmin.Name = "mbaPerformAdmin";
            this.mbaPerformAdmin.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.mbaPerformAdmin.Size = new System.Drawing.Size(190, 30);
            this.mbaPerformAdmin.Text = "Perform Admin";
            this.mbaPerformAdmin.Click += new System.EventHandler(this.performAdminToolStripMenuItem_Click);
            // 
            // yearlyRevenueAnalysis
            // 
            this.yearlyRevenueAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyRevenueAnalysis.Name = "yearlyRevenueAnalysis";
            this.yearlyRevenueAnalysis.Size = new System.Drawing.Size(293, 26);
            this.yearlyRevenueAnalysis.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysis.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // mbayearlyTicketRevenueAnalysis
            // 
            this.mbayearlyTicketRevenueAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbayearlyTicketRevenueAnalysis.Name = "mbayearlyTicketRevenueAnalysis";
            this.mbayearlyTicketRevenueAnalysis.Size = new System.Drawing.Size(293, 26);
            this.mbayearlyTicketRevenueAnalysis.Text = "Yearly Ticket Revenue Analysis";
            this.mbayearlyTicketRevenueAnalysis.Click += new System.EventHandler(this.yearlyTicketRevenueAnalysisToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbaManageCategories,
            this.mbaUpdateFixtures,
            this.mbaProcessSales,
            this.mbaPerformAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(793, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 352);
            this.Controls.Add(this.lblSoccerTitle);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Soccer Booking System";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoccerTitle;
        private System.Windows.Forms.ToolStripMenuItem mbaManageCategories;
        private System.Windows.Forms.ToolStripMenuItem mbasetCategory;
        private System.Windows.Forms.ToolStripMenuItem mbaRemoveCategory;
        private System.Windows.Forms.ToolStripMenuItem mbaUpdateCategory;
        private System.Windows.Forms.ToolStripMenuItem mbaUpdateFixtures;
        private System.Windows.Forms.ToolStripMenuItem mbascheduleMatch;
        private System.Windows.Forms.ToolStripMenuItem mbaCancelMatch;
        private System.Windows.Forms.ToolStripMenuItem mbaProcessSales;
        private System.Windows.Forms.ToolStripMenuItem mbaSellTickets;
        private System.Windows.Forms.ToolStripMenuItem mbaPerformAdmin;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mbayearlyTicketRevenueAnalysis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}