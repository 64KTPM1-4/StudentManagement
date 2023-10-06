namespace QuanLiSinhVien
{
    partial class AddTeacher
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
            this.AddTeacherLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTeacherLabel
            // 
            this.AddTeacherLabel.AutoSize = true;
            this.AddTeacherLabel.BackColor = System.Drawing.SystemColors.Window;
            this.AddTeacherLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacherLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AddTeacherLabel.Location = new System.Drawing.Point(201, 57);
            this.AddTeacherLabel.Name = "AddTeacherLabel";
            this.AddTeacherLabel.Size = new System.Drawing.Size(126, 22);
            this.AddTeacherLabel.TabIndex = 7;
            this.AddTeacherLabel.Text = "Tên giảng viên";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacherButton.Location = new System.Drawing.Point(191, 90);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(146, 33);
            this.AddTeacherButton.TabIndex = 10;
            this.AddTeacherButton.Text = "Đồng ý";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Visible = false;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 369);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.AddTeacherLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddTeacherLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddTeacherButton;
    }
}