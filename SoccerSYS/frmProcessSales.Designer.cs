
namespace SoccerSYS
{
    partial class frmProcessSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessSales));
            this.btnbackProcessSales = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cobMatchID = new System.Windows.Forms.ComboBox();
            this.btnProcessSalesSubmit = new System.Windows.Forms.Button();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbackProcessSales
            // 
            this.btnbackProcessSales.Location = new System.Drawing.Point(4, 4);
            this.btnbackProcessSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnbackProcessSales.Name = "btnbackProcessSales";
            this.btnbackProcessSales.Size = new System.Drawing.Size(100, 28);
            this.btnbackProcessSales.TabIndex = 14;
            this.btnbackProcessSales.Text = " < Back";
            this.btnbackProcessSales.UseVisualStyleBackColor = true;
            this.btnbackProcessSales.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.txtQty);
            this.grpCategory.Controls.Add(this.txtTotalPrice);
            this.grpCategory.Controls.Add(this.cobMatchID);
            this.grpCategory.Controls.Add(this.btnProcessSalesSubmit);
            this.grpCategory.Controls.Add(this.lbQuantity);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbTotalPrice);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(86, 31);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(894, 493);
            this.grpCategory.TabIndex = 17;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Ticket Details:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(257, 147);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(193, 30);
            this.txtTotalPrice.TabIndex = 27;
            // 
            // cobMatchID
            // 
            this.cobMatchID.FormattingEnabled = true;
            this.cobMatchID.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cobMatchID.Location = new System.Drawing.Point(257, 48);
            this.cobMatchID.Name = "cobMatchID";
            this.cobMatchID.Size = new System.Drawing.Size(121, 33);
            this.cobMatchID.TabIndex = 24;
            // 
            // btnProcessSalesSubmit
            // 
            this.btnProcessSalesSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessSalesSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcessSalesSubmit.Location = new System.Drawing.Point(257, 346);
            this.btnProcessSalesSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcessSalesSubmit.Name = "btnProcessSalesSubmit";
            this.btnProcessSalesSubmit.Size = new System.Drawing.Size(193, 72);
            this.btnProcessSalesSubmit.TabIndex = 22;
            this.btnProcessSalesSubmit.Text = "Submit";
            this.btnProcessSalesSubmit.UseVisualStyleBackColor = true;
            this.btnProcessSalesSubmit.Click += new System.EventHandler(this.btnProcessSalesSubmit_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(89, 246);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(115, 29);
            this.lbQuantity.TabIndex = 18;
            this.lbQuantity.Text = "Quantity";
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
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(89, 146);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(139, 29);
            this.lbTotalPrice.TabIndex = 14;
            this.lbTotalPrice.Text = "Total Rate";
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.Location = new System.Drawing.Point(89, 52);
            this.lblCatCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(119, 29);
            this.lblCatCode.TabIndex = 13;
            this.lblCatCode.Text = "CatCode";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(257, 247);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(193, 30);
            this.txtQty.TabIndex = 28;
            // 
            // frmProcessSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnbackProcessSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProcessSales";
            this.Text = "ProcessSales";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbackProcessSales;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cobMatchID;
        private System.Windows.Forms.Button btnProcessSalesSubmit;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.TextBox txtQty;
    }
}