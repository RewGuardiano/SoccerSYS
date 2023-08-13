
namespace SoccerSYS
{
    partial class frmCancelMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelMatch));
            this.btnCancelMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMatchID = new System.Windows.Forms.Label();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.cobMatchID = new System.Windows.Forms.ComboBox();
            this.grdMatchRemove = new System.Windows.Forms.DataGridView();
            this.txtSearchCancelMatch = new System.Windows.Forms.TextBox();
            this.btnSearchCancelMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMatchRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelMatch
            // 
            this.btnCancelMatch.Location = new System.Drawing.Point(1, 4);
            this.btnCancelMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelMatch.Name = "btnCancelMatch";
            this.btnCancelMatch.Size = new System.Drawing.Size(100, 28);
            this.btnCancelMatch.TabIndex = 12;
            this.btnCancelMatch.Text = " < Back";
            this.btnCancelMatch.UseVisualStyleBackColor = true;
            this.btnCancelMatch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Match Id";
            // 
            // lbMatchID
            // 
            this.lbMatchID.AutoSize = true;
            this.lbMatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatchID.Location = new System.Drawing.Point(331, 385);
            this.lbMatchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatchID.Name = "lbMatchID";
            this.lbMatchID.Size = new System.Drawing.Size(117, 29);
            this.lbMatchID.TabIndex = 13;
            this.lbMatchID.Text = "Match Id";
            // 
            // btnCancelSubmit
            // 
            this.btnCancelSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelSubmit.Location = new System.Drawing.Point(436, 453);
            this.btnCancelSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSubmit.Name = "btnCancelSubmit";
            this.btnCancelSubmit.Size = new System.Drawing.Size(193, 44);
            this.btnCancelSubmit.TabIndex = 22;
            this.btnCancelSubmit.Text = "Cancel Match";
            this.btnCancelSubmit.UseVisualStyleBackColor = true;
            this.btnCancelSubmit.Click += new System.EventHandler(this.btnCancelSubmit_Click);
            // 
            // cobMatchID
            // 
            this.cobMatchID.FormattingEnabled = true;
            this.cobMatchID.Location = new System.Drawing.Point(496, 390);
            this.cobMatchID.Name = "cobMatchID";
            this.cobMatchID.Size = new System.Drawing.Size(234, 24);
            this.cobMatchID.TabIndex = 24;
            // 
            // grdMatchRemove
            // 
            this.grdMatchRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMatchRemove.Location = new System.Drawing.Point(23, 76);
            this.grdMatchRemove.Margin = new System.Windows.Forms.Padding(4);
            this.grdMatchRemove.Name = "grdMatchRemove";
            this.grdMatchRemove.RowHeadersWidth = 51;
            this.grdMatchRemove.Size = new System.Drawing.Size(1031, 285);
            this.grdMatchRemove.TabIndex = 38;
            this.grdMatchRemove.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMatchRemove_CellContentClick);
            // 
            // txtSearchCancelMatch
            // 
            this.txtSearchCancelMatch.Location = new System.Drawing.Point(387, 23);
            this.txtSearchCancelMatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCancelMatch.Name = "txtSearchCancelMatch";
            this.txtSearchCancelMatch.Size = new System.Drawing.Size(301, 22);
            this.txtSearchCancelMatch.TabIndex = 39;
            // 
            // btnSearchCancelMatch
            // 
            this.btnSearchCancelMatch.Location = new System.Drawing.Point(743, 20);
            this.btnSearchCancelMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCancelMatch.Name = "btnSearchCancelMatch";
            this.btnSearchCancelMatch.Size = new System.Drawing.Size(100, 28);
            this.btnSearchCancelMatch.TabIndex = 40;
            this.btnSearchCancelMatch.Text = "Search";
            this.btnSearchCancelMatch.UseVisualStyleBackColor = true;
            this.btnSearchCancelMatch.Click += new System.EventHandler(this.btnSearchCancelMatch_Click);
            // 
            // frmCancelMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSearchCancelMatch);
            this.Controls.Add(this.txtSearchCancelMatch);
            this.Controls.Add(this.grdMatchRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelMatch);
            this.Controls.Add(this.btnCancelSubmit);
            this.Controls.Add(this.cobMatchID);
            this.Controls.Add(this.lbMatchID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCancelMatch";
            this.Text = "CancelMatch";
            ((System.ComponentModel.ISupportInitialize)(this.grdMatchRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMatchID;
        private System.Windows.Forms.Button btnCancelSubmit;
        private System.Windows.Forms.ComboBox cobMatchID;
        private System.Windows.Forms.DataGridView grdMatchRemove;
        private System.Windows.Forms.TextBox txtSearchCancelMatch;
        private System.Windows.Forms.Button btnSearchCancelMatch;
    }
}