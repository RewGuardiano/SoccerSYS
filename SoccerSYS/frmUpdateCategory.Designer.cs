﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.txtNoSeats = new System.Windows.Forms.TextBox();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.lblNoSeats = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = " < Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.txtNoSeats);
            this.grpCategory.Controls.Add(this.txtCatCode);
            this.grpCategory.Controls.Add(this.txtPrice);
            this.grpCategory.Controls.Add(this.btnUpdateCategory);
            this.grpCategory.Controls.Add(this.lblNoSeats);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.txtdescription);
            this.grpCategory.Controls.Add(this.lbldescription);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(62, 76);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(894, 434);
            this.grpCategory.TabIndex = 14;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Details:";
            this.grpCategory.Enter += new System.EventHandler(this.grpCategory_Enter);
            // 
            // txtNoSeats
            // 
            this.txtNoSeats.Location = new System.Drawing.Point(255, 221);
            this.txtNoSeats.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSeats.Name = "txtNoSeats";
            this.txtNoSeats.Size = new System.Drawing.Size(181, 30);
            this.txtNoSeats.TabIndex = 27;
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(278, 47);
            this.txtCatCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(140, 30);
            this.txtCatCode.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(255, 162);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 30);
            this.txtPrice.TabIndex = 20;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCategory.Location = new System.Drawing.Point(255, 275);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(193, 72);
            this.btnUpdateCategory.TabIndex = 19;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // lblNoSeats
            // 
            this.lblNoSeats.AutoSize = true;
            this.lblNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSeats.Location = new System.Drawing.Point(53, 214);
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
            this.lblPrice.Location = new System.Drawing.Point(53, 154);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 29);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(255, 104);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(181, 30);
            this.txtdescription.TabIndex = 15;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(53, 104);
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
            this.lblCatCode.Location = new System.Drawing.Point(53, 47);
            this.lblCatCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(195, 29);
            this.lblCatCode.TabIndex = 13;
            this.lblCatCode.Text = "Category Code";
            // 
            // frmUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateCategory";
            this.Text = "UpdateCategory";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtNoSeats;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label lblNoSeats;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblCatCode;
    }
}