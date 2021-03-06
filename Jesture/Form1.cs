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
using System.Threading;

namespace Jesture
{
    public partial class Form1 : Form

    {
        private string folderName;
        private ListBox directoryListBox;

        //folder window
        private Form2 f2 = null;

        //time session input window
        private Form3 f3 = null;

        private string[] pictures = null;
        private Random rand = new Random();
        private int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (f2 == null) {
                f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                f2.Show();
            }

            directoryListBox = f2.getDirectories();
            for(int i = 0; i < directoryListBox.Items.Count; i++)
            {
                Console.WriteLine("test: " + directoryListBox.Items[i].ToString());
            }

            if(directoryListBox.Items.Count != 0)
            {
                pictures = Directory.GetFiles(directoryListBox.Items[0].ToString(), "*.jpg", SearchOption.AllDirectories);
                string result = string.Join("", pictures);
                Console.WriteLine(result);

            }
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(pictures != null)
            {
                timeLeft = 120;
                pictureBox1.Load(pictures[rand.Next(0, pictures.Length)]);
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Please select an image folder to start", "No Directory",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                circularProgressBar1.Value = timeLeft;
                circularProgressBar1.Update();
            }
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                f3.Show();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
