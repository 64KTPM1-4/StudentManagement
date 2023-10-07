namespace QuanLiSinhVien
{
    partial class SubjectInClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectInClass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.ClassSubjectGridView = new System.Windows.Forms.DataGridView();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AddClassSubjectButton = new System.Windows.Forms.Button();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.DeleteClassSubjectButton = new System.Windows.Forms.Button();
            this.ShowSubjectStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassSubjectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 149);
            this.pictureBox1.TabIndex = 3;
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
            this.AppName.Location = new System.Drawing.Point(435, 63);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(648, 47);
            this.AppName.TabIndex = 4;
            this.AppName.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
            // 
            // ClassSubjectGridView
            // 
            this.ClassSubjectGridView.AllowUserToResizeColumns = false;
            this.ClassSubjectGridView.AllowUserToResizeRows = false;
            this.ClassSubjectGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassSubjectGridView.ColumnHeadersHeight = 29;
            this.ClassSubjectGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ClassSubjectGridView.Location = new System.Drawing.Point(363, 223);
            this.ClassSubjectGridView.Name = "ClassSubjectGridView";
            this.ClassSubjectGridView.ReadOnly = true;
            this.ClassSubjectGridView.RowHeadersWidth = 51;
            this.ClassSubjectGridView.RowTemplate.Height = 24;
            this.ClassSubjectGridView.Size = new System.Drawing.Size(736, 579);
            this.ClassSubjectGridView.TabIndex = 9;
            this.ClassSubjectGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassSubjectGridView_CellContentClick);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1199, 199);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 40);
            this.ReturnButton.TabIndex = 10;
            this.ReturnButton.Text = "Quay lại";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AddClassSubjectButton
            // 
            this.AddClassSubjectButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassSubjectButton.Location = new System.Drawing.Point(65, 250);
            this.AddClassSubjectButton.Name = "AddClassSubjectButton";
            this.AddClassSubjectButton.Size = new System.Drawing.Size(256, 40);
            this.AddClassSubjectButton.TabIndex = 11;
            this.AddClassSubjectButton.Text = "Thêm môn cho lớp";
            this.AddClassSubjectButton.UseVisualStyleBackColor = true;
            this.AddClassSubjectButton.Click += new System.EventHandler(this.AddClassSubject_Click);
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLabel.Location = new System.Drawing.Point(454, 172);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(54, 32);
            this.ClassNameLabel.TabIndex = 12;
            this.ClassNameLabel.Text = "AA";
            // 
            // DeleteClassSubjectButton
            // 
            this.DeleteClassSubjectButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClassSubjectButton.Location = new System.Drawing.Point(65, 308);
            this.DeleteClassSubjectButton.Name = "DeleteClassSubjectButton";
            this.DeleteClassSubjectButton.Size = new System.Drawing.Size(256, 40);
            this.DeleteClassSubjectButton.TabIndex = 13;
            this.DeleteClassSubjectButton.Text = "Xóa môn học";
            this.DeleteClassSubjectButton.UseVisualStyleBackColor = true;
            this.DeleteClassSubjectButton.Visible = false;
            this.DeleteClassSubjectButton.Click += new System.EventHandler(this.DeleteClassSubjectButton_Click);
            // 
            // ShowSubjectStudent
            // 
            this.ShowSubjectStudent.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSubjectStudent.Location = new System.Drawing.Point(65, 365);
            this.ShowSubjectStudent.Name = "ShowSubjectStudent";
            this.ShowSubjectStudent.Size = new System.Drawing.Size(276, 40);
            this.ShowSubjectStudent.TabIndex = 14;
            this.ShowSubjectStudent.Text = "Xem danh sách sinh viên ";
            this.ShowSubjectStudent.UseVisualStyleBackColor = true;
            this.ShowSubjectStudent.Visible = false;
            this.ShowSubjectStudent.Click += new System.EventHandler(this.ShowSubjectStudent_Click);
            // 
            // SubjectInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 833);
            this.Controls.Add(this.ShowSubjectStudent);
            this.Controls.Add(this.DeleteClassSubjectButton);
            this.Controls.Add(this.ClassNameLabel);
            this.Controls.Add(this.AddClassSubjectButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ClassSubjectGridView);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SubjectInClass";
            this.Text = "SubjectInClass";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SubjectInClass_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassSubjectGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.DataGridView ClassSubjectGridView;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button AddClassSubjectButton;
        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.Button DeleteClassSubjectButton;
        private System.Windows.Forms.Button ShowSubjectStudent;
    }
}