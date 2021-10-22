using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace физика_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, R, t, I,g,Pi;
            g= 9.806;
            Pi= 3.1415926535;
            
            int k;
            Console.WriteLine("Количество проводимых операций: ");
            k = Convert.ToInt32(Console.ReadLine());
            //double[] mas = new double[k];
            double srI = 0;
            double srt = 0;
            double srm = 0;
            for (int i = 1; i <= k; i++)
            {

                Console.WriteLine($"m{i}?");
                m = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"R{i}?");
                R = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"t{i}?");
                t = Convert.ToDouble(Console.ReadLine());
                srt = srt + t;
                srm = srm + m;
                I =m*Math.Pow(R,2)*(g*Math.Pow(t,2)-4*Pi*R)/4*Pi*R;
                srI = srI + I;
                Console.WriteLine($"I{i}={I} ");
            }
            Console.WriteLine($"Среднее m={srm / k}");
            Console.WriteLine($"Среднее t={srt / k}");
            Console.WriteLine($"Среднее I={srI/k}");
           
           
            Console.ReadKey();
        }
        
    }
}
