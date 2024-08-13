
namespace SoccerSYS
{
    partial class frrmYearlyRevenueAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frrmYearlyRevenueAnalysis));
            this.btnbackYRA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMostSales = new System.Windows.Forms.TextBox();
            this.txtLeastSales = new System.Windows.Forms.TextBox();
            this.txtAvgSales = new System.Windows.Forms.TextBox();
            this.txtTotOfSales = new System.Windows.Forms.TextBox();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbackYRA
            // 
            this.btnbackYRA.Location = new System.Drawing.Point(1, 2);
            this.btnbackYRA.Name = "btnbackYRA";
            this.btnbackYRA.Size = new System.Drawing.Size(75, 23);
            this.btnbackYRA.TabIndex = 15;
            this.btnbackYRA.Text = " < Back";
            this.btnbackYRA.UseVisualStyleBackColor = true;
            this.btnbackYRA.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(480, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 42);
            this.label6.TabIndex = 82;
            this.label6.Text = "Yearly Sales Analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "Most Sales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(293, 450);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "Least Sales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 495);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Average Sales:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(293, 545);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 19);
            this.label9.TabIndex = 86;
            this.label9.Text = "Total Sales for whole season:";
            // 
            // txtMostSales
            // 
            this.txtMostSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMostSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostSales.ForeColor = System.Drawing.Color.White;
            this.txtMostSales.Location = new System.Drawing.Point(412, 412);
            this.txtMostSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtMostSales.Name = "txtMostSales";
            this.txtMostSales.ReadOnly = true;
            this.txtMostSales.Size = new System.Drawing.Size(149, 25);
            this.txtMostSales.TabIndex = 87;
            this.txtMostSales.TabStop = false;
            // 
            // txtLeastSales
            // 
            this.txtLeastSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLeastSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeastSales.ForeColor = System.Drawing.Color.White;
            this.txtLeastSales.Location = new System.Drawing.Point(412, 450);
            this.txtLeastSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeastSales.Name = "txtLeastSales";
            this.txtLeastSales.ReadOnly = true;
            this.txtLeastSales.Size = new System.Drawing.Size(149, 25);
            this.txtLeastSales.TabIndex = 88;
            this.txtLeastSales.TabStop = false;
            // 
            // txtAvgSales
            // 
            this.txtAvgSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAvgSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgSales.ForeColor = System.Drawing.Color.White;
            this.txtAvgSales.Location = new System.Drawing.Point(412, 494);
            this.txtAvgSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvgSales.Name = "txtAvgSales";
            this.txtAvgSales.ReadOnly = true;
            this.txtAvgSales.Size = new System.Drawing.Size(290, 25);
            this.txtAvgSales.TabIndex = 89;
            this.txtAvgSales.TabStop = false;
            // 
            // txtTotOfSales
            // 
            this.txtTotOfSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotOfSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotOfSales.ForeColor = System.Drawing.Color.White;
            this.txtTotOfSales.Location = new System.Drawing.Point(513, 544);
            this.txtTotOfSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotOfSales.Name = "txtTotOfSales";
            this.txtTotOfSales.ReadOnly = true;
            this.txtTotOfSales.Size = new System.Drawing.Size(116, 25);
            this.txtTotOfSales.TabIndex = 90;
            this.txtTotOfSales.TabStop = false;
            // 
            // chartSales
            // 
            this.chartSales.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "Match ID";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Sales";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(197, 75);
            this.chartSales.Margin = new System.Windows.Forms.Padding(2);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartSales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightGray};
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Total Sales";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(913, 311);
            this.chartSales.TabIndex = 91;
            this.chartSales.TabStop = false;
            this.chartSales.Text = "chart1";
            // 
            // frrmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 597);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.txtTotOfSales);
            this.Controls.Add(this.txtAvgSales);
            this.Controls.Add(this.txtLeastSales);
            this.Controls.Add(this.txtMostSales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnbackYRA);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frrmYearlyRevenueAnalysis";
            this.Text = "YearlyRevenueAnalysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frrmYearlyRevenueAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.frrmYearlyRevenueAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbackYRA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMostSales;
        private System.Windows.Forms.TextBox txtLeastSales;
        private System.Windows.Forms.TextBox txtAvgSales;
        private System.Windows.Forms.TextBox txtTotOfSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
    }
}