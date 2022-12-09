
namespace SoccerSYS
{
    partial class frmSetCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetCategory));
            this.btnBackbutton = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.txtNoSeatsTo = new System.Windows.Forms.TextBox();
            this.txtNoSeatsFrom = new System.Windows.Forms.TextBox();
            this.txtNoSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSetCategory = new System.Windows.Forms.Button();
            this.lblNoSeats = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackbutton
            // 
            this.btnBackbutton.Location = new System.Drawing.Point(0, 0);
            this.btnBackbutton.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackbutton.Name = "btnBackbutton";
            this.btnBackbutton.Size = new System.Drawing.Size(100, 28);
            this.btnBackbutton.TabIndex = 8;
            this.btnBackbutton.Text = " < Back";
            this.btnBackbutton.UseVisualStyleBackColor = true;
            this.btnBackbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpCategory.Controls.Add(this.txtNoSeatsTo);
            this.grpCategory.Controls.Add(this.txtNoSeatsFrom);
            this.grpCategory.Controls.Add(this.txtNoSeats);
            this.grpCategory.Controls.Add(this.label2);
            this.grpCategory.Controls.Add(this.label1);
            this.grpCategory.Controls.Add(this.txtCatCode);
            this.grpCategory.Controls.Add(this.txtPrice);
            this.grpCategory.Controls.Add(this.btnSetCategory);
            this.grpCategory.Controls.Add(this.lblNoSeats);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.txtdescription);
            this.grpCategory.Controls.Add(this.lbldescription);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(60, 36);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(1068, 466);
            this.grpCategory.TabIndex = 13;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Details";
            // 
            // txtNoSeatsTo
            // 
            this.txtNoSeatsTo.Location = new System.Drawing.Point(255, 331);
            this.txtNoSeatsTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSeatsTo.Name = "txtNoSeatsTo";
            this.txtNoSeatsTo.Size = new System.Drawing.Size(181, 30);
            this.txtNoSeatsTo.TabIndex = 28;
            // 
            // txtNoSeatsFrom
            // 
            this.txtNoSeatsFrom.Location = new System.Drawing.Point(255, 257);
            this.txtNoSeatsFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSeatsFrom.Name = "txtNoSeatsFrom";
            this.txtNoSeatsFrom.Size = new System.Drawing.Size(181, 30);
            this.txtNoSeatsFrom.TabIndex = 28;
            // 
            // txtNoSeats
            // 
            this.txtNoSeats.Location = new System.Drawing.Point(255, 194);
            this.txtNoSeats.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSeats.Name = "txtNoSeats";
            this.txtNoSeats.Size = new System.Drawing.Size(181, 30);
            this.txtNoSeats.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "NoSeats to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "NoSeats From";
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(268, 47);
            this.txtCatCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatCode.MaxLength = 327567;
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(140, 30);
            this.txtCatCode.TabIndex = 21;
            this.txtCatCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(255, 139);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 30);
            this.txtPrice.TabIndex = 20;
            // 
            // btnSetCategory
            // 
            this.btnSetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetCategory.Location = new System.Drawing.Point(244, 384);
            this.btnSetCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetCategory.Name = "btnSetCategory";
            this.btnSetCategory.Size = new System.Drawing.Size(193, 52);
            this.btnSetCategory.TabIndex = 19;
            this.btnSetCategory.Text = "Set Category";
            this.btnSetCategory.UseVisualStyleBackColor = true;
            this.btnSetCategory.Click += new System.EventHandler(this.btnSetCategory_Click);
            // 
            // lblNoSeats
            // 
            this.lblNoSeats.AutoSize = true;
            this.lblNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSeats.Location = new System.Drawing.Point(53, 187);
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
            this.lblPrice.Location = new System.Drawing.Point(53, 139);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 29);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(255, 96);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(181, 30);
            this.txtdescription.TabIndex = 15;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(53, 96);
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
            // frmSetCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1175, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnBackbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSetCategory";
            this.Text = "Set Category Type";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackbutton;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSetCategory;
        private System.Windows.Forms.Label lblNoSeats;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoSeats;
        private System.Windows.Forms.TextBox txtNoSeatsTo;
        private System.Windows.Forms.TextBox txtNoSeatsFrom;
    }
}