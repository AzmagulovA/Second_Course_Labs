using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
           
            double y;
            double SN;
            double SE;
            double helperSE;
            int fact;
            double e = 0.0001;
            for (int i = 1; i <= 10; i++)
            {
                SN = 1;
                SE = 1;
                x1 =0.1+ i * 0.09;
                y = Math.Pow(3, x1);
                y = Math.Round(y, 6);
                fact = 1;
                for(int j = 1; j <= 10; j++)
                {
                    fact = fact * j;
                    SN = SN + (Math.Pow(Math.Log(3) * x1, j) / fact);
                    
                }
                SN = Math.Round(SN, 6);
                fact = 1;
                int el = 1;

                do
                {
                    helperSE = SE;
                   
                    fact = fact * el;
                    el++;
                    SE = SE + (Math.Pow(Math.Log(3) * x1, el) / fact);
                    
                } while (Math.Abs(SE - helperSE) > e);
                SE = Math.Round(SE, 6);
                Console.WriteLine($"{i}) X={x1}  SN={SN}  SE={SE}   Y={y}" );
            }
            Console.ReadKey();
            


        }
    }
}
