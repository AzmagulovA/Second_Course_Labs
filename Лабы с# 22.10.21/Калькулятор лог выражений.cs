using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_логических_выражений
{
    class Program
    {
        static void print(int[,] mas,int iter)
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < iter; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void print_ob(string[] str,int iter)
        {
            
                for (int j = 0; j < iter; j++)
                {
                    Console.WriteLine(str[j] + " ");
                }
               // Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            bool ok;
            int Op = 0;            
            int[,] mas= new int[4, 8];
            
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    mas[i, j] = 0;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        if (i > 1)
                        {
                            mas[i, j] = 1;
                        }
                        else
                        {
                            mas[i, j] = 0;
                        }
                    }
                    if (j == 1)
                    {
                        if (i % 2 == 0)
                        {
                            mas[i, j] = 0;

                        }
                        else
                        {
                            mas[i, j] = 1;
                        }
                    }
                }
            }

           

                    char[] vir= { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j' } ;
            bool[] Help = { true, true, false, false, false, false, false, false, false };
            string shap = "a b";
            string[] ob = new string[6];
            int iter = 2;
            Console.WriteLine($"{shap}");
            print(mas,iter);
            while (Op != 6)
            {

                do
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("1. Инверсия");
                    Console.WriteLine("2. Конъюнкция(логическое умножение)");
                    Console.WriteLine("3. Дизъюнкция(логическое сложение)");
                    Console.WriteLine("4. Импликация(логическое следование)");
                    Console.WriteLine("5. Эквивалентность");
                    Console.WriteLine("6. Выход");
                    Console.Write("Введите номер выполняемой операции:  ");

                    ok = int.TryParse(Console.ReadLine(), out Op);
                    if (!ok) Console.WriteLine("Error! Неверно введено число");
                    if ((Op > 6) || (Op <= 0)) Console.WriteLine("Error! Такой операции нет. Повторите попытку");
                } while ((!ok) || (Op > 6) || (Op <= 0));
                int first, second;
              
                switch (Op)
                {                   
                    case 1:

                        for (int i = 0; i < iter; i++)
                        {
                            Console.WriteLine($"{i + 1}. {vir[i]}");
                        }
                        do
                        {                     
                            Console.WriteLine("Элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out first);                            
                            
                           
                        } while (!ok );
                        first--;

                        for (int i = 0; i < 4; i++)
                        {
                            if (mas[i, first]==1)
                            {
                                mas[i, iter] = 0;
                            }
                            else
                            {
                                mas[i, iter] = 1;
                            }
                        }
                        
                        shap = shap + " "+vir[iter];
                        iter++;
                        Console.WriteLine($"{shap}");
                        print(mas,iter);
                        ob[iter-2] = vir[iter-1]+"= not "+vir[first];



                        break;
                    case 2:
                        for (int i = 0; i < iter; i++)
                        {
                            Console.WriteLine($"{i + 1}. {vir[i]}");
                        }
                        do
                        {
                            Console.WriteLine("Первый элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out first);
                            Console.WriteLine("Второй элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out second);
                          
                        } while (!ok);
                        first--;
                        second--;
                        for (int i = 0; i < 4; i++)
                        {
                            if (mas[i, first] == 1)
                            {
                                if (mas[i, second] == 1)
                                {
                                    mas[i, iter] = 1;
                                }
                                else
                                {
                                    mas[i, iter] = 0;
                                }
                            }
                            else
                            {
                                mas[i, iter] = 0;
                            }
                        }
                        shap = shap + " " + vir[iter];
                        iter++;                     
                        Console.WriteLine($"{shap}");
                        print(mas, iter);
                        ob[iter - 2] = vir[iter-1] + "= " + vir[first]+" & " + vir[second];


                        break;
                    case 3:
                        for (int i = 0; i < iter; i++)
                        {
                            Console.WriteLine($"{i + 1}. {vir[i]}");
                        }
                        do
                        {
                            Console.WriteLine("Первый элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out first);
                            Console.WriteLine("Второй элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out second);
                           
                        } while (!ok);
                        first--;
                        second--;
                        for (int i = 0; i < 4; i++)
                        {
                            if (mas[i, first] == 0)
                            {
                                if (mas[i, second] == 0)
                                {
                                    mas[i, iter] = 0;
                                }
                                else
                                {
                                    mas[i, iter] = 1;
                                }
                            }
                            else
                            {
                                mas[i, iter] = 1;
                            }
                        }
                        shap = shap + " " + vir[iter];
                        iter++;
                        Console.WriteLine($"{shap}");
                        print(mas, iter);
                        ob[iter - 2] = vir[iter-1] + "= " + vir[first] + " + " + vir[second];

                        break;
                    case 4:
                        for (int i = 0; i < iter; i++)
                        {
                            Console.WriteLine($"{i + 1}. {vir[i]}");
                        }
                        do
                        {
                            Console.WriteLine("Первый элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out first);
                            Console.WriteLine("Второй элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out second);
                           
                        } while (!ok);
                        first--;
                        second--;
                        for (int i = 0; i < 4; i++)
                        {
                            if (mas[i, first] == 1)
                            {
                                if (mas[i, second] == 0)
                                {
                                    mas[i, iter] = 0;
                                }
                                else
                                {
                                    mas[i, iter] = 1;
                                }
                            }
                            else
                            {
                                mas[i, iter] = 1;
                            }
                        }
                        shap = shap + " " + vir[iter];
                        iter++;

                        Console.WriteLine($"{shap}");
                        print(mas, iter);
                        ob[iter - 2] = vir[iter-1] + "= " + vir[first] + " -> " + vir[second];

                        break;
                    case 5:
                        for (int i = 0; i < iter; i++)
                        {
                            Console.WriteLine($"{i + 1}. {vir[i]}");
                        }
                        do
                        {
                            Console.WriteLine("Первый элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out first);
                            Console.WriteLine("Второй элемент: ");
                            ok = int.TryParse(Console.ReadLine(), out second);
                           
                        } while (!ok);
                        first--;
                        second--;
                        for (int i = 0; i < 4; i++)
                        {
                            if (mas[i, first] == mas[i, second])
                            {
                                mas[i, iter] = 1;
                            }
                            else
                            {
                                mas[i, iter] = 0;
                            }
                        }
                        shap = shap + " " + vir[iter];
                        iter++;

                        Console.WriteLine($"{shap}");
                        print(mas, iter);
                        ob[iter - 2] = vir[iter-1] + "= " + vir[first] + " = " + vir[second];
                        break;
                        

                }
                print_ob(ob, iter);

            }

            Console.ReadKey();

        }
    }
}
