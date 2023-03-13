namespace ShopManagement
{
    partial class frmUserRegistration
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
            this.lblRegType = new System.Windows.Forms.Label();
            this.lblRegUserName = new System.Windows.Forms.Label();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegState = new System.Windows.Forms.Label();
            this.grpRegGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.cmbRegType = new System.Windows.Forms.ComboBox();
            this.cmbRegState = new System.Windows.Forms.ComboBox();
            this.txtRegUserName = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegClear = new System.Windows.Forms.Button();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.grpRegGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // lblRegType
            // 
            this.lblRegType.AutoSize = true;
            this.lblRegType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegType.Location = new System.Drawing.Point(330, 165);
            this.lblRegType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegType.Name = "lblRegType";
            this.lblRegType.Size = new System.Drawing.Size(45, 20);
            this.lblRegType.TabIndex = 1;
            this.lblRegType.Text = "Type";
            // 
            // lblRegUserName
            // 
            this.lblRegUserName.AutoSize = true;
            this.lblRegUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUserName.Location = new System.Drawing.Point(330, 237);
            this.lblRegUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegUserName.Name = "lblRegUserName";
            this.lblRegUserName.Size = new System.Drawing.Size(53, 20);
            this.lblRegUserName.TabIndex = 2;
            this.lblRegUserName.Text = "Name";
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegEmail.Location = new System.Drawing.Point(330, 302);
            this.lblRegEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(51, 20);
            this.lblRegEmail.TabIndex = 3;
            this.lblRegEmail.Text = "Email";
            this.lblRegEmail.Click += new System.EventHandler(this.lblRegEmail_Click);
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPassword.Location = new System.Drawing.Point(330, 533);
            this.lblRegPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(83, 20);
            this.lblRegPassword.TabIndex = 4;
            this.lblRegPassword.Text = "Password";
            // 
            // lblRegState
            // 
            this.lblRegState.AutoSize = true;
            this.lblRegState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegState.Location = new System.Drawing.Point(330, 418);
            this.lblRegState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegState.Name = "lblRegState";
            this.lblRegState.Size = new System.Drawing.Size(48, 20);
            this.lblRegState.TabIndex = 5;
            this.lblRegState.Text = "State";
            // 
            // grpRegGender
            // 
            this.grpRegGender.Controls.Add(this.rdbFemale);
            this.grpRegGender.Controls.Add(this.rdbMale);
            this.grpRegGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegGender.Location = new System.Drawing.Point(327, 354);
            this.grpRegGender.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegGender.Name = "grpRegGender";
            this.grpRegGender.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegGender.Size = new System.Drawing.Size(410, 51);
            this.grpRegGender.TabIndex = 6;
            this.grpRegGender.TabStop = false;
            this.grpRegGender.Text = "Gender";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(321, 17);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(85, 24);
            this.rdbFemale.TabIndex = 12;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(247, 17);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(66, 24);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // cmbRegType
            // 
            this.cmbRegType.FormattingEnabled = true;
            this.cmbRegType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbRegType.Location = new System.Drawing.Point(596, 165);
            this.cmbRegType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRegType.Name = "cmbRegType";
            this.cmbRegType.Size = new System.Drawing.Size(141, 24);
            this.cmbRegType.TabIndex = 7;
            // 
            // cmbRegState
            // 
            this.cmbRegState.FormattingEnabled = true;
            this.cmbRegState.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttarakhand",
            "Uttar Pradesh",
            "West Bengal"});
            this.cmbRegState.Location = new System.Drawing.Point(596, 418);
            this.cmbRegState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRegState.Name = "cmbRegState";
            this.cmbRegState.Size = new System.Drawing.Size(141, 24);
            this.cmbRegState.TabIndex = 8;
            // 
            // txtRegUserName
            // 
            this.txtRegUserName.Location = new System.Drawing.Point(596, 238);
            this.txtRegUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegUserName.Name = "txtRegUserName";
            this.txtRegUserName.Size = new System.Drawing.Size(141, 22);
            this.txtRegUserName.TabIndex = 9;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(596, 303);
            this.txtRegEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(141, 22);
            this.txtRegEmail.TabIndex = 10;
            this.txtRegEmail.TextChanged += new System.EventHandler(this.txtRegEmail_TextChanged);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(598, 533);
            this.txtRegPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(141, 22);
            this.txtRegPassword.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(388, 608);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 39);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegClear
            // 
            this.btnRegClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegClear.Location = new System.Drawing.Point(588, 608);
            this.btnRegClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegClear.Name = "btnRegClear";
            this.btnRegClear.Size = new System.Drawing.Size(125, 39);
            this.btnRegClear.TabIndex = 13;
            this.btnRegClear.Text = "Clear";
            this.btnRegClear.UseVisualStyleBackColor = true;
            this.btnRegClear.Click += new System.EventHandler(this.btnRegClear_Click);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(329, 474);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(82, 20);
            this.lblPhoneNo.TabIndex = 14;
            this.lblPhoneNo.Text = "Phone No";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(593, 475);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(141, 22);
            this.txtPhoneNo.TabIndex = 15;
            // 
            // frmUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 723);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.btnRegClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.txtRegUserName);
            this.Controls.Add(this.cmbRegState);
            this.Controls.Add(this.cmbRegType);
            this.Controls.Add(this.grpRegGender);
            this.Controls.Add(this.lblRegState);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.lblRegEmail);
            this.Controls.Add(this.lblRegUserName);
            this.Controls.Add(this.lblRegType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUserRegistration";
            this.Text = "frmUserRegistration";
            this.Load += new System.EventHandler(this.frmUserRegistration_Load);
            this.grpRegGender.ResumeLayout(false);
            this.grpRegGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegType;
        private System.Windows.Forms.Label lblRegUserName;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegState;
        private System.Windows.Forms.GroupBox grpRegGender;
        private System.Windows.Forms.ComboBox cmbRegType;
        private System.Windows.Forms.ComboBox cmbRegState;
        private System.Windows.Forms.TextBox txtRegUserName;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegClear;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
    }
}