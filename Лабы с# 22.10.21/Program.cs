using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_номер_6
{
    class Program
    {
        static void PrintOne(int[] OneD)//печать одномерного массива
        {


            for (int i = 0; i < OneD.Length; i++)
            {
                Console.WriteLine(OneD[i]);
            }
            if (OneD.Length == 0)
            {
                Console.WriteLine("Вашего одномерного массива нет!");
            }

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
            int[] OneD = new int[0];
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
                Console.WriteLine("Ваш одномерный массив");
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
                Console.WriteLine("3) Сортировка четных элементов массива");
                Console.WriteLine("4) Назад");

                do
                {

                    ok = byte.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while ((!ok) || (Op > 4) || (Op <= 0));
                if (Op == 1)
                {
                    Oned = CreateOne();
                    Console.WriteLine("Ваш Одномерный массив:");
                    PrintOne(Oned);
                }
                if (Op == 2)
                {
                    Console.WriteLine("Ваш Одномерный массив:");
                    PrintOne(Oned);
                }
                if (Op == 3)
                {
                    Oned = Sor(Oned);
                    Console.WriteLine("Ваш Одномерный массив:");
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
        static int[] Sor(int[] OneD)
        {
            int[] Helper1 = new int[OneD.Length];
            
            int k = 0;
            for (int i = 0; i < OneD.Length; i++)
            {
                if (Math.Abs(OneD[i]) % 2 == 0)
                {
                    
                    k++;
                }

            }
            if (k == 0)
            {
                Console.WriteLine("Четных элементов в массиве не обнаружено");
            }
            int[] Helper2 = new int[k];
            k = 0;
            for (int i=0;i< OneD.Length; i++)
            {
                if (Math.Abs(OneD[i])%2==0)
                {
                    Helper2[k]= OneD[i];
                    k++;
                }

            }
           
            Array.Sort(Helper2);
            Array.Reverse(Helper2);

           
            k = 0;
            for (int i = 0; i < OneD.Length; i++)
            {

                if (Math.Abs(OneD[i]) % 2 == 0)
                {
                    Helper1[i] = Helper2[k];
                    k++;
                }
                else
                {
                    Helper1[i] = OneD[i];
                }

            }
            return Helper1;

        }
        /*static string CreateString()//со
        {

            //Console.WriteLine("Работа с одномерными массивами");
            

            byte a;
            bool ok;
            byte Op;
            string str=Console.ReadLine();
            int[] OneD = new int[0];
           
           

          
          
                do
                {
                    Console.Write("Введите вашу строку (max 255) ");
                    ok = string.TryParse(Console.ReadLine(), out str);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while (!ok);
                Console.WriteLine("Ваша строка");
                OneD = CreateOneD(a);

                //PrintOne(OneD);
               
           
            return str;
        }*/
        static void WorkePropos()
        {

            bool ok;
            byte Op;
            string[] masstr = new string[255];
            int k;
            char let;
            int t;
            int Hi;
            string st="";
            string str="";
            string strH = "";
            string gr="";
            do
            {
                Console.WriteLine("______________________");
                Console.WriteLine("Работа со строками");
                Console.WriteLine("1) Создать строку");
                Console.WriteLine("2) Печать строки");
                Console.WriteLine("3) Перевернуть каждое нечетное предложение");
                Console.WriteLine("4) Назад");

                do
                {

                    ok = byte.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while ((!ok) || (Op > 4) || (Op <= 0));
                if (Op == 1)
                {
                    while ((str.Length == 0)||
                        (str[str.Length-1]!=(char)33)&& (str[str.Length-1] != (char)63)&&(str[str.Length-1] != (char)46)||
                        (str[0] == (char)33)|| (str[0] == (char)63) || (str[0] == (char)46)
                        )
                    {
                        Console.WriteLine("Строка?");
                        str = Console.ReadLine();
                        if (str.Length == 0)
                        {
                            Console.WriteLine("Текст пуст. Повторите попытку");
                        }
                        else
                        {
                            if ((str[str.Length-1] != (char)33) && (str[str.Length-1] != (char)63) && (str[str.Length-1] != (char)46))
                            {
                                Console.WriteLine("Текст должен заканчиваться точкой, восклицательным или вопросительным знаком");
                            }
                            if ((str[0] == (char)33) || (str[0] == (char)63) || (str[0] == (char)46))
                            {
                                Console.WriteLine("Текст не может начинаться точкой, восклицательным или вопросительным знаком");
                            }
                        }
                       
                    }
                    str = str + " ";
                    Console.WriteLine($"Строка: {str}");

                }
                if (Op == 2)
                {
                    if (str.Length == 0)
                    {
                        Console.WriteLine("Ваша строка пуста");
                    }
                    else Console.WriteLine($"Строка: {str}");


                }
                if (Op == 3)
                {
                    
                        k = 0;
                        t = 0;

                        strH = "";
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (((str[i] == (char)46) ||
                                (str[i] == (char)63) ||
                                (str[i] == (char)33)) &&
                                (str[i + 1] != (char)46) &&
                                    (str[i + 1] != (char)63) &&
                                    (str[i + 1] != (char)33))

                            {
                                t++;
                            }

                        }

                        for (int i = 0; i < t; i++)
                        {

                            while ((str[k] != (char)46) && (str[k] != (char)33) && (str[k] != (char)63) && (k != str.Length))
                            {

                                let = str[k];
                                masstr[i] = masstr[i] + let;
                                k++;
                            }
                            while ((str[k] == (char)46) || (str[k] == (char)33) || (str[k] == (char)63))
                            {
                                while (str[k] == (char)46)
                                {
                                    gr = gr + ".";
                                    k++;
                                }
                                while (str[k] == (char)33)
                                {
                                    gr = gr + "!";
                                    k++;
                                }
                                while (str[k] == (char)63)
                                {
                                    gr = gr + "?";
                                    k++;
                                }
                            }

                            if (i % 2 == 0)
                            {

                                for (int j = masstr[i].Length - 1; j > -1; j--)
                                {
                                    st += masstr[i][j];
                                }
                                masstr[i] = st;
                                st = "";

                            }
                            for (int j = 0; j < masstr[i].Length; j++)
                            {
                                strH = strH + masstr[i][j];
                            }


                            strH = strH + gr;

                            masstr[i] = "";
                            gr = "";
                        }
                        str = strH;
                        Console.WriteLine($"Результат: {str}");


                    
                }
                if (Op == 4)
                {

                }

            } while (Op != 4);




        }
    
        static void Main(string[] args)
        {
            bool ok;
            int Op = 0;

            while (Op != 4)
            {
                do
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("1. Работа с одномерным массивом  типа int");
                    Console.WriteLine("2. Работа со строками");
                    
                    Console.WriteLine("3. Выход");

                    Console.Write("Введите номер выполняемой операции:  ");

                    ok = int.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                } while ((!ok) || (Op > 3) || (Op <= 0));

                switch (Op)
                {
                    case 1:
                        WorkOneD();
                        break;
                    case 2:
                        WorkePropos();
                        break;
                    
                    case 3:
                        break;

                }
            }
        }
    }
}

