using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAlgorithmsApp
{
    class SortedDictionary
    {
        // Метод, реализующий словарь
        public static SortedDictionary<string, string> MyDic(int i)
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            string s, s1;
            for (int j = 0; j < i; j++)
            {
                Console.Write("\nВведите ключ: ");
                s1 = Console.ReadLine();
                Console.WriteLine("Введите имя сотрудника");
                Console.Write("Name{0} --> ", j);
                s = Console.ReadLine();
                dic.Add(s1, s);
            }
            return dic;
        }
    }
}
