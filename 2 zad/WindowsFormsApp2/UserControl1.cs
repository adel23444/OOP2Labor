using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var test = new Times();
            test.Second = Convert.ToInt32(textBox1.Text);
            test.Minute = Convert.ToInt32(textBox2.Text);
            test.Hour = Convert.ToInt32(textBox3.Text);
            if (button1.Enabled == true) MessageBox.Show($"Введенное время в секундах: {test.SecondDay}", "Время в секундах");
        }
    }
}