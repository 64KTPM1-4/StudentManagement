namespace QuanLiSinhVien
{
    partial class ClassList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.Add_Class = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classServicesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.AppName.TabIndex = 3;
            this.AppName.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1356, 192);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 40);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "Quay lại";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Add_Class
            // 
            this.Add_Class.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Class.Location = new System.Drawing.Point(133, 188);
            this.Add_Class.Name = "Add_Class";
            this.Add_Class.Size = new System.Drawing.Size(153, 39);
            this.Add_Class.TabIndex = 7;
            this.Add_Class.Text = "Thêm lớp";
            this.Add_Class.UseVisualStyleBackColor = true;
            this.Add_Class.Click += new System.EventHandler(this.Add_Class_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(411, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 579);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 833);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add_Class);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassList";
            this.Text = "Phần mềm quản lí sinh viên - Danh sách lớp";
            this.Load += new System.EventHandler(this.ClassList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classServicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.BindingSource classModelBindingSource;
        private System.Windows.Forms.BindingSource classModelBindingSource1;
        private System.Windows.Forms.BindingSource classServicesBindingSource;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button Add_Class;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}