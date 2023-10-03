namespace QuanLiSinhVien
{
    partial class AddSubject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.AddSubjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubjectButton.Location = new System.Drawing.Point(146, 103);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(146, 33);
            this.AddSubjectButton.TabIndex = 5;
            this.AddSubjectButton.Text = "Đồng ý";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Visible = false;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // AddSubjectLabel
            // 
            this.AddSubjectLabel.AutoSize = true;
            this.AddSubjectLabel.BackColor = System.Drawing.SystemColors.Window;
            this.AddSubjectLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubjectLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AddSubjectLabel.Location = new System.Drawing.Point(142, 60);
            this.AddSubjectLabel.Name = "AddSubjectLabel";
            this.AddSubjectLabel.Size = new System.Drawing.Size(111, 22);
            this.AddSubjectLabel.TabIndex = 6;
            this.AddSubjectLabel.Text = "Tên môn học";
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 192);
            this.Controls.Add(this.AddSubjectLabel);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.textBox1);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Label AddSubjectLabel;
    }
}