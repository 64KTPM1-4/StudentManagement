namespace QuanLiSinhVien
{
    partial class SubjectList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.SubjectGridView = new System.Windows.Forms.DataGridView();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.EmptyClassList = new System.Windows.Forms.Label();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
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
            this.AppName.Location = new System.Drawing.Point(442, 60);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(648, 47);
            this.AppName.TabIndex = 4;
            this.AppName.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
            // 
            // SubjectGridView
            // 
            this.SubjectGridView.AllowUserToResizeColumns = false;
            this.SubjectGridView.AllowUserToResizeRows = false;
            this.SubjectGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjectGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SubjectGridView.ColumnHeadersHeight = 29;
            this.SubjectGridView.GridColor = System.Drawing.SystemColors.Control;
            this.SubjectGridView.Location = new System.Drawing.Point(409, 192);
            this.SubjectGridView.Name = "SubjectGridView";
            this.SubjectGridView.ReadOnly = true;
            this.SubjectGridView.RowHeadersWidth = 51;
            this.SubjectGridView.RowTemplate.Height = 24;
            this.SubjectGridView.Size = new System.Drawing.Size(736, 35);
            this.SubjectGridView.TabIndex = 5;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1249, 121);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 40);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Quay lại";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // EmptyClassList
            // 
            this.EmptyClassList.AutoSize = true;
            this.EmptyClassList.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyClassList.Location = new System.Drawing.Point(396, 346);
            this.EmptyClassList.Name = "EmptyClassList";
            this.EmptyClassList.Size = new System.Drawing.Size(760, 76);
            this.EmptyClassList.TabIndex = 8;
            this.EmptyClassList.Text = "Danh sách môn học trống !";
            this.EmptyClassList.Visible = false;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubjectButton.Location = new System.Drawing.Point(106, 192);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(225, 35);
            this.AddSubjectButton.TabIndex = 9;
            this.AddSubjectButton.Text = "Thêm môn học";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // SubjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 833);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.EmptyClassList);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SubjectGridView);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SubjectList";
            this.Text = "SubjectList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.DataGridView SubjectGridView;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label EmptyClassList;
        private System.Windows.Forms.Button AddSubjectButton;
    }
}