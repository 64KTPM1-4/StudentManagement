namespace QuanLiSinhVien
{
    partial class StudentInSubject
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
            this.AppName = new System.Windows.Forms.Label();
            this.SubjectStudentGridView = new System.Windows.Forms.DataGridView();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.AddClassStudentButton = new System.Windows.Forms.Button();
            this.DeleteClassStudentButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectStudentGridView)).BeginInit();
            this.SuspendLayout();
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
            this.AppName.Location = new System.Drawing.Point(435, 63);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(648, 47);
            this.AppName.TabIndex = 5;
            this.AppName.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
            // 
            // SubjectStudentGridView
            // 
            this.SubjectStudentGridView.AllowUserToResizeColumns = false;
            this.SubjectStudentGridView.AllowUserToResizeRows = false;
            this.SubjectStudentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjectStudentGridView.ColumnHeadersHeight = 29;
            this.SubjectStudentGridView.GridColor = System.Drawing.SystemColors.Control;
            this.SubjectStudentGridView.Location = new System.Drawing.Point(406, 186);
            this.SubjectStudentGridView.Name = "SubjectStudentGridView";
            this.SubjectStudentGridView.ReadOnly = true;
            this.SubjectStudentGridView.RowHeadersWidth = 51;
            this.SubjectStudentGridView.RowTemplate.Height = 24;
            this.SubjectStudentGridView.Size = new System.Drawing.Size(736, 579);
            this.SubjectStudentGridView.TabIndex = 10;
            this.SubjectStudentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectStudentGridView_CellClick);
            this.SubjectStudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectStudentGridView_CellClick);
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLabel.Location = new System.Drawing.Point(429, 151);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(54, 32);
            this.ClassNameLabel.TabIndex = 13;
            this.ClassNameLabel.Text = "AA";
            // 
            // AddClassStudentButton
            // 
            this.AddClassStudentButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassStudentButton.Location = new System.Drawing.Point(77, 260);
            this.AddClassStudentButton.Name = "AddClassStudentButton";
            this.AddClassStudentButton.Size = new System.Drawing.Size(256, 40);
            this.AddClassStudentButton.TabIndex = 14;
            this.AddClassStudentButton.Text = "Thêm sinh viên";
            this.AddClassStudentButton.UseVisualStyleBackColor = true;
            this.AddClassStudentButton.Click += new System.EventHandler(this.AddClassStudentButton_Click);
            // 
            // DeleteClassStudentButton
            // 
            this.DeleteClassStudentButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClassStudentButton.Location = new System.Drawing.Point(77, 319);
            this.DeleteClassStudentButton.Name = "DeleteClassStudentButton";
            this.DeleteClassStudentButton.Size = new System.Drawing.Size(256, 40);
            this.DeleteClassStudentButton.TabIndex = 15;
            this.DeleteClassStudentButton.Text = "Xóa sinh viên";
            this.DeleteClassStudentButton.UseVisualStyleBackColor = true;
            this.DeleteClassStudentButton.Visible = false;
            this.DeleteClassStudentButton.Click += new System.EventHandler(this.DeleteClassStudentButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1202, 260);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 40);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "Quay lại";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointButton.Location = new System.Drawing.Point(77, 380);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(256, 40);
            this.PointButton.TabIndex = 17;
            this.PointButton.Text = "Chấm điểm sinh viên";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(77, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Ghi lỗi vi phạm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // StudentInSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 833);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PointButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteClassStudentButton);
            this.Controls.Add(this.AddClassStudentButton);
            this.Controls.Add(this.ClassNameLabel);
            this.Controls.Add(this.SubjectStudentGridView);
            this.Controls.Add(this.AppName);
            this.Name = "StudentInSubject";
            this.Text = "StudentInSubject";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectStudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.DataGridView SubjectStudentGridView;
        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.Button AddClassStudentButton;
        private System.Windows.Forms.Button DeleteClassStudentButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button button2;
    }
}