﻿
namespace SoccerSYS
{
    partial class frmCreateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateCategory));
            this.btnBackbutton = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.NUDCategorySeats = new System.Windows.Forms.NumericUpDown();
            this.NUDCategoriesPrice = new System.Windows.Forms.NumericUpDown();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.btnSetCategory = new System.Windows.Forms.Button();
            this.lblNoSeats = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCategorySeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCategoriesPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackbutton
            // 
            this.btnBackbutton.Location = new System.Drawing.Point(0, 0);
            this.btnBackbutton.Name = "btnBackbutton";
            this.btnBackbutton.Size = new System.Drawing.Size(75, 23);
            this.btnBackbutton.TabIndex = 8;
            this.btnBackbutton.Text = " < Back";
            this.btnBackbutton.UseVisualStyleBackColor = true;
            this.btnBackbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCategory.Controls.Add(this.NUDCategorySeats);
            this.grpCategory.Controls.Add(this.NUDCategoriesPrice);
            this.grpCategory.Controls.Add(this.txtCatCode);
            this.grpCategory.Controls.Add(this.btnSetCategory);
            this.grpCategory.Controls.Add(this.lblNoSeats);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.txtdescription);
            this.grpCategory.Controls.Add(this.lbldescription);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(108, 49);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(628, 314);
            this.grpCategory.TabIndex = 13;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Details";
            // 
            // NUDCategorySeats
            // 
            this.NUDCategorySeats.Location = new System.Drawing.Point(326, 156);
            this.NUDCategorySeats.Margin = new System.Windows.Forms.Padding(2);
            this.NUDCategorySeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDCategorySeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCategorySeats.Name = "NUDCategorySeats";
            this.NUDCategorySeats.Size = new System.Drawing.Size(124, 26);
            this.NUDCategorySeats.TabIndex = 30;
            this.NUDCategorySeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDCategoriesPrice
            // 
            this.NUDCategoriesPrice.DecimalPlaces = 2;
            this.NUDCategoriesPrice.Location = new System.Drawing.Point(326, 112);
            this.NUDCategoriesPrice.Margin = new System.Windows.Forms.Padding(2);
            this.NUDCategoriesPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDCategoriesPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCategoriesPrice.Name = "NUDCategoriesPrice";
            this.NUDCategoriesPrice.Size = new System.Drawing.Size(124, 26);
            this.NUDCategoriesPrice.TabIndex = 29;
            this.NUDCategoriesPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(326, 37);
            this.txtCatCode.MaxLength = 1;
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(106, 26);
            this.txtCatCode.TabIndex = 21;
            this.txtCatCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetCategory
            // 
            this.btnSetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetCategory.Location = new System.Drawing.Point(243, 231);
            this.btnSetCategory.Name = "btnSetCategory";
            this.btnSetCategory.Size = new System.Drawing.Size(145, 42);
            this.btnSetCategory.TabIndex = 19;
            this.btnSetCategory.Text = "Create Category";
            this.btnSetCategory.UseVisualStyleBackColor = true;
            this.btnSetCategory.Click += new System.EventHandler(this.btnSetCategory_Click_1);
            // 
            // lblNoSeats
            // 
            this.lblNoSeats.AutoSize = true;
            this.lblNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSeats.Location = new System.Drawing.Point(160, 154);
            this.lblNoSeats.Name = "lblNoSeats";
            this.lblNoSeats.Size = new System.Drawing.Size(109, 25);
            this.lblNoSeats.TabIndex = 17;
            this.lblNoSeats.Text = "MaxSeats";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(160, 113);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(326, 77);
            this.txtdescription.MaxLength = 8000;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(137, 26);
            this.txtdescription.TabIndex = 15;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(160, 77);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(120, 25);
            this.lbldescription.TabIndex = 14;
            this.lbldescription.Text = "Description";
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.Location = new System.Drawing.Point(160, 38);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(158, 25);
            this.lblCatCode.TabIndex = 13;
            this.lblCatCode.Text = "Category Code";
            // 
            // frmCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnBackbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateCategory";
            this.Text = "Set Category Type";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateCategory_FormClosed);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCategorySeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCategoriesPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackbutton;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.Button btnSetCategory;
        private System.Windows.Forms.Label lblNoSeats;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.NumericUpDown NUDCategoriesPrice;
        private System.Windows.Forms.NumericUpDown NUDCategorySeats;
    }
}