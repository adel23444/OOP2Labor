using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(textBox2.Text);
            double H = Convert.ToDouble(textBox4.Text);
            double S = Math.PI * R * (R + Math.Sqrt(Math.Pow(R, 2) + Math.Pow(H, 2)));
            if (button1.Enabled == true) MessageBox.Show(S.ToString(),"Вывод:");
        }
    }
}
