using System;

namespace Practic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ha";
            a = Lib1.StrPow(a, 4);
            Console.WriteLine("Задание 1: " + a);

            string b = "asd";
            b = Lib1.Rev(b);
            Console.WriteLine("\nЗадание 2: " + b);

            string c = "asddddddas";
            c = Lib1.Remove(c, "da");
            Console.WriteLine("\nЗадание 3: " + c);

            string d = "asdf";
            int leng = Lib1.Leng(d);
            Console.WriteLine("\nЗадание 4: " + leng);
        }
    }

    public static class Lib1
    {
        public static string StrPow(string a, int b)
        {
            string aCopy = "";
            for (int i = 0; i < b; i++)
            {
                aCopy += a;
            }
            return aCopy;
        }

        public static string Rev(string a)
        {
            string newStr = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                newStr += a[i];
            }
            return newStr;
        }

        public static string Remove(string str, string removeLetters)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!str[i].ToString().Equals(removeLetters))
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }

        public static int Leng(string a)
        {
            int leng = 0;
            for (int i = 0; i < a.Length; i++)
            {
                leng++;
            }
            return leng;
        }
    }
}
