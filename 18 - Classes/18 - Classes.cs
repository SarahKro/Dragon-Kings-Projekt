using System.Xml.Linq;

namespace _18___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score best = new Score();
            //Score best = new();

            //Score score = new Score("R4-D40", 17420, 17);
            //Score score = new("R4-D40", 17420, 17);

            best.name = "R1-D10";
            best.points = 12420;
            best.level = 15;

            Score a = new Score();
            a.name = "R2-D20";
            a.points = 12253;
            a.level = 10;

            Score b = new Score();
            b.name = "R3-D30";
            b.points = 14505;
            b.level = 14;
            if (best.EarnedStar())
            {
                Console.WriteLine($"{best.name} earned a star!");
            }




        }
    }
    class Score
    {
        public string name; //fields
        public int points;  //fields
        public int level;  //fields
        public Score()
        {
            name = "Unknown";
            points = 0;
            level = 1;
        }

        //public Score(string _name, int _points, int _level)
        //{
        //    _name = name;
        //    _points = points;
        //    _level = level;

        //}

        //public string name = "Unknown";
        //public int points;
        //public int level = 1;
        //public Score()
        //{
        //    name = "Mystery";
        //}


        public bool EarnedStar() => (points / level) > 1000;  //instance

    }

}
