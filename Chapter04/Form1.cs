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

namespace Chapter04
{
    public partial class Parent : Form
    {
        Child child;
        int nChild = 0;

        public Parent()
        {
            InitializeComponent();
        }

        private void newFIle_Click(object sender, EventArgs e)
        {
            child = new Child();
            child.MdiParent = this;
            child.Text = "NONAME" + nChild++;
            child.Show();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream str = openFileDialog1.OpenFile();
                StreamReader strReader = new StreamReader(str);
                
                child = new Child();
                child.MdiParent = this;
                child.Text = "NONAME" + nChild++;
                child.Show();

                child.GetTextBox().Text = strReader.ReadToEnd();
                strReader.Close();
                str.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                child = (Child)ActiveMdiChild;
                string fName = saveFileDialog1.FileName;

                StreamWriter writer = new StreamWriter(fName);
                writer.Write(child.GetTextBox().Text);
                writer.Close();
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                child = (Child)ActiveMdiChild;
                string fName = saveFileDialog1.FileName;

                StreamWriter writer = new StreamWriter(fName);
                writer.Write(child.GetTextBox().Text);
                writer.Close();
                child.Text = fName;
            }
        }
    }
}
