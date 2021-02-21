using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jesture
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (listBox1.FindStringExact(folderBrowserDialog1.SelectedPath) == ListBox.NoMatches)
                {
                    listBox1.Items.Add(folderBrowserDialog1.SelectedPath);
                }
                else
                {
                    MessageBox.Show("Directory already added", "Add Failure",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public ListBox getDirectories()
        {
                return listBox1;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            this.Hide();
        }
    }
}
