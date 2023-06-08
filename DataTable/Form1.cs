using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable
{
    public partial class Form1 : Form
    {
        DataSet1 dataset;

        public Form1()
        {
            InitializeComponent();
            dataset = new DataSet1();
            dataset.Tables["Person"].Rows.Add(new Object[] { 1, "Kim", 20 });
            dataset.Tables["Person"].Rows.Add(new Object[] { 2, "Lee", 21 });
            dataset.Tables["Person"].Rows.Add(new Object[] { 3, "Chun", 22 });

            dataGridView1.DataSource = dataset.Tables["Person"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataset.Tables["Person"].Rows.Add(new object[] 
            {
                dataset.Tables["Person"].Rows.Count + 1,
                textBox1.Text,
                Convert.ToInt32(textBox2.Text),
            });
        }
    }
}
