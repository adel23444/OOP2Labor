using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var test = new TimesFromSecond();
            test.SecondDay = Convert.ToInt32(textBox4.Text);
            if (button1.Enabled == true) MessageBox.Show($"Разложенное время: {test.Hour:00}:{test.Minute:00}:{test.Second:00}");
        }
    }
}