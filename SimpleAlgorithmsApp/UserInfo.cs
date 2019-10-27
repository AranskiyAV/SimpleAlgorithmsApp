using System;
using System.Collections.Generic;

namespace SimpleAlgorithmsApp
{
    public class UserInfo
    {
     // Метод, реализующий словарь
        public static Dictionary<int, string> MyDic(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Console.WriteLine("Введите имя сотрудника: \n");
            string s;
            for (int j = 0; j < i; j++)
            {
                Console.Write("Name{0} --> ", j);
                s = Console.ReadLine();
                dic.Add(j, s);
                Console.Clear();
            }
            return dic;
        }
    }
}
