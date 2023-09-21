namespace QuanLiSinhVien
{
    partial class Class_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_Form));
            this.AppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Show_Class = new System.Windows.Forms.Button();
            this.Add_Class = new System.Windows.Forms.Button();
            this.Delete_Class = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.AppName.TabIndex = 0;
            this.AppName.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Show_Class
            // 
            this.Show_Class.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Class.Location = new System.Drawing.Point(519, 177);
            this.Show_Class.Name = "Show_Class";
            this.Show_Class.Size = new System.Drawing.Size(489, 58);
            this.Show_Class.TabIndex = 2;
            this.Show_Class.Text = "Xem danh sách lớp";
            this.Show_Class.UseVisualStyleBackColor = true;
            this.Show_Class.Click += new System.EventHandler(this.Show_Class_Click);
            // 
            // Add_Class
            // 
            this.Add_Class.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Class.Location = new System.Drawing.Point(519, 271);
            this.Add_Class.Name = "Add_Class";
            this.Add_Class.Size = new System.Drawing.Size(489, 58);
            this.Add_Class.TabIndex = 3;
            this.Add_Class.Text = "Thêm lớp mới";
            this.Add_Class.UseVisualStyleBackColor = true;
            this.Add_Class.Click += new System.EventHandler(this.Add_Class_Click);
            // 
            // Delete_Class
            // 
            this.Delete_Class.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Class.Location = new System.Drawing.Point(519, 365);
            this.Delete_Class.Name = "Delete_Class";
            this.Delete_Class.Size = new System.Drawing.Size(489, 58);
            this.Delete_Class.TabIndex = 4;
            this.Delete_Class.Text = "Xóa lớp đang có";
            this.Delete_Class.UseVisualStyleBackColor = true;
            this.Delete_Class.Click += new System.EventHandler(this.Delete_Class_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(519, 459);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(489, 58);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Class_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1849, 833);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete_Class);
            this.Controls.Add(this.Add_Class);
            this.Controls.Add(this.Show_Class);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AppName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Class_Form";
            this.Text = "Phần mềm quản lí sinh viên - Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Show_Class;
        private System.Windows.Forms.Button Add_Class;
        private System.Windows.Forms.Button Delete_Class;
        private System.Windows.Forms.Button Exit;
    }
}

