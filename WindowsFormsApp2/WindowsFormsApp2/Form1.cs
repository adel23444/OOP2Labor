using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        UserControl1 uc1 = new UserControl1();
        UserControl2 uc2 = new UserControl2();
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Controls.Contains(uc1))
            {
                Controls.Remove(uc2);
                Controls.Add(uc1);
                uc1.Location = new Point(250, 150);
            }
            else
                Controls.Remove(uc1);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!Controls.Contains(uc2))
            {
                Controls.Remove(uc1);
                Controls.Add(uc2);
                uc2.Location = new Point(250, 150);
            }
            else
                Controls.Remove(uc2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
