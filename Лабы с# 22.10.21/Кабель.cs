using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кабель
{
    class Program
    {
        static void Main(string[] args)
        {
            int col;
            int res;
            double maxL=-1;
            double a;
            double StX,StY;
            double delX;
            double delY;
            int k=0;
            Console.WriteLine("Введите сторону квадрата");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество вершин");
           col=Convert.ToInt32(Console.ReadLine() );
            double[,] mas = new double[col,2];
            double[] L = new double[col];
            double [,]Helper=new double[col,2];
            for (int i = 0; i < col; i++)
            {
                Console.WriteLine($"X{i}=");
                mas[i, 1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Y{i}=");
                mas[i, 2] = Convert.ToDouble(Console.ReadLine());

            }
            StX = 0;
            StY = 0;
            for (int i = 0; i < col; i++)//Находим центр окружности
            {
                StX =StX+ mas[i, 1];

                StY = StY + mas[i, 2];
               

            }
            StX = StX / col;
            StY = StY / col;

            for (int i = 0; i < col; i++)//Присваиваем началу координат, центр окружности
            {
                mas[i, 1] = mas[i, 1] - StX;
                mas[i, 2] = mas[i, 2] - StY;

            }
            for(int i = 0; i < col; i++)
            {
                L[i] = Math.Sqrt(Math.Pow(mas[i, 1],2) + Math.Pow(mas[i, 2],2));//Находим длины всех вершин
                if (L[i] > maxL)
                {
                    maxL = L[i];
                }
               
            }
            if (maxL > a * Math.Sqrt(2) / 2)//Если длина max вершины  ,больше половины диагонали квадрата, вывести False 
            {
                res = -1;
            }
            if (maxL <= a)
            {
                res = 1;
            }
            for (int i = 0; i < col; i++)
            {
                if (L[i] == maxL)
                {
                    k = k+1;//количество вершин с максимальной длиной
                }

            }
                for (int i = 0; i < col; i++)
            {
                
                if (L[i] == maxL)
                {
                    delX = mas[i, 1] - a / 2;
                    delY = mas[i, 2] - Math.Sqrt(Math.Pow(maxL,2)-Math.Pow(a/2,2));
                    if (mas[i, 1] < 0)
                    {
                        Helper[i, 1] = mas[i, 1]+delX;
                    }
                    if (mas[i, 1] > 0)
                    {
                        Helper[i, 1] = mas[i, 1] - delX;
                    }
                    if (mas[i, 2] < 0)
                    {
                        Helper[i, 2] = mas[i, 2] + delY;
                    }
                    if (mas[i, 2] > 0)
                    {
                        Helper[i, 2] = mas[i, 2] - delY;
                    }
                    for(int j = 0; j < col; j++)
                    {
                        mas[j, 1] = mas[i, 1] - StX;
                        mas[j, 2] = mas[i, 2] - StY;
                    }

                }

            }


            Console.ReadKey();
        }
    }
}
