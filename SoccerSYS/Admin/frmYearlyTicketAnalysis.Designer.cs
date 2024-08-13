
namespace SoccerSYS
{
    partial class frmYearlyTicketAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyTicketAnalysis));
            this.btnbackYTA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chartPopularity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grdTicketAnalysis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMostTicket = new System.Windows.Forms.TextBox();
            this.txtLeastTicket = new System.Windows.Forms.TextBox();
            this.txtAvgTickets = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTicketAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbackYTA
            // 
            this.btnbackYTA.Location = new System.Drawing.Point(2, 1);
            this.btnbackYTA.Name = "btnbackYTA";
            this.btnbackYTA.Size = new System.Drawing.Size(75, 23);
            this.btnbackYTA.TabIndex = 16;
            this.btnbackYTA.Text = " < Back";
            this.btnbackYTA.UseVisualStyleBackColor = true;
            this.btnbackYTA.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(558, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 42);
            this.label6.TabIndex = 40;
            this.label6.Text = "Ticket Analysis";
            // 
            // chartPopularity
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPopularity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPopularity.Legends.Add(legend1);
            this.chartPopularity.Location = new System.Drawing.Point(108, 107);
            this.chartPopularity.Margin = new System.Windows.Forms.Padding(2);
            this.chartPopularity.Name = "chartPopularity";
            this.chartPopularity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPopularity.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightGray};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Seats Sold";
            this.chartPopularity.Series.Add(series1);
            this.chartPopularity.Size = new System.Drawing.Size(536, 272);
            this.chartPopularity.TabIndex = 48;
            this.chartPopularity.TabStop = false;
            this.chartPopularity.Text = "chart1";
            // 
            // grdTicketAnalysis
            // 
            this.grdTicketAnalysis.AllowUserToOrderColumns = true;
            this.grdTicketAnalysis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTicketAnalysis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdTicketAnalysis.ColumnHeadersHeight = 50;
            this.grdTicketAnalysis.Location = new System.Drawing.Point(749, 107);
            this.grdTicketAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.grdTicketAnalysis.Name = "grdTicketAnalysis";
            this.grdTicketAnalysis.RowHeadersWidth = 51;
            this.grdTicketAnalysis.RowTemplate.Height = 24;
            this.grdTicketAnalysis.Size = new System.Drawing.Size(501, 272);
            this.grdTicketAnalysis.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(367, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 88;
            this.label1.Text = "Most Bought Ticket Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(367, 483);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 26);
            this.label4.TabIndex = 89;
            this.label4.Text = "Least Bought Ticket Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 535);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 26);
            this.label2.TabIndex = 93;
            this.label2.Text = "Average Tickets per game:";
            // 
            // txtMostTicket
            // 
            this.txtMostTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMostTicket.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostTicket.ForeColor = System.Drawing.Color.White;
            this.txtMostTicket.Location = new System.Drawing.Point(617, 434);
            this.txtMostTicket.Margin = new System.Windows.Forms.Padding(2);
            this.txtMostTicket.Name = "txtMostTicket";
            this.txtMostTicket.ReadOnly = true;
            this.txtMostTicket.Size = new System.Drawing.Size(234, 25);
            this.txtMostTicket.TabIndex = 94;
            this.txtMostTicket.TabStop = false;
            // 
            // txtLeastTicket
            // 
            this.txtLeastTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLeastTicket.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeastTicket.ForeColor = System.Drawing.Color.White;
            this.txtLeastTicket.Location = new System.Drawing.Point(617, 484);
            this.txtLeastTicket.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeastTicket.Name = "txtLeastTicket";
            this.txtLeastTicket.ReadOnly = true;
            this.txtLeastTicket.Size = new System.Drawing.Size(234, 25);
            this.txtLeastTicket.TabIndex = 95;
            this.txtLeastTicket.TabStop = false;
            // 
            // txtAvgTickets
            // 
            this.txtAvgTickets.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAvgTickets.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgTickets.ForeColor = System.Drawing.Color.White;
            this.txtAvgTickets.Location = new System.Drawing.Point(617, 535);
            this.txtAvgTickets.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvgTickets.Name = "txtAvgTickets";
            this.txtAvgTickets.ReadOnly = true;
            this.txtAvgTickets.Size = new System.Drawing.Size(234, 25);
            this.txtAvgTickets.TabIndex = 96;
            this.txtAvgTickets.TabStop = false;
            // 
            // frmYearlyTicketAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 594);
            this.Controls.Add(this.txtAvgTickets);
            this.Controls.Add(this.txtLeastTicket);
            this.Controls.Add(this.txtMostTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTicketAnalysis);
            this.Controls.Add(this.chartPopularity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnbackYTA);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyTicketAnalysis";
            this.Text = "YearlyTicketAnalysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYearlyTicketAnalysis_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTicketAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbackYTA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopularity;
        private System.Windows.Forms.DataGridView grdTicketAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMostTicket;
        private System.Windows.Forms.TextBox txtLeastTicket;
        private System.Windows.Forms.TextBox txtAvgTickets;
    }
}