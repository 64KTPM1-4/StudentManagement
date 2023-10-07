namespace QuanLiSinhVien
{
    partial class SetPoint
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
            this.dqtTextBox = new System.Windows.Forms.TextBox();
            this.dtTextBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dqtTextBox
            // 
            this.dqtTextBox.Location = new System.Drawing.Point(97, 91);
            this.dqtTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dqtTextBox.Name = "dqtTextBox";
            this.dqtTextBox.Size = new System.Drawing.Size(148, 33);
            this.dqtTextBox.TabIndex = 0;
            this.dqtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dtTextBox
            // 
            this.dtTextBox.Location = new System.Drawing.Point(283, 91);
            this.dtTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtTextBox.Name = "dtTextBox";
            this.dtTextBox.Size = new System.Drawing.Size(148, 33);
            this.dtTextBox.TabIndex = 1;
            this.dtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dt_KeyPress);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(188, 134);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(146, 50);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Đồng ý";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Điểm quá trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm thi";
            // 
            // SetPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.dtTextBox);
            this.Controls.Add(this.dqtTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SetPoint";
            this.Text = "SetPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dqtTextBox;
        private System.Windows.Forms.TextBox dtTextBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}