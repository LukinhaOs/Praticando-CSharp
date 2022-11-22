using System;
using System.Collections.Generic;

namespace HashSet_e_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            /* HashSet (simples)
    
            HashSet<string> set = new HashSet<string>();

            set.Add("Setar");
            set.Add("Windows 11");
            set.Add("Notebook");

            Console.WriteLine(set.Contains("Windows 11"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            } 
            
             */

            SortedSet<int> a = new SortedSet<int>() { 0, 5, 6, 9, 12 };
            SortedSet<int> b = new SortedSet<int>() { 6, 8, 2, 3, 15 };

            // União
            SortedSet<int> uniao = new SortedSet<int>(a);
            uniao.UnionWith(b);

            PrintCollectionSorted(uniao);
            

            // Interseção
            SortedSet<int> inter = new SortedSet<int>(a);
            inter.IntersectWith(b);

            PrintCollectionSorted(inter);


            // Diferença
            SortedSet<int> difer = new SortedSet<int>(a);
            difer.ExceptWith(b);

            PrintCollectionSorted(difer);

        }

        static void PrintCollectionSorted<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
