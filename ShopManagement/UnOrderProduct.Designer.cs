namespace ShopManagement
{
    partial class UnOrderProduct
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
            this.dtgUnOrderProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnOrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUnOrderProduct
            // 
            this.dtgUnOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUnOrderProduct.Location = new System.Drawing.Point(141, 114);
            this.dtgUnOrderProduct.Name = "dtgUnOrderProduct";
            this.dtgUnOrderProduct.RowHeadersWidth = 102;
            this.dtgUnOrderProduct.RowTemplate.Height = 40;
            this.dtgUnOrderProduct.Size = new System.Drawing.Size(1313, 834);
            this.dtgUnOrderProduct.TabIndex = 0;
            // 
            // UnOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1144);
            this.Controls.Add(this.dtgUnOrderProduct);
            this.Name = "UnOrderProduct";
            this.Text = "UnOrderProduct";
            this.Load += new System.EventHandler(this.UnOrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnOrderProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUnOrderProduct;
    }
}