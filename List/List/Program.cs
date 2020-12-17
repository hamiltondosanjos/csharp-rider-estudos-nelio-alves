using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> list = new List<string>();
           List<string> list2 = new List<string> {"Maria", "Vanessa", "Joao"};
           
           list.Add(item:"Hamilton");
           list.Add("Vic");
           list.Add("Alex");
           list.Add("Gabriele");
           list.Add("Leiticia");
           list.Add("Carolzinha");
           list.Add("Monica");
           list.Add("Alvaro");
           list.Insert(5, "Marcos");

           foreach (string obj in list)
           {
               Console.WriteLine(obj);
           }

           Console.WriteLine("List count: "+ list.Count);
            //Expressão Lambida
           string s1 = list.Find(x => x[0] == 'A');
           Console.WriteLine("First 'A': " + s1);

           string s2 = list.FindLast(x => x[0] == 'A');
           Console.WriteLine("Last 'A': " + s2);

           int pos1 = list.FindIndex(x => x[0] == 'A');
           Console.WriteLine("First position 'A': " + pos1);

           int pos2 = list.FindLastIndex(x => x[0] == 'A');
           Console.WriteLine("Last position 'A': " + pos2);

           List<string> result = list.FindAll(x => x.Length == 6);
           
           Console.WriteLine("_________________________");
           foreach (string obj2 in result)
           {
               Console.WriteLine(obj2);
           }

           list.Remove("Hamilton");
           Console.WriteLine("___________________________");
           foreach (string obj in list)
           {
               Console.WriteLine(obj);
           }
           list.RemoveAt(0);
           Console.WriteLine("___________________________");
           foreach (string obj in list)
           {
               Console.WriteLine(obj);
           }
           Console.WriteLine("___________________________");
           list.RemoveAll(x => x[0] == 'A');
           foreach (string obj in list)
           {
               Console.WriteLine(obj);
           }
           Console.WriteLine("___________________________");
           list.RemoveRange(2, 2);
           list.RemoveAll(x => x[0] == 'A');
           foreach (string obj in list)
           {
               Console.WriteLine(obj);
           }

        }
    }
}