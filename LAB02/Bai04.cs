using Lab02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai04 : Form
    {
        List<SinhVien> sinhvien = new List<SinhVien>();
        int currentIndex = 0;
        string path = "input4.txt";
        string outputPath = "output4.txt";
        public Bai04()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void read_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name.Text;
                int mssv = int.Parse(ID.Text);
                string sdt = Phone.Text;
                float diem1 = float.Parse(Course_1.Text);
                float diem2 = float.Parse(course_2.Text);
                float diem3 = float.Parse(course_3.Text);

                if (sdt.Length != 10 || !sdt.StartsWith("0"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    return;
                }
                if (mssv.ToString().Length != 8)
                {
                    MessageBox.Show("MSSV không hợp lệ!");
                    return;
                }
                if (diem1 < 0 || diem1 > 10 || diem2 < 0 || diem2 > 10 || diem3 < 0 || diem3 > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ!");
                    return;
                }

                SinhVien sv = new SinhVien
                {
                    Name = name,
                    MSSV = mssv,
                    SDT = sdt,
                    Diem1 = diem1,
                    Diem2 = diem2,
                    Diem3 = diem3,
                };
                sv.TinhDiemTrungBinh();

                sinhvien.Add(sv);
                richTextBox1.AppendText($"{sv}\n\n");

                this.name.Clear();
                ID.Clear();
                Phone.Clear();
                Course_1.Clear();
                course_2.Clear();
                course_3.Clear();
                this.name.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Write_File_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, sinhvien);
                }
                MessageBox.Show("Đã ghi thông tin sinh viên vào file input4.txt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Không tìm thấy file input4.txt!");
                    return;
                }

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    sinhvien = (List<SinhVien>)bf.Deserialize(fs);
                }

                foreach (var sv in sinhvien)
                    sv.TinhDiemTrungBinh();

                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    foreach (var sv in sinhvien)
                        sw.WriteLine($"{sv.Name}\n" +
                            $"{sv.MSSV}\n" +
                            $"{sv.SDT}\n" +
                            $"{sv.Diem1}\n" +
                            $"{sv.Diem2}\n" +
                            $"{sv.Diem3}\n" +
                            $"{sv.DTB}\n " +
                            $"--------------------------\n");
                }

                currentIndex = 0;
                HienThiTrang(currentIndex);

                MessageBox.Show("Đã đọc file và ghi thông tin sinh viên vào output4.txt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        
    }
        private void HienThiTrang(int index)
        {
            if (sinhvien.Count == 0) return;

            var sv = sinhvien[index];
            read_name.Text = sv.Name;
            read_id.Text = sv.MSSV.ToString();
            read_phone.Text = sv.SDT;
            mon1.Text = sv.Diem1.ToString();
            mon2.Text = sv.Diem2.ToString();
            mon3.Text = sv.Diem3.ToString();
            diemtb.Text = sv.DTB.ToString("0.00");

            label15.Text = $"{index + 1} / {sinhvien.Count}";

            // Vô hiệu hóa nút khi ở đầu/cuối
            Back.Enabled = index > 0;
            next.Enabled = index < sinhvien.Count - 1;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (currentIndex < sinhvien.Count - 1)
            {
                currentIndex++;
                HienThiTrang(currentIndex);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                HienThiTrang(currentIndex);
            }
        }
    }
}
