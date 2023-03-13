namespace ShopManagement
{
    partial class frmSize
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
            this.lblSType = new System.Windows.Forms.Label();
            this.cmbSType = new System.Windows.Forms.ComboBox();
            this.lblSProduct = new System.Windows.Forms.Label();
            this.lblSPrice = new System.Windows.Forms.Label();
            this.lblSSize = new System.Windows.Forms.Label();
            this.lblSRprice = new System.Windows.Forms.Label();
            this.cmbSProduct = new System.Windows.Forms.ComboBox();
            this.txtSSize = new System.Windows.Forms.TextBox();
            this.txtSMRP = new System.Windows.Forms.TextBox();
            this.txtSRprice = new System.Windows.Forms.TextBox();
            this.btnSSave = new System.Windows.Forms.Button();
            this.btnSCLear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSType
            // 
            this.lblSType.AutoSize = true;
            this.lblSType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSType.Location = new System.Drawing.Point(318, 212);
            this.lblSType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSType.Name = "lblSType";
            this.lblSType.Size = new System.Drawing.Size(45, 20);
            this.lblSType.TabIndex = 3;
            this.lblSType.Text = "Type";
            // 
            // cmbSType
            // 
            this.cmbSType.FormattingEnabled = true;
            this.cmbSType.Location = new System.Drawing.Point(577, 213);
            this.cmbSType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSType.Name = "cmbSType";
            this.cmbSType.Size = new System.Drawing.Size(141, 24);
            this.cmbSType.TabIndex = 9;
            this.cmbSType.SelectedIndexChanged += new System.EventHandler(this.cmbSType_SelectedIndexChanged);
            // 
            // lblSProduct
            // 
            this.lblSProduct.AutoSize = true;
            this.lblSProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSProduct.Location = new System.Drawing.Point(318, 291);
            this.lblSProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSProduct.Name = "lblSProduct";
            this.lblSProduct.Size = new System.Drawing.Size(67, 20);
            this.lblSProduct.TabIndex = 10;
            this.lblSProduct.Text = "Product";
            // 
            // lblSPrice
            // 
            this.lblSPrice.AutoSize = true;
            this.lblSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPrice.Location = new System.Drawing.Point(318, 441);
            this.lblSPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSPrice.Name = "lblSPrice";
            this.lblSPrice.Size = new System.Drawing.Size(46, 20);
            this.lblSPrice.TabIndex = 11;
            this.lblSPrice.Text = "MRP";
            // 
            // lblSSize
            // 
            this.lblSSize.AutoSize = true;
            this.lblSSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSize.Location = new System.Drawing.Point(318, 366);
            this.lblSSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSize.Name = "lblSSize";
            this.lblSSize.Size = new System.Drawing.Size(42, 20);
            this.lblSSize.TabIndex = 12;
            this.lblSSize.Text = "Size";
            // 
            // lblSRprice
            // 
            this.lblSRprice.AutoSize = true;
            this.lblSRprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSRprice.Location = new System.Drawing.Point(318, 512);
            this.lblSRprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSRprice.Name = "lblSRprice";
            this.lblSRprice.Size = new System.Drawing.Size(87, 20);
            this.lblSRprice.TabIndex = 13;
            this.lblSRprice.Text = "Real Price";
            // 
            // cmbSProduct
            // 
            this.cmbSProduct.FormattingEnabled = true;
            this.cmbSProduct.Location = new System.Drawing.Point(577, 292);
            this.cmbSProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSProduct.Name = "cmbSProduct";
            this.cmbSProduct.Size = new System.Drawing.Size(141, 24);
            this.cmbSProduct.TabIndex = 14;
            this.cmbSProduct.SelectedIndexChanged += new System.EventHandler(this.cmbSProduct_SelectedIndexChanged);
            // 
            // txtSSize
            // 
            this.txtSSize.Location = new System.Drawing.Point(577, 367);
            this.txtSSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSSize.Name = "txtSSize";
            this.txtSSize.Size = new System.Drawing.Size(141, 22);
            this.txtSSize.TabIndex = 15;
            // 
            // txtSMRP
            // 
            this.txtSMRP.Location = new System.Drawing.Point(577, 442);
            this.txtSMRP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSMRP.Name = "txtSMRP";
            this.txtSMRP.Size = new System.Drawing.Size(141, 22);
            this.txtSMRP.TabIndex = 16;
            // 
            // txtSRprice
            // 
            this.txtSRprice.Location = new System.Drawing.Point(577, 513);
            this.txtSRprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSRprice.Name = "txtSRprice";
            this.txtSRprice.Size = new System.Drawing.Size(141, 22);
            this.txtSRprice.TabIndex = 17;
            // 
            // btnSSave
            // 
            this.btnSSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSave.Location = new System.Drawing.Point(352, 593);
            this.btnSSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSSave.Name = "btnSSave";
            this.btnSSave.Size = new System.Drawing.Size(125, 39);
            this.btnSSave.TabIndex = 18;
            this.btnSSave.Text = "Save";
            this.btnSSave.UseVisualStyleBackColor = true;
            this.btnSSave.Click += new System.EventHandler(this.btnSSave_Click);
            // 
            // btnSCLear
            // 
            this.btnSCLear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCLear.Location = new System.Drawing.Point(571, 593);
            this.btnSCLear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSCLear.Name = "btnSCLear";
            this.btnSCLear.Size = new System.Drawing.Size(125, 39);
            this.btnSCLear.TabIndex = 19;
            this.btnSCLear.Text = "Clear";
            this.btnSCLear.UseVisualStyleBackColor = true;
            this.btnSCLear.Click += new System.EventHandler(this.btnSCLear_Click);
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.btnSCLear);
            this.Controls.Add(this.btnSSave);
            this.Controls.Add(this.txtSRprice);
            this.Controls.Add(this.txtSMRP);
            this.Controls.Add(this.txtSSize);
            this.Controls.Add(this.cmbSProduct);
            this.Controls.Add(this.lblSRprice);
            this.Controls.Add(this.lblSSize);
            this.Controls.Add(this.lblSPrice);
            this.Controls.Add(this.lblSProduct);
            this.Controls.Add(this.cmbSType);
            this.Controls.Add(this.lblSType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSize";
            this.Text = "frmSize";
            this.Load += new System.EventHandler(this.frmSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSType;
        private System.Windows.Forms.ComboBox cmbSType;
        private System.Windows.Forms.Label lblSProduct;
        private System.Windows.Forms.Label lblSPrice;
        private System.Windows.Forms.Label lblSSize;
        private System.Windows.Forms.Label lblSRprice;
        private System.Windows.Forms.ComboBox cmbSProduct;
        private System.Windows.Forms.TextBox txtSSize;
        private System.Windows.Forms.TextBox txtSMRP;
        private System.Windows.Forms.TextBox txtSRprice;
        private System.Windows.Forms.Button btnSSave;
        private System.Windows.Forms.Button btnSCLear;
    }
}