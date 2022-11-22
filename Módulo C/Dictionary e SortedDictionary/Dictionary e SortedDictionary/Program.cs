using System;
using System.Collections.Generic;

namespace Dictionary_e_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Lucas";
            cookies["email"] = "lukilu25@gmail.com";
            cookies["phone"] = "9855758921";

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["email"]);

            // cookies.Remove("");

            if (cookies.ContainsKey("user"))
            {
                Console.WriteLine($"Seja Muito Bem-vindo(a) {cookies["user"]}!");
            }
            else
            {
                Console.WriteLine("Seja muito Bem-vindo(a)!");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("----- Relatório de Dados -----");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + " | " + item.Value);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
