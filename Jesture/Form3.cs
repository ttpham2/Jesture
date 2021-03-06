using System;
using System.Windows.Forms;

namespace Jesture
{
    public partial class Form3 : Form
    {

        //private event EventHandler 
        public Form3()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.addButtonClick += new EventHandler(timerInputAddButton_Click);
        }

        private void timerInputAddButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new CustomTimerInput.TimerInput());
        }

        private void flowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.SuspendLayout();
            foreach(Control ctrl in flowLayoutPanel1.Controls)
            {
                ctrl.Width = flowLayoutPanel1.ClientSize.Width;
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CustomTimerInput.TimerInput ctrl = new CustomTimerInput.TimerInput();
            flowLayoutPanel1.Controls.Add(ctrl);
            flowLayoutPanel1.SuspendLayout();
            ctrl.Width = flowLayoutPanel1.ClientSize.Width;
            flowLayoutPanel1.ResumeLayout();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                int idx = flowLayoutPanel1.Controls.Count - 1;
                Control ctrl = flowLayoutPanel1.Controls[idx];
                flowLayoutPanel1.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }
    }
}
