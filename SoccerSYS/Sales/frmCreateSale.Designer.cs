
namespace SoccerSYS
{
    partial class frmCreateSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateSale));
            this.btnCreateSaleBack = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.gpbCatCode = new System.Windows.Forms.GroupBox();
            this.NUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CobCatCodes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmCart = new System.Windows.Forms.Button();
            this.btnConfirmEmail = new System.Windows.Forms.Button();
            this.grpBoxCart = new System.Windows.Forms.GroupBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtTotPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.CatCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixtureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobFixtures = new System.Windows.Forms.ComboBox();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbSaleId = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            this.gpbCatCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).BeginInit();
            this.grpBoxCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateSaleBack
            // 
            this.btnCreateSaleBack.Location = new System.Drawing.Point(4, 4);
            this.btnCreateSaleBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateSaleBack.Name = "btnCreateSaleBack";
            this.btnCreateSaleBack.Size = new System.Drawing.Size(100, 28);
            this.btnCreateSaleBack.TabIndex = 14;
            this.btnCreateSaleBack.Text = " < Back";
            this.btnCreateSaleBack.UseVisualStyleBackColor = true;
            this.btnCreateSaleBack.Click += new System.EventHandler(this.btnCreateSaleBack_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCategory.Controls.Add(this.gpbCatCode);
            this.grpCategory.Controls.Add(this.btnConfirmEmail);
            this.grpCategory.Controls.Add(this.grpBoxCart);
            this.grpCategory.Controls.Add(this.cobFixtures);
            this.grpCategory.Controls.Add(this.lblTicketID);
            this.grpCategory.Controls.Add(this.txtEmail);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbSaleId);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(112, 27);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(1113, 521);
            this.grpCategory.TabIndex = 17;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Create Sale";
            // 
            // gpbCatCode
            // 
            this.gpbCatCode.Controls.Add(this.NUDQuantity);
            this.gpbCatCode.Controls.Add(this.label3);
            this.gpbCatCode.Controls.Add(this.CobCatCodes);
            this.gpbCatCode.Controls.Add(this.label1);
            this.gpbCatCode.Controls.Add(this.btnConfirmCart);
            this.gpbCatCode.Location = new System.Drawing.Point(24, 262);
            this.gpbCatCode.Name = "gpbCatCode";
            this.gpbCatCode.Size = new System.Drawing.Size(516, 229);
            this.gpbCatCode.TabIndex = 53;
            this.gpbCatCode.TabStop = false;
            this.gpbCatCode.Visible = false;
            // 
            // NUDQuantity
            // 
            this.NUDQuantity.Location = new System.Drawing.Point(177, 104);
            this.NUDQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDQuantity.Name = "NUDQuantity";
            this.NUDQuantity.Size = new System.Drawing.Size(120, 30);
            this.NUDQuantity.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Quantity:";
            // 
            // CobCatCodes
            // 
            this.CobCatCodes.FormattingEnabled = true;
            this.CobCatCodes.Location = new System.Drawing.Point(293, 34);
            this.CobCatCodes.Name = "CobCatCodes";
            this.CobCatCodes.Size = new System.Drawing.Size(217, 33);
            this.CobCatCodes.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Choose Category Code:";
            // 
            // btnConfirmCart
            // 
            this.btnConfirmCart.Location = new System.Drawing.Point(167, 155);
            this.btnConfirmCart.Name = "btnConfirmCart";
            this.btnConfirmCart.Size = new System.Drawing.Size(180, 45);
            this.btnConfirmCart.TabIndex = 52;
            this.btnConfirmCart.Text = "Add Cart";
            this.btnConfirmCart.UseVisualStyleBackColor = true;
            this.btnConfirmCart.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirmEmail
            // 
            this.btnConfirmEmail.Location = new System.Drawing.Point(239, 217);
            this.btnConfirmEmail.Name = "btnConfirmEmail";
            this.btnConfirmEmail.Size = new System.Drawing.Size(120, 39);
            this.btnConfirmEmail.TabIndex = 52;
            this.btnConfirmEmail.Text = "Confirm";
            this.btnConfirmEmail.UseVisualStyleBackColor = true;
            this.btnConfirmEmail.Click += new System.EventHandler(this.btnConfirmEmail_Click);
            // 
            // grpBoxCart
            // 
            this.grpBoxCart.Controls.Add(this.btnCheckOut);
            this.grpBoxCart.Controls.Add(this.txtTotPrice);
            this.grpBoxCart.Controls.Add(this.label2);
            this.grpBoxCart.Controls.Add(this.dgvCart);
            this.grpBoxCart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCart.Location = new System.Drawing.Point(590, 48);
            this.grpBoxCart.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxCart.Name = "grpBoxCart";
            this.grpBoxCart.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxCart.Size = new System.Drawing.Size(497, 393);
            this.grpBoxCart.TabIndex = 49;
            this.grpBoxCart.TabStop = false;
            this.grpBoxCart.Text = "Cart";
            this.grpBoxCart.Visible = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckOut.Location = new System.Drawing.Point(282, 309);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(124, 36);
            this.btnCheckOut.TabIndex = 34;
            this.btnCheckOut.Text = "CHECKOUT";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtTotPrice
            // 
            this.txtTotPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPrice.Location = new System.Drawing.Point(135, 313);
            this.txtTotPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotPrice.MaxLength = 28888;
            this.txtTotPrice.Name = "txtTotPrice";
            this.txtTotPrice.Size = new System.Drawing.Size(113, 32);
            this.txtTotPrice.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sub Total:";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatCode,
            this.Quantity,
            this.Price,
            this.FixtureID});
            this.dgvCart.Location = new System.Drawing.Point(8, 37);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(481, 255);
            this.dgvCart.TabIndex = 10;
            // 
            // CatCode
            // 
            this.CatCode.HeaderText = "Category Code";
            this.CatCode.MinimumWidth = 6;
            this.CatCode.Name = "CatCode";
            this.CatCode.ReadOnly = true;
            this.CatCode.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // FixtureID
            // 
            this.FixtureID.HeaderText = "Fixture";
            this.FixtureID.MinimumWidth = 6;
            this.FixtureID.Name = "FixtureID";
            this.FixtureID.ReadOnly = true;
            this.FixtureID.Width = 125;
            // 
            // cobFixtures
            // 
            this.cobFixtures.FormattingEnabled = true;
            this.cobFixtures.Location = new System.Drawing.Point(156, 169);
            this.cobFixtures.Name = "cobFixtures";
            this.cobFixtures.Size = new System.Drawing.Size(301, 33);
            this.cobFixtures.TabIndex = 42;
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.Location = new System.Drawing.Point(31, 169);
            this.lblTicketID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(118, 29);
            this.lblTicketID.TabIndex = 18;
            this.lblTicketID.Text = "Fixtures:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 30);
            this.txtEmail.TabIndex = 17;
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
            this.lbSaleId.Location = new System.Drawing.Point(31, 95);
            this.lbSaleId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaleId.Name = "lbSaleId";
            this.lbSaleId.Size = new System.Drawing.Size(91, 29);
            this.lbSaleId.TabIndex = 13;
            this.lbSaleId.Text = "Email:";
            // 
            // frmCreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 831);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnCreateSaleBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateSale";
            this.Text = "ProcessSales";
            this.Load += new System.EventHandler(this.frmCreateSale_Load);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.gpbCatCode.ResumeLayout(false);
            this.gpbCatCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).EndInit();
            this.grpBoxCart.ResumeLayout(false);
            this.grpBoxCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSaleBack;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbSaleId;
        private System.Windows.Forms.GroupBox grpBoxCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtTotPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.ComboBox cobFixtures;
        private System.Windows.Forms.Button btnConfirmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixtureID;
        private System.Windows.Forms.GroupBox gpbCatCode;
        private System.Windows.Forms.NumericUpDown NUDQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CobCatCodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmCart;
    }
}