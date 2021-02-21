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
    public partial class Form1 : Form

    {
        private string folderName;
        private ListBox directoryListBox;
        public Form1()
        {
            InitializeComponent();
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            directoryListBox = f2.getDirectories();
            for(int i = 0; i < directoryListBox.Items.Count; i++)
            {
                Console.WriteLine("test: " + directoryListBox.Items[i].ToString());
            }
        }
    }
}
