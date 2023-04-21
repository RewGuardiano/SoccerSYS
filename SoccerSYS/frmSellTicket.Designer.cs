
namespace SoccerSYS
{
    partial class frmSellTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellTicket));
            this.btnbackProcessSales = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.NUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.cobTypes = new System.Windows.Forms.ComboBox();
            this.btnProcessSalesConfirm = new System.Windows.Forms.Button();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbSaleId = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbackProcessSales
            // 
            this.btnbackProcessSales.Location = new System.Drawing.Point(3, 3);
            this.btnbackProcessSales.Name = "btnbackProcessSales";
            this.btnbackProcessSales.Size = new System.Drawing.Size(75, 23);
            this.btnbackProcessSales.TabIndex = 14;
            this.btnbackProcessSales.Text = " < Back";
            this.btnbackProcessSales.UseVisualStyleBackColor = true;
            this.btnbackProcessSales.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.dataGridView1);
            this.grpCategory.Controls.Add(this.btnSelect);
            this.grpCategory.Controls.Add(this.grdCategory);
            this.grpCategory.Controls.Add(this.NUDQuantity);
            this.grpCategory.Controls.Add(this.cobTypes);
            this.grpCategory.Controls.Add(this.btnProcessSalesConfirm);
            this.grpCategory.Controls.Add(this.lbQuantity);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbSaleId);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(64, 25);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(670, 557);
            this.grpCategory.TabIndex = 17;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Ticket Details:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 116);
            this.dataGridView1.TabIndex = 39;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(509, 42);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSelect.TabIndex = 38;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grdCategory
            // 
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Location = new System.Drawing.Point(6, 104);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(658, 116);
            this.grdCategory.TabIndex = 37;
            this.grdCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategory_CellContentClick);
            // 
            // NUDQuantity
            // 
            this.NUDQuantity.Location = new System.Drawing.Point(290, 420);
            this.NUDQuantity.Name = "NUDQuantity";
            this.NUDQuantity.Size = new System.Drawing.Size(120, 26);
            this.NUDQuantity.TabIndex = 30;
            // 
            // cobTypes
            // 
            this.cobTypes.FormattingEnabled = true;
            this.cobTypes.Items.AddRange(new object[] {
            " A",
            " B",
            "C"});
            this.cobTypes.Location = new System.Drawing.Point(219, 43);
            this.cobTypes.Name = "cobTypes";
            this.cobTypes.Size = new System.Drawing.Size(264, 28);
            this.cobTypes.TabIndex = 29;
            // 
            // btnProcessSalesConfirm
            // 
            this.btnProcessSalesConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessSalesConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcessSalesConfirm.Location = new System.Drawing.Point(276, 476);
            this.btnProcessSalesConfirm.Name = "btnProcessSalesConfirm";
            this.btnProcessSalesConfirm.Size = new System.Drawing.Size(145, 58);
            this.btnProcessSalesConfirm.TabIndex = 22;
            this.btnProcessSalesConfirm.Text = "Confirm";
            this.btnProcessSalesConfirm.UseVisualStyleBackColor = true;
            this.btnProcessSalesConfirm.Click += new System.EventHandler(this.btnProcessSalesSubmit_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(139, 421);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(93, 25);
            this.lbQuantity.TabIndex = 18;
            this.lbQuantity.Text = "Quantity";
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
            // lbSaleId
            // 
            this.lbSaleId.AutoSize = true;
            this.lbSaleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaleId.Location = new System.Drawing.Point(67, 42);
            this.lbSaleId.Name = "lbSaleId";
            this.lbSaleId.Size = new System.Drawing.Size(126, 25);
            this.lbSaleId.TabIndex = 13;
            this.lbSaleId.Text = "Ticket Type";
            // 
            // frmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnbackProcessSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSellTicket";
            this.Text = "ProcessSales";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbackProcessSales;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Button btnProcessSalesConfirm;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbSaleId;
        private System.Windows.Forms.NumericUpDown NUDQuantity;
        private System.Windows.Forms.ComboBox cobTypes;
        private System.Windows.Forms.DataGridView grdCategory;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}