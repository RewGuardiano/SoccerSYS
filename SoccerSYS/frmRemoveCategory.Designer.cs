
namespace SoccerSYS
{
    partial class frmRemoveCategory
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
            this.button1 = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.lblNoSeats = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.cobRemoveCatCode = new System.Windows.Forms.ComboBox();
            this.cobRemoveDescription = new System.Windows.Forms.ComboBox();
            this.cobRemovePrice = new System.Windows.Forms.ComboBox();
            this.cobRemoveSeats = new System.Windows.Forms.ComboBox();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = " < Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.cobRemoveSeats);
            this.grpCategory.Controls.Add(this.cobRemovePrice);
            this.grpCategory.Controls.Add(this.cobRemoveDescription);
            this.grpCategory.Controls.Add(this.cobRemoveCatCode);
            this.grpCategory.Controls.Add(this.btnRemoveCategory);
            this.grpCategory.Controls.Add(this.lblNoSeats);
            this.grpCategory.Controls.Add(this.lblPrice);
            this.grpCategory.Controls.Add(this.lbldescription);
            this.grpCategory.Controls.Add(this.lblCatCode);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(86, 60);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(894, 434);
            this.grpCategory.TabIndex = 15;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Enter Details:";
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveCategory.Location = new System.Drawing.Point(255, 275);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(193, 72);
            this.btnRemoveCategory.TabIndex = 19;
            this.btnRemoveCategory.Text = "Remove Category";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
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
            // cobRemoveCatCode
            // 
            this.cobRemoveCatCode.FormattingEnabled = true;
            this.cobRemoveCatCode.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cobRemoveCatCode.Location = new System.Drawing.Point(264, 48);
            this.cobRemoveCatCode.Name = "cobRemoveCatCode";
            this.cobRemoveCatCode.Size = new System.Drawing.Size(153, 33);
            this.cobRemoveCatCode.TabIndex = 30;
            // 
            // cobRemoveDescription
            // 
            this.cobRemoveDescription.FormattingEnabled = true;
            this.cobRemoveDescription.Items.AddRange(new object[] {
            "low sideline",
            "Middle Seats",
            "VIP Seats",
            ""});
            this.cobRemoveDescription.Location = new System.Drawing.Point(264, 105);
            this.cobRemoveDescription.Name = "cobRemoveDescription";
            this.cobRemoveDescription.Size = new System.Drawing.Size(153, 33);
            this.cobRemoveDescription.TabIndex = 31;
            // 
            // cobRemovePrice
            // 
            this.cobRemovePrice.FormattingEnabled = true;
            this.cobRemovePrice.Items.AddRange(new object[] {
            "100",
            "200",
            "400"});
            this.cobRemovePrice.Location = new System.Drawing.Point(264, 164);
            this.cobRemovePrice.Name = "cobRemovePrice";
            this.cobRemovePrice.Size = new System.Drawing.Size(153, 33);
            this.cobRemovePrice.TabIndex = 32;
            // 
            // cobRemoveSeats
            // 
            this.cobRemoveSeats.FormattingEnabled = true;
            this.cobRemoveSeats.Items.AddRange(new object[] {
            "10,000",
            "25,000",
            "15,000"});
            this.cobRemoveSeats.Location = new System.Drawing.Point(264, 215);
            this.cobRemoveSeats.Name = "cobRemoveSeats";
            this.cobRemoveSeats.Size = new System.Drawing.Size(153, 33);
            this.cobRemoveSeats.TabIndex = 33;
            // 
            // frmRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRemoveCategory";
            this.Text = "RemoveCategory";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Label lblNoSeats;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.ComboBox cobRemoveCatCode;
        private System.Windows.Forms.ComboBox cobRemoveSeats;
        private System.Windows.Forms.ComboBox cobRemovePrice;
        private System.Windows.Forms.ComboBox cobRemoveDescription;
    }
}