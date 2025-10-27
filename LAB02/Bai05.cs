using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Phim
        {
            public string TenPhim { get; set; }
            public double GiaVe { get; set; }
            public string PhongChieu { get; set; }
            public int SoVeBan { get; set; }
            public int SoVeTon { get; set; }

            public double DoanhThu => GiaVe * SoVeBan;

            public override string ToString()
            {
                return $"{TenPhim,-25} | Giá vé: {GiaVe,8:0.00} | Phòng: {PhongChieu,-10} | Đã bán: {SoVeBan,5} | Tồn: {SoVeTon,5} | Doanh thu: {DoanhThu,10:0.00}";
            }
        }
        public List<Phim> DanhSachPhim { get; private set; } = new List<Phim>();
        string inputPath = @"input5.txt";
        string outputPath = @"output5.txt";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void DocVe_Click(object sender, EventArgs e)
        {
            DanhSachPhim.Clear();
            richTextBox1.Clear();
            if (!File.Exists(inputPath))
            {
                MessageBox.Show("File input5.txt không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamReader sr = new StreamReader(inputPath))
            {
                while (!sr.EndOfStream)
                {
                    string tenPhim = sr.ReadLine();
                    if (string.IsNullOrWhiteSpace(tenPhim)) break;

                    if (!double.TryParse(sr.ReadLine(), out double giaVe))
                    {
                        MessageBox.Show($"Giá vé của phim '{tenPhim}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    string phongChieu = sr.ReadLine()?.Trim() ?? "N/A";

                    if (!int.TryParse(sr.ReadLine(), out int soVeBan) ||
                        !int.TryParse(sr.ReadLine(), out int soVeTon))
                    {
                        MessageBox.Show($"Dữ liệu vé của phim '{tenPhim}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    sr.ReadLine();
                    Phim phim = new Phim
                    {
                        TenPhim = tenPhim,
                        GiaVe = giaVe,
                        PhongChieu = phongChieu,
                        SoVeBan = soVeBan,
                        SoVeTon = soVeTon
                    };
                    DanhSachPhim.Add(phim);
                }
            }

            var thongKeGop = DanhSachPhim
                .GroupBy(p => p.TenPhim)
                .Select(g => new Phim
                {
                    TenPhim = g.Key,
                    GiaVe = g.First().GiaVe,
                    PhongChieu = string.Join(", ", g.Select(x => x.PhongChieu)),
                    SoVeBan = g.Sum(x => x.SoVeBan),
                    SoVeTon = g.Sum(x => x.SoVeTon)
                })
                .OrderByDescending(p => p.DoanhThu)
                .ToList();

            richTextBox1.Clear();

            foreach (var p in thongKeGop)
            {
                richTextBox1.AppendText($"Tên phim : {p.TenPhim}\n");
                richTextBox1.AppendText($"Giá vé : {p.GiaVe}\n");
                richTextBox1.AppendText($"Phòng chiếu : {p.PhongChieu}\n");
                richTextBox1.AppendText($"Số vé bán : {p.SoVeBan}\n");
                richTextBox1.AppendText($"Số vé tồn : {p.SoVeTon}\n\n");
            }

            DanhSachPhim = thongKeGop;

            MessageBox.Show("Đọc dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void XuatVe_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã có dữ liệu chưa
                if (DanhSachPhim == null || DanhSachPhim.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất. Vui lòng nhấn 'Đọc vé' trước khi xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var thongKe = DanhSachPhim.OrderByDescending(p => p.DoanhThu).ToList();

                // Hiển thị thống kê ra richTextBox1
                richTextBox1.Clear();
                richTextBox1.AppendText("=== THỐNG KÊ DOANH THU PHÒNG VÉ ===\n");
                richTextBox1.AppendText(string.Format("{0,-30} {1,8} {2,8} {3,10} {4,15} {5,8}\n",
                    "Tên phim", "Đã bán", "Tồn", "Tỉ lệ", "Doanh thu", "Xếp hạng"));
                richTextBox1.AppendText(new string('-', 90) + "\n");

                int rank = 1;
                foreach (var p in thongKe)
                {
                    int tong = p.SoVeBan + p.SoVeTon;
                    double tiLe = tong > 0 ? (double)p.SoVeBan / tong * 100.0 : 0.0;

                    richTextBox1.AppendText(string.Format(CultureInfo.InvariantCulture,
                        "{0,-30} {1,8} {2,8} {3,9:0.0}% {4,15:0.00} {5,8}\n",
                        p.TenPhim, p.SoVeBan, p.SoVeTon, tiLe, p.DoanhThu, rank));
                    rank++;
                }
                richTextBox1.AppendText(new string('-', 90) + "\n\n");

                // Ghi file ra ổ đĩa
                string fullOutputPath;
                try
                {
                    fullOutputPath = Path.GetFullPath(outputPath);
                }
                catch
                {
                    fullOutputPath = outputPath;
                }

                using (FileStream fs = new FileStream(fullOutputPath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine("=== THỐNG KÊ DOANH THU PHÒNG VÉ ===");
                    sw.WriteLine(string.Format("{0,-30} {1,8} {2,8} {3,10} {4,15} {5,8}", "Tên phim", "Đã bán", "Tồn", "Tỉ lệ", "Doanh thu", "Xếp hạng"));
                    sw.WriteLine(new string('-', 90));

                    rank = 1;
                    foreach (var p in thongKe)
                    {
                        int tong = p.SoVeBan + p.SoVeTon;
                        double tiLe = tong > 0 ? (double)p.SoVeBan / tong * 100.0 : 0.0;

                        sw.WriteLine(string.Format(CultureInfo.InvariantCulture,
                            "{0,-30} {1,8} {2,8} {3,9:0.0}% {4,15:0.00} {5,8}",
                            p.TenPhim, p.SoVeBan, p.SoVeTon, tiLe, p.DoanhThu, rank));
                        rank++;
                    }

                    sw.Flush();
                    fs.Flush(true);
                }

                MessageBox.Show($"Xuất file '{Path.GetFullPath(outputPath)}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show("Không có quyền ghi file: " + uaEx.Message, "Lỗi ghi file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Lỗi IO khi ghi file (kiểm tra xem file đang mở không): " + ioEx.Message, "Lỗi IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
