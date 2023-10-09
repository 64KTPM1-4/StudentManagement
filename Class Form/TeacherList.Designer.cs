namespace QuanLiSinhVien
{
    partial class TeacherList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherList));
            this.AppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TeacherGridView = new System.Windows.Forms.DataGridView();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.DeleteTeacherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).BeginInit();
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
            // TeacherGridView
            // 
            this.TeacherGridView.AllowUserToResizeColumns = false;
            this.TeacherGridView.AllowUserToResizeRows = false;
            this.TeacherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeacherGridView.ColumnHeadersHeight = 29;
            this.TeacherGridView.GridColor = System.Drawing.SystemColors.Control;
            this.TeacherGridView.Location = new System.Drawing.Point(413, 192);
            this.TeacherGridView.Name = "TeacherGridView";
            this.TeacherGridView.ReadOnly = true;
            this.TeacherGridView.RowHeadersWidth = 51;
            this.TeacherGridView.RowTemplate.Height = 24;
            this.TeacherGridView.Size = new System.Drawing.Size(736, 579);
            this.TeacherGridView.TabIndex = 15;
            this.TeacherGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherGridView_CellClick);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1214, 192);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 40);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "Quay lại";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacherButton.Location = new System.Drawing.Point(106, 192);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(225, 35);
            this.AddTeacherButton.TabIndex = 17;
            this.AddTeacherButton.Text = "Thêm giảng viên";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // DeleteTeacherButton
            // 
            this.DeleteTeacherButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTeacherButton.Location = new System.Drawing.Point(106, 256);
            this.DeleteTeacherButton.Name = "DeleteTeacherButton";
            this.DeleteTeacherButton.Size = new System.Drawing.Size(225, 35);
            this.DeleteTeacherButton.TabIndex = 18;
            this.DeleteTeacherButton.Text = "Xóa giảng viên";
            this.DeleteTeacherButton.UseVisualStyleBackColor = true;
            this.DeleteTeacherButton.Visible = false;
            this.DeleteTeacherButton.Click += new System.EventHandler(this.DeleteTeacherButton_Click);
            // 
            // TeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1849, 833);
            this.Controls.Add(this.DeleteTeacherButton);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.TeacherGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AppName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherList";
            this.Text = "TeacherList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView TeacherGridView;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.Button DeleteTeacherButton;
    }
}