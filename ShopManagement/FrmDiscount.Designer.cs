namespace ShopManagement
{
    partial class FrmDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOGprice = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.lblNP = new System.Windows.Forms.Label();
            this.lblDOSPrice = new System.Windows.Forms.Label();
            this.txtDPercent = new System.Windows.Forms.TextBox();
            this.txtNprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdatedP = new System.Windows.Forms.Button();
            this.btnCAlNP = new System.Windows.Forms.Button();
            this.lblOName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offer Form";
            // 
            // lblOGprice
            // 
            this.lblOGprice.AutoSize = true;
            this.lblOGprice.Location = new System.Drawing.Point(415, 341);
            this.lblOGprice.Name = "lblOGprice";
            this.lblOGprice.Size = new System.Drawing.Size(210, 32);
            this.lblOGprice.TabIndex = 1;
            this.lblOGprice.Text = "Orginal Price of";
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Location = new System.Drawing.Point(415, 467);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(308, 32);
            this.lblDP.TabIndex = 2;
            this.lblDP.Text = "Discount In Percentage";
            // 
            // lblNP
            // 
            this.lblNP.AutoSize = true;
            this.lblNP.Location = new System.Drawing.Point(424, 574);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(142, 32);
            this.lblNP.TabIndex = 3;
            this.lblNP.Text = "New Price";
            // 
            // lblDOSPrice
            // 
            this.lblDOSPrice.AutoSize = true;
            this.lblDOSPrice.Location = new System.Drawing.Point(866, 330);
            this.lblDOSPrice.Name = "lblDOSPrice";
            this.lblDOSPrice.Size = new System.Drawing.Size(0, 32);
            this.lblDOSPrice.TabIndex = 4;
            // 
            // txtDPercent
            // 
            this.txtDPercent.Location = new System.Drawing.Point(884, 461);
            this.txtDPercent.Name = "txtDPercent";
            this.txtDPercent.Size = new System.Drawing.Size(222, 38);
            this.txtDPercent.TabIndex = 5;
            // 
            // txtNprice
            // 
            this.txtNprice.Location = new System.Drawing.Point(884, 568);
            this.txtNprice.Name = "txtNprice";
            this.txtNprice.Size = new System.Drawing.Size(222, 38);
            this.txtNprice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1164, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1177, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1164, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rs";
            // 
            // btnUpdatedP
            // 
            this.btnUpdatedP.Location = new System.Drawing.Point(516, 788);
            this.btnUpdatedP.Name = "btnUpdatedP";
            this.btnUpdatedP.Size = new System.Drawing.Size(310, 53);
            this.btnUpdatedP.TabIndex = 11;
            this.btnUpdatedP.Text = "Updated Price";
            this.btnUpdatedP.UseVisualStyleBackColor = true;
            this.btnUpdatedP.Click += new System.EventHandler(this.btnUpdatedP_Click);
            // 
            // btnCAlNP
            // 
            this.btnCAlNP.Location = new System.Drawing.Point(958, 788);
            this.btnCAlNP.Name = "btnCAlNP";
            this.btnCAlNP.Size = new System.Drawing.Size(310, 53);
            this.btnCAlNP.TabIndex = 12;
            this.btnCAlNP.Text = "Calculated New Price";
            this.btnCAlNP.UseVisualStyleBackColor = true;
            this.btnCAlNP.Click += new System.EventHandler(this.btnCAlNP_Click);
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Location = new System.Drawing.Point(663, 341);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(0, 32);
            this.lblOName.TabIndex = 13;
            // 
            // FrmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 1068);
            this.Controls.Add(this.lblOName);
            this.Controls.Add(this.btnCAlNP);
            this.Controls.Add(this.btnUpdatedP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNprice);
            this.Controls.Add(this.txtDPercent);
            this.Controls.Add(this.lblDOSPrice);
            this.Controls.Add(this.lblNP);
            this.Controls.Add(this.lblDP);
            this.Controls.Add(this.lblOGprice);
            this.Controls.Add(this.label1);
            this.Name = "FrmDiscount";
            this.Text = "FrmDiscount";
            this.Load += new System.EventHandler(this.FrmDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOGprice;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.Label lblNP;
        private System.Windows.Forms.Label lblDOSPrice;
        private System.Windows.Forms.TextBox txtDPercent;
        private System.Windows.Forms.TextBox txtNprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdatedP;
        private System.Windows.Forms.Button btnCAlNP;
        private System.Windows.Forms.Label lblOName;
    }
}