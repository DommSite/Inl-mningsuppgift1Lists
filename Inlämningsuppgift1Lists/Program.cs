using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace listinlämning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "123";
            List<string> namn = new List<string>();
            while (svar != "")
            {
                Console.WriteLine("Skriv in ett namn");
                svar = Console.ReadLine();
                if (svar != "")
                {
                    namn.Add(svar);
                }
            }
            namn.Sort();
            namn.Reverse();
            foreach(string a in namn)
            {
                Console.WriteLine(a);
            }
        }
    }
}