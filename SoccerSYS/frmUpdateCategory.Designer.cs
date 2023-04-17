
using System;

namespace SoccerSYS
{
    partial class frmUpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCategory));
            this.btnbackUpdateCat = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.txtNoSeatsTo = new System.Windows.Forms.TextBox();
            this.txtNoSeatsFrom = new System.Windows.Forms.TextBox();
            this.lbSeatTo = new System.Windows.Forms.Label();
            this.lbSeatFrom = new System.Windows.Forms.Label();
            this.cobCatCode = new System.Windows.Forms.ComboBox();
            this.txtNoSeats = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.lblNoSeats = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.lbEnterCatCode = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbackUpdateCat
            // 
            this.btnbackUpdateCat.Location = new System.Drawing.Point(1, 0);
            this.btnbackUpdateCat.Name = "btnbackUpdateCat";
            this.btnbackUpdateCat.Size = new System.Drawing.Size(75, 23);
            this.btnbackUpdateCat.TabIndex = 9;
            this.btnbackUpdateCat.Text = " < Back";
            this.btnbackUpdateCat.UseVisualStyleBackColor = true;
            this.btnbackUpdateCat.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.txtNoSeatsTo);
            this.grpCategory.Controls.Add(this.txtNoSeatsFrom);
            this.grpCategory.Controls.Add(this.lbSeatTo);
            this.grpCategory.Controls.Add(this.lbSeatFrom);
            this.grpCategory.Controls.Add(this.cobCatCode);
            this.grpCategory.Controls.Add(this.txtNoSeats);
            this.grpCategory.Controls.Add(this.txtPrice);
            this.grpCategory.Controls.Add(this.btnUpdateCategory);
            this.grpCategory.Controls.Add(this.lblNoSeats);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.txtdescription);
            this.grpCategory.Controls.Add(this.lbldescription);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(46, 126);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(670, 405);
            this.grpCategory.TabIndex = 14;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Details:";
            // 
            // txtNoSeatsTo
            // 
            this.txtNoSeatsTo.Location = new System.Drawing.Point(191, 287);
            this.txtNoSeatsTo.Name = "txtNoSeatsTo";
            this.txtNoSeatsTo.Size = new System.Drawing.Size(137, 26);
            this.txtNoSeatsTo.TabIndex = 31;
            // 
            // txtNoSeatsFrom
            // 
            this.txtNoSeatsFrom.Location = new System.Drawing.Point(191, 230);
            this.txtNoSeatsFrom.Name = "txtNoSeatsFrom";
            this.txtNoSeatsFrom.Size = new System.Drawing.Size(137, 26);
            this.txtNoSeatsFrom.TabIndex = 30;
            // 
            // lbSeatTo
            // 
            this.lbSeatTo.AutoSize = true;
            this.lbSeatTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatTo.Location = new System.Drawing.Point(40, 286);
            this.lbSeatTo.Name = "lbSeatTo";
            this.lbSeatTo.Size = new System.Drawing.Size(119, 25);
            this.lbSeatTo.TabIndex = 29;
            this.lbSeatTo.Text = "NoSeats to";
            // 
            // lbSeatFrom
            // 
            this.lbSeatFrom.AutoSize = true;
            this.lbSeatFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatFrom.Location = new System.Drawing.Point(40, 229);
            this.lbSeatFrom.Name = "lbSeatFrom";
            this.lbSeatFrom.Size = new System.Drawing.Size(150, 25);
            this.lbSeatFrom.TabIndex = 26;
            this.lbSeatFrom.Text = "NoSeats From";
            // 
            // cobCatCode
            // 
            this.cobCatCode.FormattingEnabled = true;
            this.cobCatCode.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cobCatCode.Location = new System.Drawing.Point(200, 39);
            this.cobCatCode.Margin = new System.Windows.Forms.Padding(2);
            this.cobCatCode.Name = "cobCatCode";
            this.cobCatCode.Size = new System.Drawing.Size(119, 28);
            this.cobCatCode.TabIndex = 28;
            // 
            // txtNoSeats
            // 
            this.txtNoSeats.Location = new System.Drawing.Point(191, 180);
            this.txtNoSeats.Name = "txtNoSeats";
            this.txtNoSeats.Size = new System.Drawing.Size(137, 26);
            this.txtNoSeats.TabIndex = 27;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(191, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 26);
            this.txtPrice.TabIndex = 20;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCategory.Location = new System.Drawing.Point(191, 336);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(145, 58);
            this.btnUpdateCategory.TabIndex = 19;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // lblNoSeats
            // 
            this.lblNoSeats.AutoSize = true;
            this.lblNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSeats.Location = new System.Drawing.Point(40, 174);
            this.lblNoSeats.Name = "lblNoSeats";
            this.lblNoSeats.Size = new System.Drawing.Size(95, 25);
            this.lblNoSeats.TabIndex = 17;
            this.lblNoSeats.Text = "NoSeats";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(40, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(191, 84);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(137, 26);
            this.txtdescription.TabIndex = 15;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(40, 84);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(120, 25);
            this.lbldescription.TabIndex = 14;
            this.lbldescription.Text = "Description";
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.Location = new System.Drawing.Point(40, 38);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(158, 25);
            this.lblCatCode.TabIndex = 13;
            this.lblCatCode.Text = "Category Code";
            // 
            // lbEnterCatCode
            // 
            this.lbEnterCatCode.AutoSize = true;
            this.lbEnterCatCode.Location = new System.Drawing.Point(106, 9);
            this.lbEnterCatCode.Name = "lbEnterCatCode";
            this.lbEnterCatCode.Size = new System.Drawing.Size(104, 13);
            this.lbEnterCatCode.TabIndex = 32;
            this.lbEnterCatCode.Text = "Enter Category Type";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(501, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdCategory
            // 
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Location = new System.Drawing.Point(58, 36);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(658, 85);
            this.grdCategory.TabIndex = 36;
            this.grdCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategory_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(237, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 20);
            this.txtSearch.TabIndex = 33;
            // 
            // frmUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbEnterCatCode);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnbackUpdateCat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateCategory";
            this.Text = "UpdateCategory";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button btnbackUpdateCat;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtNoSeats;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label lblNoSeats;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.ComboBox cobCatCode;
        private System.Windows.Forms.Label lbSeatFrom;
        private System.Windows.Forms.Label lbSeatTo;
        private System.Windows.Forms.TextBox txtNoSeatsFrom;
        private System.Windows.Forms.TextBox txtNoSeatsTo;
        private System.Windows.Forms.Label lbEnterCatCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdCategory;
        private System.Windows.Forms.TextBox txtSearch;
    }
}