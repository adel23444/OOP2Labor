using System;
namespace Third
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var t = new Massiv(n);
            t.N = n;
            foreach (var v in t.Mass)
                Console.WriteLine($"{v,8:0.000}");
            t.SrArifm();
            Console.ReadKey();
        }
    }
}
