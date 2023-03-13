namespace ShopManagement
{
    partial class FrmOrder
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
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderProduct = new System.Windows.Forms.Label();
            this.cmbOType = new System.Windows.Forms.ComboBox();
            this.cmbOProduct = new System.Windows.Forms.ComboBox();
            this.dtgVOrder = new System.Windows.Forms.DataGridView();
            this.lblOPrice = new System.Windows.Forms.Label();
            this.txtOPrice = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOClear = new System.Windows.Forms.Button();
            this.btnOAddToC = new System.Windows.Forms.Button();
            this.btnORFrC = new System.Windows.Forms.Button();
            this.lblOName = new System.Windows.Forms.Label();
            this.lblOPhone = new System.Windows.Forms.Label();
            this.lblOEmail = new System.Windows.Forms.Label();
            this.txtOName = new System.Windows.Forms.TextBox();
            this.txtOPhone = new System.Windows.Forms.TextBox();
            this.txtOEmail = new System.Windows.Forms.TextBox();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.btnOTotal = new System.Windows.Forms.Button();
            this.txtOTotal = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(20, 41);
            this.lblOrderType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(39, 16);
            this.lblOrderType.TabIndex = 0;
            this.lblOrderType.Text = "Type";
            this.lblOrderType.Click += new System.EventHandler(this.lblOrderType_Click);
            // 
            // lblOrderProduct
            // 
            this.lblOrderProduct.AutoSize = true;
            this.lblOrderProduct.Location = new System.Drawing.Point(20, 88);
            this.lblOrderProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderProduct.Name = "lblOrderProduct";
            this.lblOrderProduct.Size = new System.Drawing.Size(53, 16);
            this.lblOrderProduct.TabIndex = 1;
            this.lblOrderProduct.Text = "Product";
            this.lblOrderProduct.Click += new System.EventHandler(this.lblOrderProduct_Click);
            // 
            // cmbOType
            // 
            this.cmbOType.FormattingEnabled = true;
            this.cmbOType.Location = new System.Drawing.Point(106, 41);
            this.cmbOType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOType.Name = "cmbOType";
            this.cmbOType.Size = new System.Drawing.Size(97, 24);
            this.cmbOType.TabIndex = 2;
            this.cmbOType.SelectedIndexChanged += new System.EventHandler(this.cmbOType_SelectedIndexChanged);
            // 
            // cmbOProduct
            // 
            this.cmbOProduct.FormattingEnabled = true;
            this.cmbOProduct.Location = new System.Drawing.Point(106, 85);
            this.cmbOProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOProduct.Name = "cmbOProduct";
            this.cmbOProduct.Size = new System.Drawing.Size(97, 24);
            this.cmbOProduct.TabIndex = 3;
            this.cmbOProduct.SelectedIndexChanged += new System.EventHandler(this.cmbOProduct_SelectedIndexChanged);
            // 
            // dtgVOrder
            // 
            this.dtgVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVOrder.Location = new System.Drawing.Point(30, 134);
            this.dtgVOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dtgVOrder.Name = "dtgVOrder";
            this.dtgVOrder.RowHeadersWidth = 102;
            this.dtgVOrder.RowTemplate.Height = 40;
            this.dtgVOrder.Size = new System.Drawing.Size(286, 183);
            this.dtgVOrder.TabIndex = 4;
            this.dtgVOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVOrder_CellContentClick);
            this.dtgVOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgVOrder_MouseClick);
            // 
            // lblOPrice
            // 
            this.lblOPrice.AutoSize = true;
            this.lblOPrice.Location = new System.Drawing.Point(20, 360);
            this.lblOPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOPrice.Name = "lblOPrice";
            this.lblOPrice.Size = new System.Drawing.Size(38, 16);
            this.lblOPrice.TabIndex = 5;
            this.lblOPrice.Text = "Price";
            // 
            // txtOPrice
            // 
            this.txtOPrice.Location = new System.Drawing.Point(114, 357);
            this.txtOPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtOPrice.Name = "txtOPrice";
            this.txtOPrice.Size = new System.Drawing.Size(89, 22);
            this.txtOPrice.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(36, 445);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 38);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOClear
            // 
            this.btnOClear.Location = new System.Drawing.Point(178, 445);
            this.btnOClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnOClear.Name = "btnOClear";
            this.btnOClear.Size = new System.Drawing.Size(93, 38);
            this.btnOClear.TabIndex = 8;
            this.btnOClear.Text = "Clear";
            this.btnOClear.UseVisualStyleBackColor = true;
            // 
            // btnOAddToC
            // 
            this.btnOAddToC.Location = new System.Drawing.Point(388, 184);
            this.btnOAddToC.Margin = new System.Windows.Forms.Padding(2);
            this.btnOAddToC.Name = "btnOAddToC";
            this.btnOAddToC.Size = new System.Drawing.Size(117, 53);
            this.btnOAddToC.TabIndex = 9;
            this.btnOAddToC.Text = "Add To Cart";
            this.btnOAddToC.UseVisualStyleBackColor = true;
            this.btnOAddToC.Click += new System.EventHandler(this.btnOAddToC_Click);
            // 
            // btnORFrC
            // 
            this.btnORFrC.Location = new System.Drawing.Point(381, 269);
            this.btnORFrC.Margin = new System.Windows.Forms.Padding(2);
            this.btnORFrC.Name = "btnORFrC";
            this.btnORFrC.Size = new System.Drawing.Size(124, 60);
            this.btnORFrC.TabIndex = 10;
            this.btnORFrC.Text = "Remove from Cart";
            this.btnORFrC.UseVisualStyleBackColor = true;
            this.btnORFrC.Click += new System.EventHandler(this.btnORFrC_Click);
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Location = new System.Drawing.Point(592, 44);
            this.lblOName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(44, 16);
            this.lblOName.TabIndex = 11;
            this.lblOName.Text = "Name";
            this.lblOName.Click += new System.EventHandler(this.lblOName_Click);
            // 
            // lblOPhone
            // 
            this.lblOPhone.AutoSize = true;
            this.lblOPhone.Location = new System.Drawing.Point(592, 101);
            this.lblOPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOPhone.Name = "lblOPhone";
            this.lblOPhone.Size = new System.Drawing.Size(46, 16);
            this.lblOPhone.TabIndex = 12;
            this.lblOPhone.Text = "Phone";
            // 
            // lblOEmail
            // 
            this.lblOEmail.AutoSize = true;
            this.lblOEmail.Location = new System.Drawing.Point(592, 155);
            this.lblOEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOEmail.Name = "lblOEmail";
            this.lblOEmail.Size = new System.Drawing.Size(41, 16);
            this.lblOEmail.TabIndex = 13;
            this.lblOEmail.Text = "Email";
            // 
            // txtOName
            // 
            this.txtOName.Location = new System.Drawing.Point(716, 38);
            this.txtOName.Margin = new System.Windows.Forms.Padding(2);
            this.txtOName.Name = "txtOName";
            this.txtOName.Size = new System.Drawing.Size(89, 22);
            this.txtOName.TabIndex = 14;
            // 
            // txtOPhone
            // 
            this.txtOPhone.Location = new System.Drawing.Point(716, 98);
            this.txtOPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtOPhone.Name = "txtOPhone";
            this.txtOPhone.Size = new System.Drawing.Size(89, 22);
            this.txtOPhone.TabIndex = 15;
            // 
            // txtOEmail
            // 
            this.txtOEmail.Location = new System.Drawing.Point(716, 152);
            this.txtOEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtOEmail.Name = "txtOEmail";
            this.txtOEmail.Size = new System.Drawing.Size(89, 22);
            this.txtOEmail.TabIndex = 16;
            // 
            // lvOrder
            // 
            this.lvOrder.FullRowSelect = true;
            this.lvOrder.GridLines = true;
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(562, 200);
            this.lvOrder.Margin = new System.Windows.Forms.Padding(2);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(330, 178);
            this.lvOrder.TabIndex = 17;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            this.lvOrder.SelectedIndexChanged += new System.EventHandler(this.lvOrder_SelectedIndexChanged);
            // 
            // btnOTotal
            // 
            this.btnOTotal.Location = new System.Drawing.Point(566, 412);
            this.btnOTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnOTotal.Name = "btnOTotal";
            this.btnOTotal.Size = new System.Drawing.Size(93, 38);
            this.btnOTotal.TabIndex = 18;
            this.btnOTotal.Text = "Total";
            this.btnOTotal.UseVisualStyleBackColor = true;
            this.btnOTotal.Click += new System.EventHandler(this.btnOTotal_Click);
            // 
            // txtOTotal
            // 
            this.txtOTotal.Location = new System.Drawing.Point(726, 421);
            this.txtOTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOTotal.Name = "txtOTotal";
            this.txtOTotal.Size = new System.Drawing.Size(139, 22);
            this.txtOTotal.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 499);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 53);
            this.button3.TabIndex = 20;
            this.button3.Text = "Order Confirmed";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtOTotal);
            this.Controls.Add(this.btnOTotal);
            this.Controls.Add(this.lvOrder);
            this.Controls.Add(this.txtOEmail);
            this.Controls.Add(this.txtOPhone);
            this.Controls.Add(this.txtOName);
            this.Controls.Add(this.lblOEmail);
            this.Controls.Add(this.lblOPhone);
            this.Controls.Add(this.lblOName);
            this.Controls.Add(this.btnORFrC);
            this.Controls.Add(this.btnOAddToC);
            this.Controls.Add(this.btnOClear);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtOPrice);
            this.Controls.Add(this.lblOPrice);
            this.Controls.Add(this.dtgVOrder);
            this.Controls.Add(this.cmbOProduct);
            this.Controls.Add(this.cmbOType);
            this.Controls.Add(this.lblOrderProduct);
            this.Controls.Add(this.lblOrderType);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOrderProduct;
        private System.Windows.Forms.ComboBox cmbOType;
        private System.Windows.Forms.ComboBox cmbOProduct;
        private System.Windows.Forms.DataGridView dtgVOrder;
        private System.Windows.Forms.Label lblOPrice;
        private System.Windows.Forms.TextBox txtOPrice;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOClear;
        private System.Windows.Forms.Button btnOAddToC;
        private System.Windows.Forms.Button btnORFrC;
        private System.Windows.Forms.Label lblOName;
        private System.Windows.Forms.Label lblOPhone;
        private System.Windows.Forms.Label lblOEmail;
        private System.Windows.Forms.TextBox txtOName;
        private System.Windows.Forms.TextBox txtOPhone;
        private System.Windows.Forms.TextBox txtOEmail;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.Button btnOTotal;
        private System.Windows.Forms.TextBox txtOTotal;
        private System.Windows.Forms.Button button3;
    }
}