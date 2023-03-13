namespace ShopManagement
{
    partial class OrderProducts1
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
            this.DTGOrderDetails = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblSBName = new System.Windows.Forms.Label();
            this.txtSBName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGOrderDetails
            // 
            this.DTGOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.Column1});
            this.DTGOrderDetails.Location = new System.Drawing.Point(272, 61);
            this.DTGOrderDetails.Name = "DTGOrderDetails";
            this.DTGOrderDetails.RowHeadersWidth = 102;
            this.DTGOrderDetails.RowTemplate.Height = 40;
            this.DTGOrderDetails.Size = new System.Drawing.Size(1475, 782);
            this.DTGOrderDetails.TabIndex = 0;
            this.DTGOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGOrderDetails_CellClick);
            this.DTGOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGOrderDetails_CellContentClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 12;
            this.chk.Name = "chk";
            this.chk.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Offer";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Discount";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 250;
            // 
            // lblSBName
            // 
            this.lblSBName.AutoSize = true;
            this.lblSBName.Location = new System.Drawing.Point(492, 918);
            this.lblSBName.Name = "lblSBName";
            this.lblSBName.Size = new System.Drawing.Size(226, 32);
            this.lblSBName.TabIndex = 1;
            this.lblSBName.Text = "Search By Name";
            // 
            // txtSBName
            // 
            this.txtSBName.Location = new System.Drawing.Point(811, 912);
            this.txtSBName.Name = "txtSBName";
            this.txtSBName.Size = new System.Drawing.Size(286, 38);
            this.txtSBName.TabIndex = 3;
            this.txtSBName.TextChanged += new System.EventHandler(this.txtSBName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(650, 1059);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(246, 56);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1499, 890);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(248, 60);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteD
            // 
            this.btnDeleteD.Location = new System.Drawing.Point(1499, 1014);
            this.btnDeleteD.Name = "btnDeleteD";
            this.btnDeleteD.Size = new System.Drawing.Size(248, 60);
            this.btnDeleteD.TabIndex = 7;
            this.btnDeleteD.Text = "Delete";
            this.btnDeleteD.UseVisualStyleBackColor = true;
            this.btnDeleteD.Click += new System.EventHandler(this.btnDeleteD_Click);
            // 
            // OrderProducts1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2248, 1194);
            this.Controls.Add(this.btnDeleteD);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSBName);
            this.Controls.Add(this.lblSBName);
            this.Controls.Add(this.DTGOrderDetails);
            this.Name = "OrderProducts1";
            this.Text = "OrderProducts1";
            this.Load += new System.EventHandler(this.OrderProducts1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGOrderDetails;
        private System.Windows.Forms.Label lblSBName;
        private System.Windows.Forms.TextBox txtSBName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button btnDeleteD;
    }
}