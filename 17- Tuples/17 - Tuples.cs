namespace _17__Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string, int, int) score = ("Samet", 15, 20000);
            // var score = ("Samet", 15, 200);
            Console.WriteLine($"Name:{score.Item1} Level:{score.Item2} Score:{score.Item3}");

            (string, int, int) score1 = ("Sarah", 15, 20000);
            (string, int, int) score2 = score1; // exact match works.

            //(string, int) score3 = score1; //Not the same number of items.
            //(int, int, string) score4 = score1 //Itemsin a different order.

            (string Name, int Points, int Level) score5 = ("Samet", 20000, 15); // if you dont use "var" you can give the variables names
            Console.WriteLine($"Name:{score5.Name} Level:{score5.Level} Score:{score5.Points}");

            var score6 = (Name: "Samet", Points: 20000, Level: 15);
            Console.WriteLine($"Name:{score6.Name} Level:{score6.Level} Score:{score6.Points}");

            void DisplayScore((string Name, int Points, int Level) score8) // cant use var version for this because we need parameter types
            {
                Console.WriteLine($"Name:{score8.Name} Level:{score8.Level} Points:{score8.Points}");
            }


            //names are ephemeral and not a part of the tuple
            (string One, int Two, int Three) score9 = GetScore();
            DisplayScore(score);
            (string N, int P, int L) GetScore() => ("R2-D2", 12420, 15);

            void DisplayScore2((string Name, int Points, int Level) score9)
            {
                Console.WriteLine($"Name:{score9.Name} Level:{score9.Level} Score:{score9.Points}");
            }




        }
    }
}
