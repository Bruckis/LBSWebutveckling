using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Svår_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            int tal = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= tal; i++) // Denna kommer generera alla rader
            {
                int starsperrow = i; // Hur många stjärnor det kommer vara per rad
                for (int p = 0; p < tal - (i * 2 -1); p++)
                {
                    Console.Write(" ");
                }
                for (int n = 0; n < starsperrow; n++) // Skriver ut stjärnorna på varje rad
                {
                    if (n == starsperrow - 1) // För att få en ny rad när vi har skrivit ut tillräckligt med stjärnor
                    {
                        Console.WriteLine("* ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
