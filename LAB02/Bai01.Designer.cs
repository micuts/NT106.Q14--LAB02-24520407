namespace LAB02
{
    partial class Bai01
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
            System.Windows.Forms.Button Ghi_click;
            this.Doc_Ghi_file = new System.Windows.Forms.RichTextBox();
            this.Doc_click = new System.Windows.Forms.Button();
            Ghi_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ghi_click
            // 
            Ghi_click.Location = new System.Drawing.Point(99, 332);
            Ghi_click.Name = "Ghi_click";
            Ghi_click.Size = new System.Drawing.Size(237, 96);
            Ghi_click.TabIndex = 2;
            Ghi_click.Text = "GHI FILE";
            Ghi_click.UseVisualStyleBackColor = true;
            Ghi_click.Click += new System.EventHandler(this.Ghi_click_Click);
            // 
            // Doc_Ghi_file
            // 
            this.Doc_Ghi_file.Location = new System.Drawing.Point(471, 87);
            this.Doc_Ghi_file.Name = "Doc_Ghi_file";
            this.Doc_Ghi_file.Size = new System.Drawing.Size(456, 471);
            this.Doc_Ghi_file.TabIndex = 0;
            this.Doc_Ghi_file.Text = "";
            this.Doc_Ghi_file.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Doc_click
            // 
            this.Doc_click.Location = new System.Drawing.Point(99, 177);
            this.Doc_click.Name = "Doc_click";
            this.Doc_click.Size = new System.Drawing.Size(237, 96);
            this.Doc_click.TabIndex = 1;
            this.Doc_click.Text = "ĐỌC FILE";
            this.Doc_click.UseVisualStyleBackColor = true;
            this.Doc_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 650);
            this.Controls.Add(Ghi_click);
            this.Controls.Add(this.Doc_click);
            this.Controls.Add(this.Doc_Ghi_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Doc_Ghi_file;
        private System.Windows.Forms.Button Doc_click;
    }
}

