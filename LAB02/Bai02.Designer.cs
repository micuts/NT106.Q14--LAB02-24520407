namespace LAB02
{
    partial class Bai02
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxFileName = new System.Windows.Forms.RichTextBox();
            this.textBoxSize = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxURL = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxline = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Read = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.textboxcontent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên file";
            // 
            // textboxFileName
            // 
            this.textboxFileName.Location = new System.Drawing.Point(243, 114);
            this.textboxFileName.Name = "textboxFileName";
            this.textboxFileName.Size = new System.Drawing.Size(355, 40);
            this.textboxFileName.TabIndex = 1;
            this.textboxFileName.Text = "";
            this.textboxFileName.TextChanged += new System.EventHandler(this.textboxFileName_TextChanged);
            // 
            // textBoxSize
            // 
            this.textBoxSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSize.Location = new System.Drawing.Point(243, 204);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(355, 42);
            this.textBoxSize.TabIndex = 2;
            this.textBoxSize.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // textboxURL
            // 
            this.textboxURL.Location = new System.Drawing.Point(243, 311);
            this.textboxURL.Name = "textboxURL";
            this.textboxURL.Size = new System.Drawing.Size(355, 90);
            this.textboxURL.TabIndex = 4;
            this.textboxURL.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "URL";
            // 
            // textboxline
            // 
            this.textboxline.Location = new System.Drawing.Point(243, 423);
            this.textboxline.Name = "textboxline";
            this.textboxline.Size = new System.Drawing.Size(355, 44);
            this.textboxline.TabIndex = 6;
            this.textboxline.Text = "";
            this.textboxline.TextChanged += new System.EventHandler(this.textboxline_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Words count";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(243, 508);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 44);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(81, 24);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(517, 53);
            this.Read.TabIndex = 10;
            this.Read.Text = "Read File";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Character count";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(243, 615);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(355, 43);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(81, 719);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(517, 56);
            this.exit.TabIndex = 13;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textboxcontent
            // 
            this.textboxcontent.Location = new System.Drawing.Point(705, 66);
            this.textboxcontent.Name = "textboxcontent";
            this.textboxcontent.Size = new System.Drawing.Size(700, 673);
            this.textboxcontent.TabIndex = 14;
            this.textboxcontent.Text = "";
            this.textboxcontent.TextChanged += new System.EventHandler(this.textboxcontent_TextChanged);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 907);
            this.Controls.Add(this.textboxcontent);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textboxFileName);
            this.Controls.Add(this.label1);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textboxFileName;
        private System.Windows.Forms.RichTextBox textBoxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textboxURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textboxline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RichTextBox textboxcontent;
    }
}