namespace QuanLiSinhVien
{
    partial class AddMainTeacher
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
            this.TeacherListBox = new System.Windows.Forms.ListBox();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeacherListBox
            // 
            this.TeacherListBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherListBox.FormattingEnabled = true;
            this.TeacherListBox.ItemHeight = 25;
            this.TeacherListBox.Location = new System.Drawing.Point(114, 65);
            this.TeacherListBox.Name = "TeacherListBox";
            this.TeacherListBox.Size = new System.Drawing.Size(197, 29);
            this.TeacherListBox.TabIndex = 0;
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacherButton.Location = new System.Drawing.Point(132, 109);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(161, 35);
            this.AddTeacherButton.TabIndex = 1;
            this.AddTeacherButton.Text = "Đồng ý";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // AddMainTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 239);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.TeacherListBox);
            this.Name = "AddMainTeacher";
            this.Text = "AddMainTeacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TeacherListBox;
        private System.Windows.Forms.Button AddTeacherButton;
    }
}