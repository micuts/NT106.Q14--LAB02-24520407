namespace LAB02
{
    partial class Bai03
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
            this.Read = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.ket_qua = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(59, 123);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(231, 75);
            this.Read.TabIndex = 0;
            this.Read.Text = "Đọc File";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(59, 237);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(231, 75);
            this.write.TabIndex = 1;
            this.write.Text = "Ghi File";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // ket_qua
            // 
            this.ket_qua.Location = new System.Drawing.Point(355, 59);
            this.ket_qua.Name = "ket_qua";
            this.ket_qua.Size = new System.Drawing.Size(593, 531);
            this.ket_qua.TabIndex = 2;
            this.ket_qua.Text = "";
            this.ket_qua.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÍNH TOÁN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ket_qua);
            this.Controls.Add(this.write);
            this.Controls.Add(this.Read);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.RichTextBox ket_qua;
        private System.Windows.Forms.Label label1;
    }
}