namespace ShopManagement
{
    partial class frmProduct
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
            this.lblPType = new System.Windows.Forms.Label();
            this.txtPProduct = new System.Windows.Forms.TextBox();
            this.cmbPType = new System.Windows.Forms.ComboBox();
            this.lblPProduct = new System.Windows.Forms.Label();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPType
            // 
            this.lblPType.AutoSize = true;
            this.lblPType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPType.Location = new System.Drawing.Point(325, 211);
            this.lblPType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPType.Name = "lblPType";
            this.lblPType.Size = new System.Drawing.Size(45, 20);
            this.lblPType.TabIndex = 2;
            this.lblPType.Text = "Type";
            // 
            // txtPProduct
            // 
            this.txtPProduct.Location = new System.Drawing.Point(514, 315);
            this.txtPProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPProduct.Name = "txtPProduct";
            this.txtPProduct.Size = new System.Drawing.Size(141, 22);
            this.txtPProduct.TabIndex = 3;
            // 
            // cmbPType
            // 
            this.cmbPType.FormattingEnabled = true;
            this.cmbPType.Location = new System.Drawing.Point(509, 211);
            this.cmbPType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPType.Name = "cmbPType";
            this.cmbPType.Size = new System.Drawing.Size(141, 24);
            this.cmbPType.TabIndex = 8;
            this.cmbPType.SelectedIndexChanged += new System.EventHandler(this.cmbPType_SelectedIndexChanged);
            // 
            // lblPProduct
            // 
            this.lblPProduct.AutoSize = true;
            this.lblPProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPProduct.Location = new System.Drawing.Point(325, 314);
            this.lblPProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPProduct.Name = "lblPProduct";
            this.lblPProduct.Size = new System.Drawing.Size(67, 20);
            this.lblPProduct.TabIndex = 9;
            this.lblPProduct.Text = "Product";
            // 
            // btnPSave
            // 
            this.btnPSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSave.Location = new System.Drawing.Point(311, 423);
            this.btnPSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(125, 39);
            this.btnPSave.TabIndex = 14;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = true;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPClear
            // 
            this.btnPClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClear.Location = new System.Drawing.Point(528, 423);
            this.btnPClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(125, 39);
            this.btnPClear.TabIndex = 15;
            this.btnPClear.Text = "Clear";
            this.btnPClear.UseVisualStyleBackColor = true;
            this.btnPClear.Click += new System.EventHandler(this.btnPClear_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.btnPClear);
            this.Controls.Add(this.btnPSave);
            this.Controls.Add(this.lblPProduct);
            this.Controls.Add(this.cmbPType);
            this.Controls.Add(this.txtPProduct);
            this.Controls.Add(this.lblPType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPType;
        private System.Windows.Forms.TextBox txtPProduct;
        private System.Windows.Forms.ComboBox cmbPType;
        private System.Windows.Forms.Label lblPProduct;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPClear;
    }
}