using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }

        private void Bai07_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            richTextBox1.Visible = false;

            // Gán sự kiện 1 lần duy nhất
            treeView1.BeforeExpand += TreeView1_BeforeExpand;
            treeView1.AfterSelect += TreeView1_AfterSelect;


            // Liệt kê các ổ đĩa
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory.FullName;
                node.Nodes.Add("Đang tải...");
                treeView1.Nodes.Add(node);
            }
        }
        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)

        {
            try
            {
                e.Node.Nodes.Clear();

                string path = e.Node.FullPath;
                if (Directory.Exists(path))
                {
                    foreach (string dir in Directory.GetDirectories(path))
                    {
                        TreeNode node = new TreeNode(Path.GetFileName(dir));
                        node.Nodes.Add("Đang tải...");
                        e.Node.Nodes.Add(node);
                    }

                    foreach (string file in Directory.GetFiles(path))
                    {
                        e.Node.Nodes.Add(new TreeNode(Path.GetFileName(file)));
                    }
                }
            }
            catch { }

        }
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.FullPath;
            ShowFileContent(path);
        }
        private void ShowFileContent(string path)
        {
            if (!File.Exists(path))
            {
                pictureBox1.Visible = false;
                richTextBox1.Visible = false;
                return;
            }

            string ext = Path.GetExtension(path).ToLower();

            try
            {
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    pictureBox1.Visible = true;
                    richTextBox1.Visible = false;

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = Image.FromFile(path);
                }
                else if (ext == ".txt" || ext == ".log" || ext == ".ini" || ext == ".cs")
                {
                    pictureBox1.Visible = false;
                    richTextBox1.Visible = true;
                    richTextBox1.Text = File.ReadAllText(path);
                }
                else
                {
                    pictureBox1.Visible = false;
                    richTextBox1.Visible = true;
                    richTextBox1.Text = $"Không thể hiển thị loại file này ({ext}).";
                }
            }
            catch (Exception ex)
            {
                pictureBox1.Visible = false;
                richTextBox1.Visible = true;
                richTextBox1.Text = $"Lỗi khi đọc file:\n{ex.Message}";
            }
        }
    }
}
