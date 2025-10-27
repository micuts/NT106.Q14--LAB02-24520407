using System;
using System.IO;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string noidung = sr.ReadToEnd();
                        textboxcontent.Text = noidung;
                        string filename = ofd.SafeFileName;
                        textboxFileName.Text = filename;
                        string URL = ofd.FileName;
                        textboxURL.Text = URL;
                        int demdong = noidung.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        textboxline.Text = demdong.ToString();
                        int demtu = noidung.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        richTextBox1.Text = demtu.ToString();
                        int demkitu = noidung.Length;
                        richTextBox2.Text = demkitu.ToString();
                        FileInfo fi = new FileInfo(URL);
                        long size = fi.Length;
                        textBoxSize.Text = size + " bytes";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void textboxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxcontent_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxline_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
