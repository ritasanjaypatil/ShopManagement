namespace ShopManagement
{
    partial class frmType
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
            this.lblTType = new System.Windows.Forms.Label();
            this.btnTSave = new System.Windows.Forms.Button();
            this.btnTClear = new System.Windows.Forms.Button();
            this.cmbTType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTType.Location = new System.Drawing.Point(324, 156);
            this.lblTType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(45, 20);
            this.lblTType.TabIndex = 1;
            this.lblTType.Text = "Type";
            // 
            // btnTSave
            // 
            this.btnTSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSave.Location = new System.Drawing.Point(327, 339);
            this.btnTSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTSave.Name = "btnTSave";
            this.btnTSave.Size = new System.Drawing.Size(125, 39);
            this.btnTSave.TabIndex = 13;
            this.btnTSave.Text = "Save";
            this.btnTSave.UseVisualStyleBackColor = true;
            this.btnTSave.Click += new System.EventHandler(this.btnTSave_Click);
            // 
            // btnTClear
            // 
            this.btnTClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTClear.Location = new System.Drawing.Point(531, 339);
            this.btnTClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTClear.Name = "btnTClear";
            this.btnTClear.Size = new System.Drawing.Size(125, 39);
            this.btnTClear.TabIndex = 14;
            this.btnTClear.Text = "Clear";
            this.btnTClear.UseVisualStyleBackColor = true;
            this.btnTClear.Click += new System.EventHandler(this.btnTClear_Click);
            // 
            // cmbTType
            // 
            this.cmbTType.FormattingEnabled = true;
            this.cmbTType.Items.AddRange(new object[] {
            "Means",
            "Womens",
            "Kids"});
            this.cmbTType.Location = new System.Drawing.Point(531, 156);
            this.cmbTType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTType.Name = "cmbTType";
            this.cmbTType.Size = new System.Drawing.Size(145, 24);
            this.cmbTType.TabIndex = 15;
            // 
            // frmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.cmbTType);
            this.Controls.Add(this.btnTClear);
            this.Controls.Add(this.btnTSave);
            this.Controls.Add(this.lblTType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmType";
            this.Text = "frmType";
            this.Load += new System.EventHandler(this.frmType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTType;
        private System.Windows.Forms.Button btnTSave;
        private System.Windows.Forms.Button btnTClear;
        private System.Windows.Forms.ComboBox cmbTType;
    }
}