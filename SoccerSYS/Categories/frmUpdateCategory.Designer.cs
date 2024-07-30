
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
            this.NUDCategorySeats = new System.Windows.Forms.NumericUpDown();
            this.NUDCategoriesPrice = new System.Windows.Forms.NumericUpDown();
            this.cobCatCode = new System.Windows.Forms.ComboBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
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
            // btnbackUpdateCat
            // 
            this.btnbackUpdateCat.Location = new System.Drawing.Point(1, 0);
            this.btnbackUpdateCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnbackUpdateCat.Name = "btnbackUpdateCat";
            this.btnbackUpdateCat.Size = new System.Drawing.Size(100, 28);
            this.btnbackUpdateCat.TabIndex = 9;
            this.btnbackUpdateCat.Text = " < Back";
            this.btnbackUpdateCat.UseVisualStyleBackColor = true;
            this.btnbackUpdateCat.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCategory.Controls.Add(this.NUDCategorySeats);
            this.grpCategory.Controls.Add(this.NUDCategoriesPrice);
            this.grpCategory.Controls.Add(this.cobCatCode);
            this.grpCategory.Controls.Add(this.btnUpdateCategory);
            this.grpCategory.Controls.Add(this.lblNoSeats);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.txtdescription);
            this.grpCategory.Controls.Add(this.lbldescription);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(172, 72);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(703, 429);
            this.grpCategory.TabIndex = 14;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Update Category";
            // 
            // NUDCategorySeats
            // 
            this.NUDCategorySeats.Location = new System.Drawing.Point(317, 280);
            this.NUDCategorySeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCategorySeats.Name = "NUDCategorySeats";
            this.NUDCategorySeats.ReadOnly = true;
            this.NUDCategorySeats.Size = new System.Drawing.Size(166, 30);
            this.NUDCategorySeats.TabIndex = 33;
            this.NUDCategorySeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDCategoriesPrice
            // 
            this.NUDCategoriesPrice.DecimalPlaces = 2;
            this.NUDCategoriesPrice.Location = new System.Drawing.Point(317, 224);
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
            this.NUDCategoriesPrice.Size = new System.Drawing.Size(166, 30);
            this.NUDCategoriesPrice.TabIndex = 32;
            this.NUDCategoriesPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cobCatCode
            // 
            this.cobCatCode.FormattingEnabled = true;
            this.cobCatCode.Location = new System.Drawing.Point(364, 55);
            this.cobCatCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobCatCode.Name = "cobCatCode";
            this.cobCatCode.Size = new System.Drawing.Size(258, 33);
            this.cobCatCode.TabIndex = 28;
            this.cobCatCode.SelectedIndexChanged += new System.EventHandler(this.cobCatCode_SelectedIndexChanged);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCategory.Location = new System.Drawing.Point(314, 345);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(184, 58);
            this.btnUpdateCategory.TabIndex = 19;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // lblNoSeats
            // 
            this.lblNoSeats.AutoSize = true;
            this.lblNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSeats.Location = new System.Drawing.Point(142, 281);
            this.lblNoSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoSeats.Name = "lblNoSeats";
            this.lblNoSeats.Size = new System.Drawing.Size(117, 29);
            this.lblNoSeats.TabIndex = 17;
            this.lblNoSeats.Text = "NoSeats";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(142, 222);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 29);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(317, 169);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(181, 30);
            this.txtdescription.TabIndex = 15;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(142, 170);
            this.lbldescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(151, 29);
            this.lbldescription.TabIndex = 14;
            this.lbldescription.Text = "Description";
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.Location = new System.Drawing.Point(38, 54);
            this.lblCatCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(296, 29);
            this.lblCatCode.TabIndex = 13;
            this.lblCatCode.Text = "Choose Category Code";
            // 
            // frmUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::SoccerSYS.Properties.Resources.footballBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 668);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnbackUpdateCat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateCategory";
            this.Text = "UpdateCategory";
            this.Load += new System.EventHandler(this.frmUpdateCategory_Load);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCategorySeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCategoriesPrice)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Button btnbackUpdateCat;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.ComboBox cobCatCode;
        private System.Windows.Forms.NumericUpDown NUDCategoriesPrice;
        private System.Windows.Forms.NumericUpDown NUDCategorySeats;
        private System.Windows.Forms.Label lblNoSeats;
    }
}