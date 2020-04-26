using System;
using System.Collections.Generic;

namespace ListT
{
    class Program
    {
        static void Main(string[] args)
        {

            List<osoby> os = new List<osoby>();
            Console.Write("Ile rekordow chcesz dodac do listy?  ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Wprowadz imie.   ");
                osoby emp = new osoby();
                emp.name = Console.ReadLine();
                emp.id = i + 1;
                os.Add(emp); ;
                Console.WriteLine("Dodano rekord.");
                Console.WriteLine("Nacisnij Enter aby kontynuowac.");
                Console.ReadLine();
            }

            Console.WriteLine("Nacisnij Enter aby wyswietlic liste.");
            Console.ReadLine();

            foreach (var item in os)
            {
                Console.WriteLine("ID:  " + item.id);
                Console.WriteLine("Imie:    " + item.name);
                Console.WriteLine("-------------------------------");
            }
            Console.ReadKey();
        }
    }
}
