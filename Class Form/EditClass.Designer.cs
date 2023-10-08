namespace QuanLiSinhVien
{
    partial class EditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClass));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.EditClassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(144, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddClassButton
            // 
            this.AddClassButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassButton.Location = new System.Drawing.Point(144, 75);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(146, 33);
            this.AddClassButton.TabIndex = 5;
            this.AddClassButton.Text = "Đồng ý";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.EditClassButton_Click);
            // 
            // EditClassLabel
            // 
            this.EditClassLabel.AutoSize = true;
            this.EditClassLabel.BackColor = System.Drawing.SystemColors.Window;
            this.EditClassLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditClassLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EditClassLabel.Location = new System.Drawing.Point(160, 29);
            this.EditClassLabel.Name = "EditClassLabel";
            this.EditClassLabel.Size = new System.Drawing.Size(72, 22);
            this.EditClassLabel.TabIndex = 6;
            this.EditClassLabel.Text = "Tên lớp";
            // 
            // EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 192);
            this.Controls.Add(this.EditClassLabel);
            this.Controls.Add(this.AddClassButton);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditClass";
            this.Text = "EditClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddClassButton;
        private System.Windows.Forms.Label EditClassLabel;
    }
}