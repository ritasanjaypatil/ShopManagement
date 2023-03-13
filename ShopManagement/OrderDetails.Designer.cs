namespace ShopManagement
{
    partial class OrderDetails
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unorderProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unorderCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsToolStripMenuItem,
            this.orderProductsToolStripMenuItem,
            this.unorderProductToolStripMenuItem,
            this.unorderCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1488, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(200, 45);
            this.allProductsToolStripMenuItem.Text = "All Products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // orderProductsToolStripMenuItem
            // 
            this.orderProductsToolStripMenuItem.Name = "orderProductsToolStripMenuItem";
            this.orderProductsToolStripMenuItem.Size = new System.Drawing.Size(244, 45);
            this.orderProductsToolStripMenuItem.Text = "Order Products";
            this.orderProductsToolStripMenuItem.Click += new System.EventHandler(this.orderProductsToolStripMenuItem_Click);
            // 
            // unorderProductToolStripMenuItem
            // 
            this.unorderProductToolStripMenuItem.Name = "unorderProductToolStripMenuItem";
            this.unorderProductToolStripMenuItem.Size = new System.Drawing.Size(264, 48);
            this.unorderProductToolStripMenuItem.Text = "Unorder Product";
            this.unorderProductToolStripMenuItem.Click += new System.EventHandler(this.unorderProductToolStripMenuItem_Click);
            // 
            // unorderCustomerToolStripMenuItem
            // 
            this.unorderCustomerToolStripMenuItem.Name = "unorderCustomerToolStripMenuItem";
            this.unorderCustomerToolStripMenuItem.Size = new System.Drawing.Size(289, 48);
            this.unorderCustomerToolStripMenuItem.Text = "Unorder Customer";
            this.unorderCustomerToolStripMenuItem.Click += new System.EventHandler(this.unorderCustomerToolStripMenuItem_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 866);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unorderProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unorderCustomerToolStripMenuItem;
    }
}