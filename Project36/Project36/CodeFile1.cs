using System;
namespace Third
{
    class Massiv
    {
        double[] mass;
        int n;
        public double[] Mass
        {
            get { return mass; }
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public Massiv(int n)
        {
            this.n = n;
            mass = new double[n];
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < mass.Length; i++)
                mass[i] = r.NextDouble() * 100 - 50;
        }
        public void SrArifm()
        {
            double sr = 0;
            for (int i = 0; i < mass.Length; i++)
                sr += mass[i];
            sr /= n;
            Console.WriteLine("Среднее арифметическое {0}", sr);
        }
    }
}