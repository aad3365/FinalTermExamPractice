using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] DriveList;
            TreeNode root;

            DriveList = Environment.GetLogicalDrives();

            foreach (string drv in DriveList)
            {
                root = trvDir.Nodes.Add(drv);
                root.ImageIndex = 2;

                if (trvDir.SelectedNode == null)
                {
                    trvDir.SelectedNode = root;
                }

                root.SelectedImageIndex = root.ImageIndex;
                root.Nodes.Add("");
            }
        }

        public void setPlus(TreeNode node)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;

            try
            {
                path = node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();
                if (di.Length > 0)
                {
                    node.Nodes.Add("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OpenFiles()
        {
            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;

            foreach(ListViewItem item in siList)
            {
                OpenItem(item);
            }
        }

        public void OpenItem(ListViewItem item)
        {
            TreeNode node;
            TreeNode child;

            if (item.Tag.ToString() == "D")
            {
                node = trvDir.SelectedNode;
                node.Expand();

                child = node.FirstNode;

                while (child != null)
                {
                    if (child.Text == item.Text)
                    {
                        trvDir.SelectedNode = child;
                        trvDir.Focus();
                        break;
                    }
                    child = child.NextNode;
                }
            }
            else
            {
                Process.Start(txtPath.Text + "\\" + item.Text);
            }
        }

        private void trvDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;
            TreeNode node;

            try
            {
                e.Node.Nodes.Clear();
                path = e.Node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();

                foreach (DirectoryInfo dirs in di)
                {
                    node = e.Node.Nodes.Add(dirs.Name);
                    setPlus(node);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trvDir_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DirectoryInfo di;
            DirectoryInfo[] diarray;
            ListViewItem item;
            FileInfo[] fiArray;

            try
            {
                di = new DirectoryInfo(e.Node.FullPath);
                txtPath.Text = e.Node.FullPath.Substring(0, 2) + e.Node.FullPath.Substring(3);
                lvwFiles.Items.Clear();

                diarray = di.GetDirectories();
                foreach (DirectoryInfo tdis in diarray)
                {
                    item = lvwFiles.Items.Add(tdis.Name);
                    item.SubItems.Add("");
                    item.SubItems.Add(tdis.LastWriteTime.ToString());
                    item.ImageIndex = 0;
                    item.Tag = "D";
                }

                fiArray = di.GetFiles();
                foreach (FileInfo fis in fiArray)
                {
                    item = lvwFiles.Items.Add(fis.Name);
                    item.SubItems.Add(fis.Length.ToString());
                    item.SubItems.Add(fis.LastWriteTime.ToString());
                    item.ImageIndex = 1;
                    item.Tag = "F";
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvwFiles_DoubleClick(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }
    }
}
