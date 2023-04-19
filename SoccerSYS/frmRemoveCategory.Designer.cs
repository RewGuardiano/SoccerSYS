
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveCategory));
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.grdCategoryRemove = new System.Windows.Forms.DataGridView();
            this.txtSearchRemove = new System.Windows.Forms.TextBox();
            this.btnSearchRemove = new System.Windows.Forms.Button();
            this.lbEnterCatCode = new System.Windows.Forms.Label();
            this.cobCatCode = new System.Windows.Forms.ComboBox();
            this.lblCatCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoryRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = " < Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveCategory.Location = new System.Drawing.Point(302, 442);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(145, 58);
            this.btnRemoveCategory.TabIndex = 19;
            this.btnRemoveCategory.Text = "Remove Category";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // grdCategoryRemove
            // 
            this.grdCategoryRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategoryRemove.Location = new System.Drawing.Point(0, 87);
            this.grdCategoryRemove.Name = "grdCategoryRemove";
            this.grdCategoryRemove.Size = new System.Drawing.Size(798, 245);
            this.grdCategoryRemove.TabIndex = 37;
            this.grdCategoryRemove.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategoryRemove_CellContentClick);
            // 
            // txtSearchRemove
            // 
            this.txtSearchRemove.Location = new System.Drawing.Point(261, 39);
            this.txtSearchRemove.Name = "txtSearchRemove";
            this.txtSearchRemove.Size = new System.Drawing.Size(227, 20);
            this.txtSearchRemove.TabIndex = 38;
            // 
            // btnSearchRemove
            // 
            this.btnSearchRemove.Location = new System.Drawing.Point(566, 39);
            this.btnSearchRemove.Name = "btnSearchRemove";
            this.btnSearchRemove.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRemove.TabIndex = 39;
            this.btnSearchRemove.Text = "Search";
            this.btnSearchRemove.UseVisualStyleBackColor = true;
            this.btnSearchRemove.Click += new System.EventHandler(this.btnSearchRemove_Click);
            // 
            // lbEnterCatCode
            // 
            this.lbEnterCatCode.AutoSize = true;
            this.lbEnterCatCode.Location = new System.Drawing.Point(87, 44);
            this.lbEnterCatCode.Name = "lbEnterCatCode";
            this.lbEnterCatCode.Size = new System.Drawing.Size(104, 13);
            this.lbEnterCatCode.TabIndex = 40;
            this.lbEnterCatCode.Text = "Enter Category Type";
            // 
            // cobCatCode
            // 
            this.cobCatCode.FormattingEnabled = true;
            this.cobCatCode.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cobCatCode.Location = new System.Drawing.Point(410, 353);
            this.cobCatCode.Margin = new System.Windows.Forms.Padding(2);
            this.cobCatCode.Name = "cobCatCode";
            this.cobCatCode.Size = new System.Drawing.Size(119, 21);
            this.cobCatCode.TabIndex = 42;
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.Location = new System.Drawing.Point(185, 349);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(158, 25);
            this.lblCatCode.TabIndex = 41;
            this.lblCatCode.Text = "Category Code";
            // 
            // frmRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.cobCatCode);
            this.Controls.Add(this.lblCatCode);
            this.Controls.Add(this.lbEnterCatCode);
            this.Controls.Add(this.btnSearchRemove);
            this.Controls.Add(this.txtSearchRemove);
            this.Controls.Add(this.grdCategoryRemove);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveCategory";
            this.Text = "RemoveCategory";
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoryRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.DataGridView grdCategoryRemove;
        private System.Windows.Forms.TextBox txtSearchRemove;
        private System.Windows.Forms.Button btnSearchRemove;
        private System.Windows.Forms.Label lbEnterCatCode;
        private System.Windows.Forms.ComboBox cobCatCode;
        private System.Windows.Forms.Label lblCatCode;
    }
}