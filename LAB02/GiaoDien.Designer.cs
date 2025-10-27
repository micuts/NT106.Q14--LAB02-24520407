namespace LAB02
{
    partial class GiaoDien
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
            this.Bai01 = new System.Windows.Forms.Button();
            this.Bai02 = new System.Windows.Forms.Button();
            this.Bai03 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bai04 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai01
            // 
            this.Bai01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bai01.Location = new System.Drawing.Point(32, 77);
            this.Bai01.Name = "Bai01";
            this.Bai01.Size = new System.Drawing.Size(204, 74);
            this.Bai01.TabIndex = 0;
            this.Bai01.Text = "Bài 1";
            this.Bai01.UseVisualStyleBackColor = false;
            this.Bai01.Click += new System.EventHandler(this.Bai01_Click);
            // 
            // Bai02
            // 
            this.Bai02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Bai02.Location = new System.Drawing.Point(344, 78);
            this.Bai02.Name = "Bai02";
            this.Bai02.Size = new System.Drawing.Size(210, 75);
            this.Bai02.TabIndex = 1;
            this.Bai02.Text = "Bài 2";
            this.Bai02.UseVisualStyleBackColor = false;
            this.Bai02.Click += new System.EventHandler(this.Bai02_Click);
            // 
            // Bai03
            // 
            this.Bai03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bai03.Location = new System.Drawing.Point(671, 77);
            this.Bai03.Name = "Bai03";
            this.Bai03.Size = new System.Drawing.Size(194, 76);
            this.Bai03.TabIndex = 2;
            this.Bai03.Text = "Bài 3";
            this.Bai03.UseVisualStyleBackColor = false;
            this.Bai03.Click += new System.EventHandler(this.Bai03_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quỳnh Duyên - 24520407";
            // 
            // Bai04
            // 
            this.Bai04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Bai04.Location = new System.Drawing.Point(32, 219);
            this.Bai04.Name = "Bai04";
            this.Bai04.Size = new System.Drawing.Size(204, 67);
            this.Bai04.TabIndex = 4;
            this.Bai04.Text = "Bài 4";
            this.Bai04.UseVisualStyleBackColor = false;
            this.Bai04.Click += new System.EventHandler(this.Bai04_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bài 7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(344, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 67);
            this.button2.TabIndex = 6;
            this.button2.Text = "Bài 5";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 579);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bai04);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bai03);
            this.Controls.Add(this.Bai02);
            this.Controls.Add(this.Bai01);
            this.Name = "GiaoDien";
            this.Text = "Giao diện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bai01;
        private System.Windows.Forms.Button Bai02;
        private System.Windows.Forms.Button Bai03;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bai04;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}