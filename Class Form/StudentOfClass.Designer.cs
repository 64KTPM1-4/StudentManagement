﻿namespace QuanLiSinhVien
{
    partial class StudentOfClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentOfClass));
            this.AppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClassStudentGridView = new System.Windows.Forms.DataGridView();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassStudentGridView)).BeginInit();
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
            this.AppName.Location = new System.Drawing.Point(442, 60);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(648, 47);
            this.AppName.TabIndex = 1;
            this.AppName.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
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
            // ClassStudentGridView
            // 
            this.ClassStudentGridView.AllowUserToResizeColumns = false;
            this.ClassStudentGridView.AllowUserToResizeRows = false;
            this.ClassStudentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassStudentGridView.ColumnHeadersHeight = 29;
            this.ClassStudentGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ClassStudentGridView.Location = new System.Drawing.Point(416, 202);
            this.ClassStudentGridView.Name = "ClassStudentGridView";
            this.ClassStudentGridView.ReadOnly = true;
            this.ClassStudentGridView.RowHeadersWidth = 51;
            this.ClassStudentGridView.RowTemplate.Height = 24;
            this.ClassStudentGridView.Size = new System.Drawing.Size(736, 579);
            this.ClassStudentGridView.TabIndex = 9;
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLabel.Location = new System.Drawing.Point(480, 154);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(54, 32);
            this.ClassNameLabel.TabIndex = 13;
            this.ClassNameLabel.Text = "AA";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1297, 202);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 40);
            this.ReturnButton.TabIndex = 14;
            this.ReturnButton.Text = "Quay lại";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // StudentOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 833);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ClassNameLabel);
            this.Controls.Add(this.ClassStudentGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AppName);
            this.Name = "StudentOfClass";
            this.Text = "StudentOfClass";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentOfClass_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassStudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView ClassStudentGridView;
        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.Button ReturnButton;
    }
}