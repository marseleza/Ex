using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();

            var root = new TreeNode()
            {
                Text = "D:",
                Tag = "d:\\"
            };
            tvFiles.Nodes.Add(root);
            Build(root);

            root.Expand();
        }

        private void Build(TreeNode parent)
        {
            var path = parent.Tag as string;
            parent.Nodes.Clear();

            try
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    parent.Nodes.Add(new TreeNode(Path.GetFileName(dir), new[] { new TreeNode("...") }) {Tag  = dir });                 
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    parent.Nodes.Add(new TreeNode(Path.GetFileName(file), 1, 1) { Tag = file });
                }
            }
            catch
            {

            }
        }

        private void tvFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Build(e.Node);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Choose_CreateDirectoryButton_Click(object sender, EventArgs e)
        {

        }

        private void tST_Choose_Create_Folder_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tST_forCreateFolder_Click(object sender, EventArgs e)
        {

        }

        private void tST_Delete_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tST_CopyFile_To_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tST_Directory_Move_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tST_Rename_DoubleClick(object sender, EventArgs e)
        {

        }

        private void background_DoubleClick(object sender, EventArgs e)
        {
            Random r = new Random();
            this.splitContainer1.Panel1.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));
            this.splitContainer1.Panel2.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {

            Random r = new Random();           
            this.splitContainer1.Panel1.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));
        }

        private void splitContainer1_Panel2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.splitContainer1.Panel2.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));
        }

        private void File_Click(object sender, EventArgs e)
        {
            using (var sr = new StreamReader(@"C:\Exam\File.txt"))
            {
                var str = sr.ReadToEnd();
                textBox.Text = str.ToString();
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Font = dialog.Font;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer2_Panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonchick_Click(object sender, EventArgs e)
        {
            if (pictureBox.Visible == false)
            {
                pictureBox.Show();
            } 
            else if (pictureBox.Visible == true)
            {
                pictureBox.Visible = false;
            }
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Nomain Open = new Form_Nomain();
            Open.Show();
        }

        private void splitContainer2_Panel1_MouseHover(object sender, EventArgs e)
        {
            Random r = new Random();
            this.splitContainer2.Panel1.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Build(e.Node);
        }
    }
}
