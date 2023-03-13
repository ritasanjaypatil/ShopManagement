namespace ShopManagement
{
    partial class UnOrderCustomer
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
            this.dtgUnorderCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnorderCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUnorderCustomer
            // 
            this.dtgUnorderCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUnorderCustomer.Location = new System.Drawing.Point(106, 92);
            this.dtgUnorderCustomer.Name = "dtgUnorderCustomer";
            this.dtgUnorderCustomer.RowHeadersWidth = 102;
            this.dtgUnorderCustomer.RowTemplate.Height = 40;
            this.dtgUnorderCustomer.Size = new System.Drawing.Size(1241, 709);
            this.dtgUnorderCustomer.TabIndex = 0;
            this.dtgUnorderCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUnorderCustomer_CellContentClick);
            // 
            // UnOrderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 1023);
            this.Controls.Add(this.dtgUnorderCustomer);
            this.Name = "UnOrderCustomer";
            this.Text = "UnOrderCustomer";
            this.Load += new System.EventHandler(this.UnOrderCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnorderCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUnorderCustomer;
    }
}