using System;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    class TimesFromSecond
    {
        int hour, minute, second, secondDay;
        public int SecondDay
        {
            get { return SecondDay; }
            set
            {
                if(value>=0&&value<=86400)
                {
                    secondDay = value;
                    hour = secondDay/ 3600;
                    minute = (secondDay - hour * 3600) / 60;
                    second = (secondDay - hour * 3600) % 60;
                }
                else MessageBox.Show("Вводите от 0 до 86400", "Сообщение о секундах в одном дне");
            }
        }
        public int Hour { get { return hour; } }
        public int Minute { get { return minute; } }
        public int Second { get { return second; } }
    }
}