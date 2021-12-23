using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class RandomFactory
    {
        static Random rnd = new Random();
        static public string GetRandomString()
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int length = 15;
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += alpha[rnd.Next(26)];
            }
            return result;
        }
        static public Person GetRandom(int type)
        {
            if (type == -1) { type = rnd.Next(4); }
            if (type == 0)
            {
                Student result = new Student();
                result.Name = GetRandomString();
                result.Age = rnd.Next(0, 100);
                
                result.Gender_m = rnd.Next(0, 100)%2==0;
                result.Exp = rnd.Next(0, 7);
                return result;
            }
            else if (type == 1)
            {
                Person result = new Person();
                result.Name = GetRandomString();
                result.Age = rnd.Next(0, 100);
                result.Gender_m = rnd.Next(0, 100) % 2 == 0;
                return result;
            }
            else if (type == 2)
            {
                Teacher result = new Teacher();
                result.Name = GetRandomString();
                result.Age = rnd.Next(0, 100);
                result.Gender_m = rnd.Next(0, 1) % 2 == 0;
                result.Exp = rnd.Next(0, 7);
                result.Numb = rnd.Next(0, 100);
                result.Groups = rnd.Next(0, 15);
                return result;
            }
            else
            {
               
                Employee result = new Employee();
                result.Name = GetRandomString();
                result.Age = rnd.Next(0, 100);

                result.Gender_m = rnd.Next(0, 100) % 2 == 0;
                result.Exp = rnd.Next(0, 7);
                result.Numb = rnd.Next(0, 100);
                return result;
            }
        }
    }
}