using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    using (StreamReader sr = new StreamReader("input3.txt"))
                    {
                        string noidung = sr.ReadToEnd();
                        ket_qua.Text = noidung;
                    }
                    MessageBox.Show("Đọc file thành công!", "Thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tìm thấy file input3.txt!");
                }

            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            string outputPath = @"C:\Users\User\source\repos\LAB02\LAB02\bin\Debug\output3.txt";
            try
            {
                string[] lines = ket_qua.Text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> ketqua = new List<string>();

                foreach (string line in lines)
                {
                    string bieuthuc = line.Trim();
                    if (bieuthuc == "") continue;

                    int index = bieuthuc.IndexOf('=');
                    if (index != -1)
                        bieuthuc = bieuthuc.Substring(0, index).Trim();

                    try
                    {
                        double result = tinhBieuThuc(bieuthuc);
                        if (double.IsNaN(result) || double.IsInfinity(result))
                            ketqua.Add($"{bieuthuc} = Lỗi biểu thức");
                        else
                            ketqua.Add($"{bieuthuc} = {result}");
                    }
                    catch (Exception)
                    {
                        ketqua.Add($"{bieuthuc} = Lỗi biểu thức");
                    }
                }

                using (StreamWriter sw = new StreamWriter("output3.txt"))
                {
                    foreach (string kq in ketqua)
                        sw.WriteLine(kq);
                }

                ket_qua.Text = File.ReadAllText(outputPath, Encoding.UTF8);

                MessageBox.Show("Đã ghi kết quả ra file output3.txt", "Thành công");
            }
            catch (Exception loi)
            {
                MessageBox.Show("Lỗi khi ghi file: " + loi.Message);
            }
        }
        private string chuanHoaBieuThuc(string bieuthuc)
        {
            if (bieuthuc == null) return "";
            bieuthuc = bieuthuc.Replace('–', '-').Replace('—', '-');
            bieuthuc = bieuthuc.Replace('\u00A0', ' ');
            return bieuthuc.Trim();
        }


        private double tinhBieuThuc(string bieuthuc)
        {
            bieuthuc = chuanHoaBieuThuc(bieuthuc);

            Stack<double> giaTri = new Stack<double>(); 
            Stack<char> toanTu = new Stack<char>();     
            int i = 0;
            int n = bieuthuc.Length;

            while (i < n)
            {
                if (char.IsWhiteSpace(bieuthuc[i]))
                {
                    i++;
                    continue;
                }

                if ((bieuthuc[i] == '+' || bieuthuc[i] == '-') &&
                    (i == 0 || bieuthuc[i - 1] == '(' || bieuthuc[i - 1] == '+' ||
                     bieuthuc[i - 1] == '-' || bieuthuc[i - 1] == '*' || bieuthuc[i - 1] == '/'))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(bieuthuc[i]);
                    i++;

                    bool coSo = false;
                    while (i < n && (char.IsDigit(bieuthuc[i]) || bieuthuc[i] == '.'))
                    {
                        if (char.IsDigit(bieuthuc[i])) coSo = true;
                        sb.Append(bieuthuc[i]);
                        i++;
                    }

                    if (!coSo && i < n && bieuthuc[i] == '.')
                    {
                        sb.Append(bieuthuc[i]);
                        i++;
                        while (i < n && char.IsDigit(bieuthuc[i]))
                        {
                            sb.Append(bieuthuc[i]);
                            i++;
                        }
                    }

                    if (!double.TryParse(sb.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double so))
                        throw new Exception("Số không hợp lệ: " + sb.ToString());

                    giaTri.Push(so);
                    continue;
                }


                if (char.IsDigit(bieuthuc[i]) || (bieuthuc[i] == '.' && i + 1 < n && char.IsDigit(bieuthuc[i + 1])))
                {
                    StringBuilder sb = new StringBuilder();
                    while (i < n && (char.IsDigit(bieuthuc[i]) || bieuthuc[i] == '.'))
                    {
                        sb.Append(bieuthuc[i]);
                        i++;
                    }

                    if (!double.TryParse(sb.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double so))
                        throw new Exception("Số không hợp lệ: " + sb.ToString());

                    giaTri.Push(so);
                    continue;
                }

                if (bieuthuc[i] == '(')
                {
                    toanTu.Push(bieuthuc[i]);
                    i++;
                    continue;
                }

        
                if (bieuthuc[i] == ')')
                {
                    while (toanTu.Count > 0 && toanTu.Peek() != '(')
                    {
                        thucHienPhepTinh(giaTri, toanTu);
                    }

                    if (toanTu.Count == 0 || toanTu.Peek() != '(')
                        throw new Exception("Dấu ngoặc không hợp lệ");

                    toanTu.Pop();
                    i++;
                    continue;
                }


                if (bieuthuc[i] == '+' || bieuthuc[i] == '-' || bieuthuc[i] == '*' || bieuthuc[i] == '/')
                {
                    char op = bieuthuc[i];
                    while (toanTu.Count > 0 && toanTu.Peek() != '(' && doUuTien(toanTu.Peek()) >= doUuTien(op))
                    {
                        thucHienPhepTinh(giaTri, toanTu);
                    }
                    toanTu.Push(op);
                    i++;
                    continue;
                }

                throw new Exception("Ký tự không hợp lệ trong biểu thức: " + bieuthuc[i]);
            }

            while (toanTu.Count > 0)
            {
                if (toanTu.Peek() == '(' || toanTu.Peek() == ')')
                    throw new Exception("Dấu ngoặc không hợp lệ");

                thucHienPhepTinh(giaTri, toanTu);
            }

            if (giaTri.Count != 1)
                throw new Exception("Biểu thức không hợp lệ");

            return giaTri.Pop();
        }

 
        private void thucHienPhepTinh(Stack<double> giaTri, Stack<char> toanTu)
        {
            if (giaTri.Count < 2) throw new Exception("Thiếu toán hạng");
            double b = giaTri.Pop();
            double a = giaTri.Pop();
            char op = toanTu.Pop();
            giaTri.Push(tinhToan(a, b, op));
        }

        // Hàm trả về độ ưu tiên của toán tử
        private int doUuTien(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        // Hàm tính toán hai toán hạng theo toán tử
        private double tinhToan(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b != 0 ? a / b : double.NaN;
                default: throw new Exception("Toán tử không hợp lệ");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}