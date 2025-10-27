namespace LAB02
{
    partial class Bai05
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DocVe = new System.Windows.Forms.Button();
            this.XuatVe = new System.Windows.Forms.Button();
            this.Bar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(633, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(632, 708);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // DocVe
            // 
            this.DocVe.BackColor = System.Drawing.Color.Silver;
            this.DocVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocVe.Location = new System.Drawing.Point(90, 260);
            this.DocVe.Name = "DocVe";
            this.DocVe.Size = new System.Drawing.Size(343, 109);
            this.DocVe.TabIndex = 1;
            this.DocVe.Text = "Đọc Vé";
            this.DocVe.UseVisualStyleBackColor = false;
            this.DocVe.Click += new System.EventHandler(this.DocVe_Click);
            // 
            // XuatVe
            // 
            this.XuatVe.BackColor = System.Drawing.Color.Silver;
            this.XuatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatVe.Location = new System.Drawing.Point(90, 433);
            this.XuatVe.Name = "XuatVe";
            this.XuatVe.Size = new System.Drawing.Size(343, 107);
            this.XuatVe.TabIndex = 2;
            this.XuatVe.Text = "Xuất Vé";
            this.XuatVe.UseVisualStyleBackColor = false;
            this.XuatVe.Click += new System.EventHandler(this.XuatVe_Click);
            // 
            // Bar1
            // 
            this.Bar1.Location = new System.Drawing.Point(33, 844);
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(1232, 46);
            this.Bar1.TabIndex = 3;
            this.Bar1.Visible = false;
            this.Bar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(377, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "RẠP CHIẾU PHIM CI NÊ MƠ";
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1349, 927);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bar1);
            this.Controls.Add(this.XuatVe);
            this.Controls.Add(this.DocVe);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Bai05";
            this.Text = "Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button DocVe;
        private System.Windows.Forms.Button XuatVe;
        private System.Windows.Forms.ProgressBar Bar1;
        private System.Windows.Forms.Label label1;
    }
}