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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInSubject));
            this.AppName = new System.Windows.Forms.Label();
            this.SubjectStudentGridView = new System.Windows.Forms.DataGridView();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.AddClassStudentButton = new System.Windows.Forms.Button();
            this.DeleteClassStudentButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.NoteButton = new System.Windows.Forms.Button();
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
            this.SubjectStudentGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubjectStudentGridView.ColumnHeadersHeight = 29;
            this.SubjectStudentGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.SubjectStudentGridView.GridColor = System.Drawing.SystemColors.Control;
            this.SubjectStudentGridView.Location = new System.Drawing.Point(319, 186);
            this.SubjectStudentGridView.Name = "SubjectStudentGridView";
            this.SubjectStudentGridView.ReadOnly = true;
            this.SubjectStudentGridView.RowHeadersWidth = 51;
            this.SubjectStudentGridView.RowTemplate.Height = 24;
            this.SubjectStudentGridView.Size = new System.Drawing.Size(1122, 579);
            this.SubjectStudentGridView.TabIndex = 10;
            this.SubjectStudentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectStudentGridView_CellClick);
            this.SubjectStudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectStudentGridView_CellClick);
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLabel.Location = new System.Drawing.Point(329, 151);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(54, 32);
            this.ClassNameLabel.TabIndex = 13;
            this.ClassNameLabel.Text = "AA";
            // 
            // AddClassStudentButton
            // 
            this.AddClassStudentButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassStudentButton.Location = new System.Drawing.Point(34, 260);
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
            this.DeleteClassStudentButton.Location = new System.Drawing.Point(34, 321);
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
            this.ReturnButton.Location = new System.Drawing.Point(1510, 186);
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
            this.PointButton.Location = new System.Drawing.Point(34, 367);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(256, 40);
            this.PointButton.TabIndex = 17;
            this.PointButton.Text = "Chấm điểm sinh viên";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Visible = false;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // NoteButton
            // 
            this.NoteButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteButton.Location = new System.Drawing.Point(34, 413);
            this.NoteButton.Name = "NoteButton";
            this.NoteButton.Size = new System.Drawing.Size(256, 40);
            this.NoteButton.TabIndex = 18;
            this.NoteButton.Text = "Ghi lỗi vi phạm";
            this.NoteButton.UseVisualStyleBackColor = true;
            this.NoteButton.Visible = false;
            this.NoteButton.Click += new System.EventHandler(this.NoteButton_Click);
            // 
            // StudentInSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1787, 833);
            this.Controls.Add(this.NoteButton);
            this.Controls.Add(this.PointButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteClassStudentButton);
            this.Controls.Add(this.AddClassStudentButton);
            this.Controls.Add(this.ClassNameLabel);
            this.Controls.Add(this.SubjectStudentGridView);
            this.Controls.Add(this.AppName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentInSubject";
            this.Text = "StudentInSubject";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentInSubject_MouseClick);
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
        private System.Windows.Forms.Button NoteButton;
    }
}