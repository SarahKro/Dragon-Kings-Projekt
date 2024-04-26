using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("write 1,2,3 or 4 and get your answer");

            int userChoice = Convert.ToInt32(Console.ReadLine());
            string response;
            response = userChoice switch
            {
                1 => "Raiding the port town get ye 50 gold doubloons.",
                2 => "Raiding the port town get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizon ahead.",
                4 => "'Tis but a baby Kraken, but still eats toy boats.",
                _ => "Apologies. I do not know that one."
            };
            Console.WriteLine(response);
            Console.ReadKey();



        }
    }
}
