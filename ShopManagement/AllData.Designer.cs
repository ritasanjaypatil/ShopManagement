namespace ShopManagement
{
    partial class AllData
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
            this.dtgvALLDATA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvALLDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvALLDATA
            // 
            this.dtgvALLDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvALLDATA.Location = new System.Drawing.Point(96, 105);
            this.dtgvALLDATA.Name = "dtgvALLDATA";
            this.dtgvALLDATA.RowHeadersWidth = 102;
            this.dtgvALLDATA.RowTemplate.Height = 40;
            this.dtgvALLDATA.Size = new System.Drawing.Size(1803, 1077);
            this.dtgvALLDATA.TabIndex = 0;
            // 
            // AllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1998, 1283);
            this.Controls.Add(this.dtgvALLDATA);
            this.Name = "AllData";
            this.Text = "AllData";
            this.Load += new System.EventHandler(this.AllData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvALLDATA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvALLDATA;
    }
}