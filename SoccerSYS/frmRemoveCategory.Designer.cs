
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
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbEnterCatCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
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
            this.btnRemoveCategory.Location = new System.Drawing.Point(310, 358);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(145, 58);
            this.btnRemoveCategory.TabIndex = 19;
            this.btnRemoveCategory.Text = "Remove Category";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // grdCategory
            // 
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Location = new System.Drawing.Point(59, 103);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(658, 236);
            this.grdCategory.TabIndex = 37;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(261, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 20);
            this.txtSearch.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(566, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // frmRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEnterCatCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveCategory";
            this.Text = "RemoveCategory";
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.DataGridView grdCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbEnterCatCode;
    }
}