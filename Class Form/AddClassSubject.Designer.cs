namespace QuanLiSinhVien
{
    partial class AddClassSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassSubject));
            this.SubjectListBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectListBox
            // 
            this.SubjectListBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectListBox.FormattingEnabled = true;
            this.SubjectListBox.Location = new System.Drawing.Point(65, 51);
            this.SubjectListBox.Name = "SubjectListBox";
            this.SubjectListBox.Size = new System.Drawing.Size(249, 33);
            this.SubjectListBox.TabIndex = 0;
            this.SubjectListBox.Text = "Chọn môn học";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(106, 105);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(162, 38);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Đồng ý";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddClassSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(419, 207);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SubjectListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClassSubject";
            this.Text = "AddClassSubject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SubjectListBox;
        private System.Windows.Forms.Button OkButton;
    }
}