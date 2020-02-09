using System;
using System.Collections.Generic;
using Numbers;

namespace Methods
{

    class Program
    {
        public void test(int ju, out int y, out string x)
        {
            y = ( 50 + ju );
            x = "Keren";

        }

        static void Main(string[] args)
        {
            /*
            Program p = new Program();
            p.test(20, out int yt, out string xt);
            Console.WriteLine("Hello, world! {0}, {1}", yt, xt);
            */

            int[] i = { 5, 8, 9, 12, 23, 6, 12, 78, 2, 442, 344, 67 };
            int l = i.Length;

            Console.WriteLine(@"Nilai terbesar : " + FindNumber.FindMax(i));

           
            FindNumber.FindMinMax(i, out int min, out int max);

            Console.WriteLine($"Nilai Terkecil : {min}");
            Console.WriteLine($"Nilai Terbesar : {max}");


            Console.WriteLine($"Nilai Terkecil : " + FindNumber.FindMin(i, l));

            int c = 10;
            FindNumber.addNumber(ref c, 20);
            Console.WriteLine($"Nilai Setelah Ditambah : {c}");

            Console.ReadKey();

        }

    }
}
