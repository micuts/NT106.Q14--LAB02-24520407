using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    [Serializable]
    public class SinhVien
    {
        public string Name { get; set; }
        public int MSSV { get; set; }
        public string SDT { get; set; }
        public float Diem1 { get; set; }
        public float Diem2 { get; set; }
        public float Diem3 { get; set; }
        public float DTB { get; set; }

        public void TinhDiemTrungBinh()
        {
            DTB = (Diem1 + Diem2 + Diem3) / 3;
        }

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"{MSSV}\n" +
                   $"{SDT}\n" +
                   $"{Diem1}\n" +
                   $"{Diem2}\n" +
                   $"{Diem3}\n" +
                   $"{DTB:F2}\n " +
                   $"--------------------------\n";
        }
    }
}
