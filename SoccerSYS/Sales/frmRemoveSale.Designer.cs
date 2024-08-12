
namespace SoccerSYS
{
    partial class frmRemoveSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveSale));
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.grdSales = new System.Windows.Forms.DataGridView();
            this.grpSaleDetails = new System.Windows.Forms.GroupBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotSales = new System.Windows.Forms.TextBox();
            this.dtPickSalesDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemoveSales = new System.Windows.Forms.Button();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).BeginInit();
            this.grpSaleDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCategory.Controls.Add(this.grdSales);
            this.grpCategory.Controls.Add(this.grpSaleDetails);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(94, 41);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(814, 481);
            this.grpCategory.TabIndex = 18;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Remove  Sale";
            // 
            // grdSales
            // 
            this.grdSales.AllowUserToOrderColumns = true;
            this.grdSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSales.ColumnHeadersHeight = 50;
            this.grdSales.Location = new System.Drawing.Point(32, 47);
            this.grdSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdSales.Name = "grdSales";
            this.grdSales.RowHeadersWidth = 51;
            this.grdSales.RowTemplate.Height = 24;
            this.grdSales.Size = new System.Drawing.Size(754, 208);
            this.grdSales.TabIndex = 43;
            this.grdSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSales_CellContentClick);
            // 
            // grpSaleDetails
            // 
            this.grpSaleDetails.Controls.Add(this.txtSaleID);
            this.grpSaleDetails.Controls.Add(this.label1);
            this.grpSaleDetails.Controls.Add(this.txtEmail);
            this.grpSaleDetails.Controls.Add(this.label3);
            this.grpSaleDetails.Controls.Add(this.txtTotSales);
            this.grpSaleDetails.Controls.Add(this.dtPickSalesDate);
            this.grpSaleDetails.Controls.Add(this.label9);
            this.grpSaleDetails.Controls.Add(this.label8);
            this.grpSaleDetails.Controls.Add(this.txtMatchID);
            this.grpSaleDetails.Controls.Add(this.label2);
            this.grpSaleDetails.Controls.Add(this.btnReturn);
            this.grpSaleDetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaleDetails.Location = new System.Drawing.Point(58, 274);
            this.grpSaleDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleDetails.Name = "grpSaleDetails";
            this.grpSaleDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleDetails.Size = new System.Drawing.Size(682, 174);
            this.grpSaleDetails.TabIndex = 38;
            this.grpSaleDetails.TabStop = false;
            this.grpSaleDetails.Text = "Sale details";
            this.grpSaleDetails.Visible = false;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleID.Location = new System.Drawing.Point(104, 22);
            this.txtSaleID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.ReadOnly = true;
            this.txtSaleID.Size = new System.Drawing.Size(228, 27);
            this.txtSaleID.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Sale ID:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(104, 63);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(228, 27);
            this.txtEmail.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Email:";
            // 
            // txtTotSales
            // 
            this.txtTotSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSales.Location = new System.Drawing.Point(488, 78);
            this.txtTotSales.Name = "txtTotSales";
            this.txtTotSales.ReadOnly = true;
            this.txtTotSales.Size = new System.Drawing.Size(176, 27);
            this.txtTotSales.TabIndex = 70;
            // 
            // dtPickSalesDate
            // 
            this.dtPickSalesDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickSalesDate.Enabled = false;
            this.dtPickSalesDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickSalesDate.Location = new System.Drawing.Point(104, 116);
            this.dtPickSalesDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPickSalesDate.Name = "dtPickSalesDate";
            this.dtPickSalesDate.Size = new System.Drawing.Size(241, 27);
            this.dtPickSalesDate.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Sale Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(385, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "Sub Total:";
            // 
            // txtMatchID
            // 
            this.txtMatchID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchID.Location = new System.Drawing.Point(488, 38);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.ReadOnly = true;
            this.txtMatchID.Size = new System.Drawing.Size(176, 27);
            this.txtMatchID.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(382, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Fixture ID:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Location = new System.Drawing.Point(526, 129);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(85, 29);
            this.btnReturn.TabIndex = 60;
            this.btnReturn.Text = "REMOVE";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(40, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 25);
            this.lblPrice.TabIndex = 16;
            // 
            // btnRemoveSales
            // 
            this.btnRemoveSales.Location = new System.Drawing.Point(10, 11);
            this.btnRemoveSales.Name = "btnRemoveSales";
            this.btnRemoveSales.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSales.TabIndex = 19;
            this.btnRemoveSales.Text = " < Back";
            this.btnRemoveSales.UseVisualStyleBackColor = true;
            this.btnRemoveSales.Click += new System.EventHandler(this.btnRemoveSales_Click);
            // 
            // frmRemoveSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 544);
            this.Controls.Add(this.btnRemoveSales);
            this.Controls.Add(this.grpCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRemoveSale";
            this.Text = "FrmRemoveSale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRemoveSale_FormClosed);
            this.Load += new System.EventHandler(this.frmRemoveSale_Load);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).EndInit();
            this.grpSaleDetails.ResumeLayout(false);
            this.grpSaleDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRemoveSales;
        private System.Windows.Forms.GroupBox grpSaleDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotSales;
        private System.Windows.Forms.DateTimePicker dtPickSalesDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.DataGridView grdSales;
    }
}