using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace Vin_Fletcher_s_Arrows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrow UsersArrow = new Arrow();

            Console.WriteLine("Hello Customer you can create your own arrow here");
            Console.WriteLine("Here is your options for Arrow heads");
            Console.WriteLine($"" +
                $"1) {ArrowHeadType.Wood}," +
                $"2) {ArrowHeadType.Steel}," +
                $"3) {ArrowHeadType.Obsidian}");
            Console.Write("Which do you prefer?: ");
            int choiceArrowHead =Convert.ToInt16(Console.ReadLine());

            switch(choiceArrowHead)
            {
                case 1:
                    Console.WriteLine($"Okay {ArrowHeadType.Wood} it is," +
                        $" Now lets choose a length for your arrows, shall we?");
                    UsersArrow._arrowhead = ArrowHeadType.Wood;
                    break;
                case 2:
                    Console.WriteLine($"Okay {ArrowHeadType.Steel} it is," +
                        $" Now lets choose a length for your arrows, shall we?");
                    UsersArrow._arrowhead = ArrowHeadType.Steel;
                    break;
                case 3:
                    Console.WriteLine($"Okay {ArrowHeadType.Obsidian} it is," +
                        $" Now lets choose a length for your arrows, shall we?");
                    UsersArrow._arrowhead = ArrowHeadType.Obsidian;
                    break;
            }
            Console.WriteLine("Like i said before you choose your Fletching," +
                " we need to decide how long your arrows gonna be." +
                " Arrows can be between 60cm to 100cm. Longer arrows can fly farther," +
                " but shorters are faster so choose Wisely ");

            while(true)
            {
                UsersArrow._lenght = Convert.ToInt16(Console.ReadLine());
                if (UsersArrow._lenght < 60)
                {
                    Console.WriteLine("thats shorter than what i can make");
                    Console.WriteLine("choose an other lenght");
                    continue;
                }
                else if (UsersArrow._lenght > 100)
                {
                    Console.WriteLine("thats longer than what i can make");
                    Console.WriteLine("choose an other lenght");
                    continue;
                }
                else
                {
                    Console.WriteLine("Now lets start with the Fletching ");
                    break; 
                }
            }

            Console.WriteLine("Here is our options of Fletchings for your arrow");
            Console.WriteLine($"" +
                $"1) {FletchingType.Plastic}," +
                $"2) {FletchingType.TurkeyFeathers}," +
                $"3) {FletchingType.GooseFeathers}");
            Console.Write("Which do you prefer?: ");
            int choiceFletching = Convert.ToInt16(Console.ReadLine());
            switch (choiceArrowHead)
            {
                case 1:
                    Console.WriteLine($"Okay {FletchingType.Plastic} it is,");
                    UsersArrow._fletching = FletchingType.Plastic;
                    break;
                case 2:
                    Console.WriteLine($"Okay {FletchingType.TurkeyFeathers} it is,");
                    UsersArrow._fletching = FletchingType.TurkeyFeathers;
                    break;
                case 3:
                    Console.WriteLine($"Okay {FletchingType.GooseFeathers} it is,");
                    UsersArrow._fletching = FletchingType.GooseFeathers;
                    break;
            }

            Console.WriteLine($"{UsersArrow._arrowhead}, {UsersArrow._lenght}, {UsersArrow._fletching}");
            Console.ReadLine();
            //steel = 10
            //wood = 3
            //obsidian = 5
            //plastic = 10
            //turkeyFeather = 5
            //gooseFeather = 3
            //shaft 0.05 per cm

           
          
        }

    }


    class Arrow
    {
        public ArrowHeadType _arrowhead;
        public float _lenght;
        public FletchingType _fletching;

        public Arrow(ArrowHeadType arrowhead, float lenght, FletchingType fletching)
        {
            _arrowhead = arrowhead;
            _lenght = lenght;
            _fletching = fletching;
        }

        public Arrow()
        {
            _arrowhead = ArrowHeadType.Obsidian;
            _lenght = 60;
            _fletching = FletchingType.Plastic;
        }


    }
    enum ArrowHeadType { Steel, Wood, Obsidian}
    enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers}
    
}
