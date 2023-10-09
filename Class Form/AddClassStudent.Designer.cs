namespace QuanLiSinhVien
{
    partial class AddClassStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassStudent));
            this.AddStudentToClassButton = new System.Windows.Forms.Button();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddStudentToClassButton
            // 
            this.AddStudentToClassButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentToClassButton.Location = new System.Drawing.Point(157, 154);
            this.AddStudentToClassButton.Name = "AddStudentToClassButton";
            this.AddStudentToClassButton.Size = new System.Drawing.Size(173, 34);
            this.AddStudentToClassButton.TabIndex = 1;
            this.AddStudentToClassButton.Text = "Đồng ý";
            this.AddStudentToClassButton.UseVisualStyleBackColor = true;
            this.AddStudentToClassButton.Click += new System.EventHandler(this.AddStudentToClassButton_Click);
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(157, 98);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(210, 33);
            this.StudentComboBox.TabIndex = 2;
            this.StudentComboBox.Text = "Chọn sinh viên";
            // 
            // AddClassStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(520, 281);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.AddStudentToClassButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClassStudent";
            this.Text = "AddClassStudent";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddStudentToClassButton;
        private System.Windows.Forms.ComboBox StudentComboBox;
    }
}