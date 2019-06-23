using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    class Program

    {
        static double Proverka(out double d)
        {
            bool ok = false;
            do
            {
                string t = Console.ReadLine();
                ok = double.TryParse(t, out d);
            } while (!ok);
            return d;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введеите a1");
            double a1 = Proverka(out a1);
            Console.WriteLine("Введеите a2");
            double a2 = Proverka(out a2);
            Console.WriteLine("Введеите a3");
            double a3 = Proverka(out a3);
            Console.WriteLine("Введите N");
            int n = int.Parse(Console.ReadLine());
            double[] ar = new double[n];
            ar[0] = a1;
            ar[1] = a2;
            ar[2] = a3;
            for (int i = 3;i<n;i++)
            {
                ar[i] = 0.7 * ar[i - 1] - 0.2 * ar[i - 2] + i * ar[i - 3];
            }
            for (int i =0; i<n; i++)
            {
                Console.Write(ar[i]+" ");
            }
            Console.Read();
        }
    }
}
