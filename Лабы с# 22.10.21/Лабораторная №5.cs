using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная__5
{
    class Program
    {
        static int[,] CreateTwo()//Создание двумерного массива
        {
            Console.WriteLine("____________________________");
            Console.WriteLine("1) Создать массив вручную");
            Console.WriteLine("2) Создать массив с помощью ДСЧ");
            Console.WriteLine("3) Назад");
            
            byte strings;
            byte colums;
            bool ok;
            byte Op;
            int[,] TwoD = new int[0,0];
            do
            {

                ok = byte.TryParse(Console.ReadLine(), out Op);
                if (!ok) Console.WriteLine("Error! Try again.");
            } while ((!ok) || (Op > 3) || (Op <= 0));


            if (Op == 1)
            {
                do
                {
                    Console.Write("Введите количество строк двумерного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out strings);
                    if ((!ok) || (strings == 0)) Console.WriteLine("Error! Введите натуральное число, которое меньше 255");
                } while ((!ok)||(strings==0));
                do
                {
                    Console.Write("Введите количество столбцов двумерного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out colums);
                    if ((!ok) || (colums == 0)) Console.WriteLine("Error! Введите натуральное число, которое меньше 255");
                } while ((!ok) || (colums == 0));
                TwoD = CreatedTwoD(strings, colums);

                //PrintOne(OneD);

            }
            if (Op == 2)
            {

                do
                {
                    Console.Write("Введите количество строк двумерного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out strings);
                    if (!ok) Console.WriteLine("Error! Введите натуральное число, которое меньше 255");
                } while (!ok) ;
                do
                {
                    Console.Write("Введите количество столбцов двумерного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out colums);
                    if (!ok) Console.WriteLine("Error! Введите натуральное число, которое меньше 255");
                } while (!ok);
                TwoD = CreatedTwoDR(strings,colums);

                //PrintOne(OneD);
            }
            if (Op == 3)
            {
                TwoD = CreatedTwoDR(0,0);

            }
            return TwoD;
        }
        static int[,] CreatedTwoD(int n,int m)
        {
            bool ok;
            Console.WriteLine("Вводите элементы  двумерного массива (max 255) ");
            int znach;
            int[,] TwoD = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    do
                    {              
                        ok = int.TryParse(Console.ReadLine(), out znach);
                        if (!ok) Console.WriteLine("Error! Не верно введено число");
                    } while (!ok);
                    TwoD[i,j] = znach;

                }

            }
            Console.WriteLine("Двумерный массив создан");
            return TwoD;

        }//создание двумерного массива на основе ручного ввода
        static int[,] CreatedTwoDR(int n, int m)//создание двумерного массива на основе случайных цифр
        {
           
            Console.WriteLine("Вводите элементы  двумерного массива (max 255) ");
            Random znach=new Random();
            int[,] TwoD = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    TwoD[i, j] = znach.Next(0,255);

                }

            }
            Console.WriteLine("Двумерный массив создан");
            return TwoD;

        }

        static int[,] PlusStr(int[,] TwoD)//Добавление новой строки в двумерный массив
        {
            bool ok;
            byte num;
            byte k=0;
            if (TwoD.GetUpperBound(0) + 1 == 0)
            {
                Console.WriteLine("Вашего двумерного массива нет. Для Добавления новой строки в двумерный массив следует создать его");
                return TwoD;
            }
            else
            {
                int[,] Helper = new int[TwoD.GetUpperBound(0) + 2, TwoD.Length / (TwoD.GetUpperBound(0) + 1)];
                do
                {
                    Console.WriteLine($"Введите номер строки, после которого будет стоять ваша строка");
                    ok = byte.TryParse(Console.ReadLine(), out num);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                    if (num > TwoD.GetUpperBound(0) + 1)
                    {
                        Console.WriteLine("Error! Введите число не превышающее размер массива");
                        ok = false;
                    }

                } while (!ok);


                byte chis;
                int cikl = TwoD.GetUpperBound(0) + 2;

                if (cikl != num + 1)
                {

                    for (int i = 0; i < cikl; i++)
                    {
                        if (i == num)
                        {
                            Console.WriteLine($"Введите новую строку ({TwoD.Length / (TwoD.GetUpperBound(0) + 1)})");
                            for (int z = 0; z < TwoD.Length / (TwoD.GetUpperBound(0) + 1); z++)
                            {
                                do
                                {

                                    ok = byte.TryParse(Console.ReadLine(), out chis);
                                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                                } while (!ok);
                                Helper[i, z] = chis;
                            }
                            i++;
                        }


                        for (int j = 0; j < TwoD.Length / (TwoD.GetUpperBound(0) + 1); j++)
                        {
                            Helper[i, j] = TwoD[k, j];
                        }
                        k++;
                    }

                }
                else
                {
                    cikl--;

                    for (int i = 0; i < cikl; i++)
                    {



                        for (int j = 0; j < TwoD.Length / (TwoD.GetUpperBound(0) + 1); j++)
                        {
                            Helper[i, j] = TwoD[i, j];
                        }

                    }



                    Console.WriteLine($"Введите новую строку ({TwoD.Length / (TwoD.GetUpperBound(0) + 1)})");
                    for (int z = 0; z < TwoD.Length / (TwoD.GetUpperBound(0) + 1); z++)
                    {
                        do
                        {

                            ok = byte.TryParse(Console.ReadLine(), out chis);
                            if (!ok) Console.WriteLine("Error! Неверно введено число");
                        } while (!ok);
                        Helper[TwoD.GetUpperBound(0) + 1, z] = chis;
                    }


                }

                return Helper;
            }
        }
        static int[] CreateOne()//создание одномерного массива 
        {

            //Console.WriteLine("Работа с одномерными массивами");
            Console.WriteLine("____________________________________");
            Console.WriteLine("1) Создать массив вручную");
            Console.WriteLine("2) Создать массив с помощью ДСЧ");
            Console.WriteLine("3) Назад");
           
            byte a;
            bool ok;
            byte Op;
            int[] OneD=new int[0];
            do
            {

                ok = byte.TryParse(Console.ReadLine(), out Op);
                if (!ok) Console.WriteLine("Error! Неверно введено число");
            } while ((!ok) || (Op > 3) || (Op <= 0));


            if (Op == 1)
            {
                do
                {
                    Console.Write("Введите размер одномерного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out a);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while (!ok);
                if (a != 0)
                {
                    Console.WriteLine("Вводите элементы одномерного массива");
                }
                OneD = CreateOneD(a);
               
                //PrintOne(OneD);

            }
            if (Op == 2)
            {

                do
                {
                    Console.Write("Введите размер одномерного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out a);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while (!ok);
                Console.WriteLine("Error! Неверно введено число");
                OneD = CreateOneDR(a);
               
                //PrintOne(OneD);
            }
            if (Op == 3)
            {
                 OneD = CreateOneDR(0);
                
            }
            return OneD;
        }
        static int[] Del(int[] OneD)//удаление первого четного элемента
        {
            int[] Helper = new int[OneD.Length];
            bool ok=true;
            int j = 0;
            for (int i = 0  ; i < OneD.Length; i++)
            {
                if ((Math.Abs(OneD[i]) % 2 == 0)&&(ok==true))
                {
                    i++;
                    ok = false;
                }
                if (i < OneD.Length)
                {
                    Helper[j] = OneD[i];
                }
                j++;
               
            }
            if (ok == false)
            {
                int[] Helper2 = new int[OneD.Length-1];
                for (int i = 0; i < Helper2.Length; i++)
                {
                    Helper2[i] = Helper [i];
                }
                Console.WriteLine("Первый четный элемент удален. Результат:");
                return Helper2;
                
            }
            Console.WriteLine("Четного элемента нет. Результат:");
            return Helper;
        }
        static void WorkOneD()//Работа с одномерными массивами
        {
            bool ok;
            byte Op;
            int[] Oned = new int[0];
            do
            {
                Console.WriteLine("____________________________________");
                Console.WriteLine("Работа с одномерными массивами");
                Console.WriteLine("1) Создать массив");
                Console.WriteLine("2) Печать массива");
                Console.WriteLine("3) Удаление первого четного элемента");
                Console.WriteLine("4) Назад");
               
                do
                {

                    ok = byte.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while ((!ok) || (Op > 4) || (Op <= 0));
                if (Op == 1)
                {
                   Oned= CreateOne();
                    
                    PrintOne(Oned);
                }
                if (Op == 2)
                {
                    
                    PrintOne(Oned);
                }
                if (Op == 3)
                {
                    Oned=Del(Oned);
                   
                    PrintOne(Oned);
                }
                if (Op == 4)
                {
                    
                }
                
            } while (Op != 4);




        }
        static int[] CreateOneDR(int a)//Создание одномерного массива методом ДСЧ
        {
            Random rnd;
            int[] OneD = new int[a];
            rnd = new Random();
            for (int i = 0; i < a; i++)
            {              
                OneD[i] = rnd.Next(0, 255);
            }

            return OneD;
        }
        static int[] CreateOneD(int a)//Создание одномерного массива методом ручного ввода 
        {
            int[] OneD = new int[a];
            bool ok;
            int fig;
            for (int i = 0; i < a; i++)
            {
               
                do
                {
                    
                    ok = int.TryParse(Console.ReadLine(), out fig);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while (!ok);

                OneD[i] = fig;
            }
            return OneD;
        }
        static void PrintOne(int[] OneD)//печать одномерного массива
        {

            if (OneD.Length != 0) Console.WriteLine("Ваш Одномерный массив:");
            for (int i = 0; i < OneD.Length; i++)
            {
                Console.WriteLine(OneD[i]);
            }
            if (OneD.Length == 0)
            {
                Console.WriteLine("Вашего одномерного массива нет!");
            }

        }
        static void WorkedTwoD()//Работа с двумерными массивами
        {
            bool ok;
            byte Op;
            int[,] Twod = new int[0,0];
            do
            {
                Console.WriteLine("______________________________");
                Console.WriteLine("Работа с двумерными массивами");
                Console.WriteLine("1) Создать массив");
                Console.WriteLine("2) Печать массива");
                Console.WriteLine("3) Добавление новой строки");
                Console.WriteLine("4) Назад");
                do
                {

                    ok = byte.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while ((!ok) || (Op > 4) || (Op <= 0));
                if (Op == 1)
                {
                    Twod = CreateTwo();
                    PrintTwo(Twod);
                }
                if (Op == 2)
                {
                   
                    PrintTwo(Twod);
                }
                if (Op == 3)
                {
                    Twod = PlusStr(Twod);
                    if (Twod.Length != 0)
                    {
                        
                        PrintTwo(Twod);
                    }
                }
                if (Op == 4)
                {

                }

            } while (Op != 4);
        }
        static void PrintTwo(int[,] TwoD)//Печать двумерного массива
        {
            if (TwoD.Length != 0) Console.WriteLine("Ваш Двумерный массив:");

            for (int i = 0; i < TwoD.GetUpperBound(0)+1; i++)
            {
                for(int j=0;j<TwoD.Length/ (TwoD.GetUpperBound(0)+1) ; j++)
                {
                    Console.Write($" {TwoD[i,j]}");
                }
                Console.WriteLine();
                
            }
            if (TwoD.Length == 0)
            {
                Console.WriteLine("Вашего Двумерного массива нет!");
            }

        }
        static void WorkedTornD()//работа со рванными массивами
        {

            bool ok;
            byte Op;
            int[][] Tornd = new int[0][];
            do
            {
                Console.WriteLine("____________________________");
                Console.WriteLine("Работа с рваными массивами");
                Console.WriteLine("1) Создать массив");
                Console.WriteLine("2) Печать массива");
                Console.WriteLine("3) Удаление самой длинной строки");
                Console.WriteLine("4) Назад");
               
                do
                {

                    ok = byte.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while ((!ok) || (Op > 4) || (Op <= 0));
                if (Op == 1)
                {
                    Tornd = CreatedTorn();
                    
                    PrintTord(Tornd);
                }
                if (Op == 2)
                {
                   
                    PrintTord(Tornd);
                }
                if (Op == 3)
                {
                    Tornd=DeleteMax(Tornd);
                    if (Tornd.Length != 0)
                    {
                        PrintTord(Tornd);
                    }
                        
                }
                if (Op == 4)
                {

                }

            } while (Op != 4);

        }
        static void PrintTord(int[][] TornD)//печать рванного массива
        {
            if (TornD.Length != 0) Console.WriteLine("Ваш Рванный массив:");
            for (int i = 0; i < TornD.Length; i++)
            {
                for(int j = 0; j < TornD[i].Length; j++)
                {
                    Console.Write($"{TornD[i][j]} ");
                }
                Console.WriteLine("");
            }
            if (TornD.Length == 0)
            {
                Console.WriteLine("Вашего массива нет!");
            }
        }
        static int [][] CreatedTorn()//создание рванного массива
        {
            Console.WriteLine("____________________________");
            Console.WriteLine("1) Создать массив вручную");
            Console.WriteLine("2) Создать массив с помощью ДСЧ");
            Console.WriteLine("3) Назад");
           
            byte a;
            bool ok;
            byte Op;
            int[][] TornD = new int[0][];
            do
            {

                ok = byte.TryParse(Console.ReadLine(), out Op);
                if (!ok) Console.WriteLine("Error! Неверно ведено число.");
            } while ((!ok) || (Op > 3) || (Op <= 0));


            if (Op == 1)
            {
                do
                {
                    Console.Write("Введите количество строк рванного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out a);
                    if (!ok) Console.WriteLine("Error! Неверно ведено число.");
                } while (!ok);
                TornD = CreateTornD(a);

                //PrintOne(OneD);

            }
            if (Op == 2)
            {
                do
                {
                    Console.Write("Введите количество строк рванного массива (max 255) ");
                    ok = byte.TryParse(Console.ReadLine(), out a);
                    if (!ok) Console.WriteLine("Error! Неверно ведено число.");
                } while (!ok);
                TornD = CreateTornDR(a);

            }
            if (Op == 3)
            {
                TornD = CreateTornD(0);

            }
            
            return TornD;

        }
        static int[][] CreateTornD(int a)//создание рванного массива методом ручного ввода
        {
            int[][] TornD = new int[a][];
            bool ok;
            byte columns;
            int chis;
            for (int i = 0; i < a; i++)
            {
                
               
                do
                {
                    Console.WriteLine($"Введите количество столбцов строки №{i+1}");
                    ok = byte.TryParse(Console.ReadLine(), out columns);
                    if ((!ok)||(columns==0)) Console.WriteLine("Error! Неверно введено число.");
                } while ((!ok)||(columns==0));
                TornD[i] = new int[columns];
                Console.WriteLine($"Введите элементы {i + 1} строки");
                for (int j = 0; j < columns; j++) {
                   
                    do
                    {
                       
                        ok =int .TryParse(Console.ReadLine(), out chis);
                        if (!ok) Console.WriteLine("Error! Неверно введено число");
                    } while (!ok);

                    TornD[i][j] = chis;
                }
            }
            return TornD;

        }
        static int[][] CreateTornDR(int a)//создание рванного массива методом чвк
        {
            int[][] TornD = new int[a][];
            bool ok;
            byte columns;
            Random chis=new Random();
            for (int i = 0; i < a; i++)
            {


                do
                {
                    Console.WriteLine($"Введите количество столбцов строки №{i + 1}");
                    ok = byte.TryParse(Console.ReadLine(), out columns);
                    if ((!ok)|| (columns == 0)) Console.WriteLine("Error! Неверно введено число");
                } while ((!ok) || (columns == 0));
                TornD[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    

                    TornD[i][j] = chis.Next(0, 255);
                }
            }
            return TornD;

        }
        static int[][] DeleteMax(int[][] TornD)
        {
            
            if (TornD.Length == 0)
            {
                Console.WriteLine("Вашего массива нет!");
                return TornD;
            }
            else
            {
                int[][] Helper = new int[TornD.Length - 1][];
                int max = -1;
                int maxL = -1;

                int k = 0;
               
                for (int i = 0; i < TornD.Length; i++)
                {
                    if (TornD[i].Length > maxL)
                    {
                        maxL = TornD[i].Length;
                        max = i;
                        
                    }
                }
               
                for (int i = 0; i < TornD.Length - 1; i++)
                {
                    if (k == max)
                    {
                        k++;
                    }
                        Helper[i] = new int[TornD[k].Length];
                        for (int j = 0; j < TornD[k].Length; j++)
                        {
                            Helper[i][j] = TornD[k][j];
                        }
                    k++;
                    

                    

                }
                Console.WriteLine("Удаление самой длинной строки прошло успешно");
                return Helper;
            }


         

        }
        static void Main(string[] args)
        {
            bool ok;
            int Op=0;

            while (Op != 4)
            {
               
                do
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("1. Работа с одномерными массивами");
                    Console.WriteLine("2. Работа с двумерными массивами");
                    Console.WriteLine("3. Работа с рваными массивами");
                    Console.WriteLine("4. Выход");
                  
                    Console.Write("Введите номер выполняемой операции:  ");
                   
                    ok = int.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while ((!ok) || (Op > 4) || (Op <= 0));
                
                switch (Op)
                {
                    case 1:
                        WorkOneD();
                        break;
                    case 2:
                        WorkedTwoD();
                        break;
                    case 3:
                        WorkedTornD();
                        break;
                    case 4:
                        break;

                }
            }
               
                Console.ReadKey();
           




        }
       
    }
}
