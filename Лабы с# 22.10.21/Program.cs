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
            else
            {
                Console.WriteLine("Сортировка четных элементов прошла успешно");
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
      static string Input_Str()
        {
            string str="";
            while ((str.Length == 0) ||
                        (str[str.Length - 1] != (char)33) && (str[str.Length - 1] != (char)63) && (str[str.Length - 1] != (char)46) ||
                        (str[0] == (char)33) || (str[0] == (char)63) || (str[0] == (char)46)
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
                    if ((str[str.Length - 1] != (char)33) && (str[str.Length - 1] != (char)63) && (str[str.Length - 1] != (char)46))
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
            return str;

        }
        static void Output_str(string str)
        {
            if (str.Length == 0)
            {
                Console.WriteLine("Ваша строка пуста");
            }
            else Console.WriteLine($"Строка: {str}");
        }
        static string Revers_str(string str)
        {
            int NumbOfSymbol;
            char let;
            int NumbOfSentence;
            string[] MasStr = new string[255];
            string ReversSentence = "";
            string strHelp;
            string Border = "";
            NumbOfSymbol = 0;
            NumbOfSentence = 0;
            strHelp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (((str[i] == (char)46) ||
                    (str[i] == (char)63) ||
                    (str[i] == (char)33)) &&
                    (str[i + 1] != (char)46) &&
                        (str[i + 1] != (char)63) &&
                        (str[i + 1] != (char)33))
                {
                    NumbOfSentence++;
                }
            }
            for (int i = 0; i < NumbOfSentence; i++)
            {
                while ((str[NumbOfSymbol] != (char)46) && (str[NumbOfSymbol] != (char)33) && (str[NumbOfSymbol] != (char)63) && (NumbOfSymbol != str.Length))
                {
                    let = str[NumbOfSymbol];
                    MasStr[i] = MasStr[i] + let;
                    NumbOfSymbol++;
                }
                while ((str[NumbOfSymbol] == (char)46) || (str[NumbOfSymbol] == (char)33) || (str[NumbOfSymbol] == (char)63))
                {
                    while (str[NumbOfSymbol] == (char)46)
                    {
                        Border = Border + ".";
                        NumbOfSymbol++;
                    }
                    while (str[NumbOfSymbol] == (char)33)
                    {
                        Border = Border + "!";
                        NumbOfSymbol++;
                    }
                    while (str[NumbOfSymbol] == (char)63)
                    {
                        Border = Border + "?";
                        NumbOfSymbol++;
                    }
                }
                if (i % 2 == 0)
                {
                    for (int j = MasStr[i].Length - 1; j > -1; j--)
                    {
                        ReversSentence += MasStr[i][j];
                    }
                  
                    MasStr[i] = ReversSentence;
                    ReversSentence = "";
                }
                for (int j = 0; j < MasStr[i].Length; j++)
                {
                    strHelp = strHelp + MasStr[i][j];
                }
                strHelp = strHelp + Border;
                MasStr[i] = "";
                Border = "";
            }
            str = strHelp;
            Output_str(str);                    
            str = str + " ";
            return str;

        }
        static void WorkePropos()
        {  
            bool ok;
            byte Op;           
            string str="";            
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

                switch (Op)
                {
                    case 1:
                        str = Input_Str();
                        Output_str(str);
                        break;
                    case 2:
                        Output_str(str);
                        break;
                    case 3:
                        str = Revers_str(str);
                        break;
                    case 4:
                        break;
                }
            } while (Op != 4);
        }
    
        static void Main(string[] args)
        {
            bool ok;
            int Op = 0;
            while (Op != 3)
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

