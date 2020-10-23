using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svår_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt saldo");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv räntan i procentenheter utan tecknet");
            double ränta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv ditt slutmål");
            double slutmål = Convert.ToDouble(Console.ReadLine());
            double years = 0;
            ränta = ränta / 100;
            for (double i = saldo; i < slutmål; i = saldo)
            {
                double förändring = saldo * ränta;
                saldo = saldo + förändring;
                years++;
                Console.WriteLine("Efter " + years + " år kommer du ha " + saldo);
                
            }
            Console.WriteLine("Det kommer ta " + years + " år innan du har nått ditt slutmål");
            Console.ReadLine();

        }
    }
}
