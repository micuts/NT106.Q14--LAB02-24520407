using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            Bai01 f = new Bai01();
            f.ShowDialog();
            
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            Bai02 f = new Bai02();
            f.ShowDialog();
        }

        private void Bai03_Click(object sender, EventArgs e)
        {
            Bai03 f = new Bai03();
            f.ShowDialog();
        }

        private void Bai04_Click(object sender, EventArgs e)
        {
            Bai04 f = new Bai04();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai07 f = new Bai07();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai05 f = new Bai05();
            f.ShowDialog();
        }
    }
}
