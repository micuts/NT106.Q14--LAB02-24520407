using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\User\source\repos\LAB02\LAB02\bin\Debug\input1.txt.txt";
                Doc_Ghi_file.Text = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ghi_click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Doc_Ghi_file.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào ô trước khi ghi file.", "Thiếu Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng hàm nếu không có dữ liệu
            }
            try
            {
                string outputPath = @"C:\Users\User\source\repos\LAB02\LAB02\bin\Debug\output1.txt";

                using (StreamWriter writer = new StreamWriter("output1.txt "))
                {
                    writer.Write(Doc_Ghi_file.Text.ToUpper());
                }
                MessageBox.Show($"Đã ghi file thành công ");
                Doc_Ghi_file.Text = File.ReadAllText(outputPath, Encoding.UTF8);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi file : {ex.Message}");
            }


        }
    }
}

