namespace QuanLiSinhVien.Login
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.CpasswordLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 149);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.SystemColors.Highlight;
            this.AppName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AppName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(442, 60);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(648, 47);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameLabel.Location = new System.Drawing.Point(539, 183);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(140, 25);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Tên đăng nhập";
            this.usernameLabel.MouseHover += new System.EventHandler(this.usernameLabel_Mouse);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordLabel.Location = new System.Drawing.Point(541, 233);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(95, 25);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Mật khẩu";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Username.Location = new System.Drawing.Point(519, 180);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(489, 33);
            this.Username.TabIndex = 9;
            this.Username.Tag = "";
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Password.Location = new System.Drawing.Point(519, 230);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(489, 33);
            this.Password.TabIndex = 10;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ConfirmPassword.Location = new System.Drawing.Point(519, 287);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(489, 33);
            this.ConfirmPassword.TabIndex = 11;
            this.ConfirmPassword.TextChanged += new System.EventHandler(this.ConfirmPassword_TextChanged);
            // 
            // CpasswordLabel
            // 
            this.CpasswordLabel.AutoSize = true;
            this.CpasswordLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpasswordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CpasswordLabel.Location = new System.Drawing.Point(539, 290);
            this.CpasswordLabel.Name = "CpasswordLabel";
            this.CpasswordLabel.Size = new System.Drawing.Size(179, 25);
            this.CpasswordLabel.TabIndex = 12;
            this.CpasswordLabel.Text = "Xác nhận mật khẩu";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(519, 346);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(146, 30);
            this.SignUpButton.TabIndex = 13;
            this.SignUpButton.Text = "Đăng ký";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(862, 346);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(146, 30);
            this.ReturnButton.TabIndex = 14;
            this.ReturnButton.Text = "Quay lại";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1849, 833);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.CpasswordLabel);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "Phần mềm quản lí sinh viên - Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label CpasswordLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}