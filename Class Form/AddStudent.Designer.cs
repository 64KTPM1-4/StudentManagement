namespace QuanLiSinhVien
{
    partial class AddStudent
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.AddStudentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddClassButton
            // 
            this.AddClassButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassButton.Location = new System.Drawing.Point(129, 96);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(146, 33);
            this.AddClassButton.TabIndex = 5;
            this.AddClassButton.Text = "Đồng ý";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // AddStudentLabel
            // 
            this.AddStudentLabel.AutoSize = true;
            this.AddStudentLabel.BackColor = System.Drawing.SystemColors.Window;
            this.AddStudentLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AddStudentLabel.Location = new System.Drawing.Point(146, 54);
            this.AddStudentLabel.Name = "AddStudentLabel";
            this.AddStudentLabel.Size = new System.Drawing.Size(116, 22);
            this.AddStudentLabel.TabIndex = 6;
            this.AddStudentLabel.Text = "Tên sinh viên";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 192);
            this.Controls.Add(this.AddStudentLabel);
            this.Controls.Add(this.AddClassButton);
            this.Controls.Add(this.textBox1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddClassButton;
        private System.Windows.Forms.Label AddStudentLabel;
    }
}