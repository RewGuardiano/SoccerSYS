
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbuManageCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mbuUpdateFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.mbuProcessSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mbuPerformAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.setCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyTicketRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbuManageCategories,
            this.mbuUpdateFixtures,
            this.mbuProcessSales,
            this.mbuPerformAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbuManageCategories
            // 
            this.mbuManageCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCategoryToolStripMenuItem,
            this.updateCategoryToolStripMenuItem,
            this.removeCategoryToolStripMenuItem});
            this.mbuManageCategories.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbuManageCategories.Name = "mbuManageCategories";
            this.mbuManageCategories.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.mbuManageCategories.Size = new System.Drawing.Size(228, 34);
            this.mbuManageCategories.Text = "Manage Categories";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mbuUpdateFixtures
            // 
            this.mbuUpdateFixtures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleMatchToolStripMenuItem,
            this.cancelMatchToolStripMenuItem,
            this.checkAvailabilityToolStripMenuItem,
            this.viewStatsToolStripMenuItem});
            this.mbuUpdateFixtures.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbuUpdateFixtures.Name = "mbuUpdateFixtures";
            this.mbuUpdateFixtures.Padding = new System.Windows.Forms.Padding(35, 0, 4, 0);
            this.mbuUpdateFixtures.Size = new System.Drawing.Size(195, 34);
            this.mbuUpdateFixtures.Text = "Update Fixtures";
            // 
            // mbuProcessSales
            // 
            this.mbuProcessSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellTicketsToolStripMenuItem});
            this.mbuProcessSales.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbuProcessSales.Name = "mbuProcessSales";
            this.mbuProcessSales.Padding = new System.Windows.Forms.Padding(35, 0, 4, 0);
            this.mbuProcessSales.Size = new System.Drawing.Size(171, 34);
            this.mbuProcessSales.Text = "Process Sales";
            this.mbuProcessSales.Click += new System.EventHandler(this.mbuProcessSales_Click);
            // 
            // mbuPerformAdmin
            // 
            this.mbuPerformAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.yearlyTicketRevenueAnalysisToolStripMenuItem});
            this.mbuPerformAdmin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbuPerformAdmin.Name = "mbuPerformAdmin";
            this.mbuPerformAdmin.Padding = new System.Windows.Forms.Padding(35, 0, 4, 0);
            this.mbuPerformAdmin.Size = new System.Drawing.Size(192, 34);
            this.mbuPerformAdmin.Text = "Perform Admin";
            this.mbuPerformAdmin.Click += new System.EventHandler(this.performAdminToolStripMenuItem_Click);
            // 
            // setCategoryToolStripMenuItem
            // 
            this.setCategoryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setCategoryToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCategoryToolStripMenuItem.Name = "setCategoryToolStripMenuItem";
            this.setCategoryToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.setCategoryToolStripMenuItem.Text = "Set Category";
            this.setCategoryToolStripMenuItem.Click += new System.EventHandler(this.setCategoryToolStripMenuItem_Click);
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            this.updateCategoryToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.updateCategoryToolStripMenuItem.Text = "Update Category";
            // 
            // removeCategoryToolStripMenuItem
            // 
            this.removeCategoryToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCategoryToolStripMenuItem.Name = "removeCategoryToolStripMenuItem";
            this.removeCategoryToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.removeCategoryToolStripMenuItem.Text = "Remove Category";
            // 
            // scheduleMatchToolStripMenuItem
            // 
            this.scheduleMatchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleMatchToolStripMenuItem.Name = "scheduleMatchToolStripMenuItem";
            this.scheduleMatchToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.scheduleMatchToolStripMenuItem.Text = "Schedule Match";
            // 
            // cancelMatchToolStripMenuItem
            // 
            this.cancelMatchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelMatchToolStripMenuItem.Name = "cancelMatchToolStripMenuItem";
            this.cancelMatchToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.cancelMatchToolStripMenuItem.Text = "Cancel Match";
            // 
            // checkAvailabilityToolStripMenuItem
            // 
            this.checkAvailabilityToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAvailabilityToolStripMenuItem.Name = "checkAvailabilityToolStripMenuItem";
            this.checkAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.checkAvailabilityToolStripMenuItem.Text = "Check Availability";
            // 
            // viewStatsToolStripMenuItem
            // 
            this.viewStatsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStatsToolStripMenuItem.Name = "viewStatsToolStripMenuItem";
            this.viewStatsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.viewStatsToolStripMenuItem.Text = "View Fixture Stats";
            this.viewStatsToolStripMenuItem.Click += new System.EventHandler(this.viewStatsToolStripMenuItem_Click);
            // 
            // sellTicketsToolStripMenuItem
            // 
            this.sellTicketsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellTicketsToolStripMenuItem.Name = "sellTicketsToolStripMenuItem";
            this.sellTicketsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sellTicketsToolStripMenuItem.Text = "Sell Tickets";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            // 
            // yearlyTicketRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyTicketRevenueAnalysisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyTicketRevenueAnalysisToolStripMenuItem.Name = "yearlyTicketRevenueAnalysisToolStripMenuItem";
            this.yearlyTicketRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.yearlyTicketRevenueAnalysisToolStripMenuItem.Text = "Yearly Ticket Revenue Analysis";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbuManageCategories;
        private System.Windows.Forms.ToolStripMenuItem setCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbuUpdateFixtures;
        private System.Windows.Forms.ToolStripMenuItem scheduleMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbuProcessSales;
        private System.Windows.Forms.ToolStripMenuItem mbuPerformAdmin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sellTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyTicketRevenueAnalysisToolStripMenuItem;
    }
}