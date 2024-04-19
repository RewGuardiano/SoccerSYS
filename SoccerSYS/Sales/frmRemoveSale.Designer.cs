
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
            this.btnSearchSale = new System.Windows.Forms.Button();
            this.txtTicketIDSale = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.GrdSale = new System.Windows.Forms.DataGridView();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbSaleId = new System.Windows.Forms.Label();
            this.btnRemoveSales = new System.Windows.Forms.Button();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSale)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCategory.Controls.Add(this.btnSearchSale);
            this.grpCategory.Controls.Add(this.txtTicketIDSale);
            this.grpCategory.Controls.Add(this.btnConfirm);
            this.grpCategory.Controls.Add(this.GrdSale);
            this.grpCategory.Controls.Add(this.lblTicketID);
            this.grpCategory.Controls.Add(this.txtSaleID);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbSaleId);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(177, 24);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(952, 514);
            this.grpCategory.TabIndex = 18;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Details";
            // 
            // btnSearchSale
            // 
            this.btnSearchSale.Location = new System.Drawing.Point(824, 169);
            this.btnSearchSale.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSale.Name = "btnSearchSale";
            this.btnSearchSale.Size = new System.Drawing.Size(100, 28);
            this.btnSearchSale.TabIndex = 41;
            this.btnSearchSale.Text = "Search";
            this.btnSearchSale.UseVisualStyleBackColor = true;
            // 
            // txtTicketIDSale
            // 
            this.txtTicketIDSale.Location = new System.Drawing.Point(163, 167);
            this.txtTicketIDSale.Name = "txtTicketIDSale";
            this.txtTicketIDSale.Size = new System.Drawing.Size(196, 30);
            this.txtTicketIDSale.TabIndex = 26;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(371, 372);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 45);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // GrdSale
            // 
            this.GrdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSale.Location = new System.Drawing.Point(381, 115);
            this.GrdSale.Name = "GrdSale";
            this.GrdSale.RowHeadersWidth = 51;
            this.GrdSale.RowTemplate.Height = 24;
            this.GrdSale.Size = new System.Drawing.Size(406, 150);
            this.GrdSale.TabIndex = 19;
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.Location = new System.Drawing.Point(30, 167);
            this.lblTicketID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(113, 29);
            this.lblTicketID.TabIndex = 18;
            this.lblTicketID.Text = "TicketID";
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(259, 51);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(380, 30);
            this.txtSaleID.TabIndex = 17;
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
            // lbSaleId
            // 
            this.lbSaleId.AutoSize = true;
            this.lbSaleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaleId.Location = new System.Drawing.Point(97, 52);
            this.lbSaleId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaleId.Name = "lbSaleId";
            this.lbSaleId.Size = new System.Drawing.Size(94, 29);
            this.lbSaleId.TabIndex = 13;
            this.lbSaleId.Text = "SaleID";
            // 
            // btnRemoveSales
            // 
            this.btnRemoveSales.Location = new System.Drawing.Point(13, 13);
            this.btnRemoveSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSales.Name = "btnRemoveSales";
            this.btnRemoveSales.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveSales.TabIndex = 19;
            this.btnRemoveSales.Text = " < Back";
            this.btnRemoveSales.UseVisualStyleBackColor = true;
            this.btnRemoveSales.Click += new System.EventHandler(this.btnRemoveSales_Click);
            // 
            // frmRemoveSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 574);
            this.Controls.Add(this.btnRemoveSales);
            this.Controls.Add(this.grpCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveSale";
            this.Text = "FrmRemoveSale";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Button btnSearchSale;
        private System.Windows.Forms.TextBox txtTicketIDSale;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView GrdSale;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbSaleId;
        private System.Windows.Forms.Button btnRemoveSales;
    }
}