using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Times
    {
        int hour, minute, second, secondDay;
        public int Second
        {
            get { return second; }
            set {if (value >= 0 && value <= 60){ second = value; secondDay += second; }
                else MessageBox.Show("Вводите от 0 до 59", "Сообщение о секундах");}
        }
        public int Hour
        {
            get { return hour; }
            set { if (value >= 0 && value < 24) { hour = value; secondDay += hour * 3600; }
                else MessageBox.Show("Вводите от 0 до 23", "Сообщение о часах"); }
        }
        public int Minute
        {
            get { return minute; }
            set { if (value >= 0 && value <= 60) { minute = value; secondDay += minute * 60; }
                else MessageBox.Show("Вводите от 0 до 59", "Сообщение о минутах");}
        }
        public int SecondDay { get { return secondDay;} }
    }
}