namespace HuntingTheManticore
{
    internal class HuntingTheManticore
    {
        static void Main(string[] args)
        {
            //int[] array = new int[]
            //{ 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int currentSmallest = int.MaxValue;
            //for (int index = 0; index < array.Length; index++)
            //{
            //    if (array[index] < currentSmallest)
            //    {
            //        currentSmallest = array[index];

            //        Console.WriteLine(currentSmallest);
            //        Console.ReadLine();
            //    }
            //}

            //int total = 0;
            //for (int index = 0; (index < array.Length); index++)
            //{
            //    total += array[index];
            //}

            //float average = (float)total / array.Length;
            //Console.WriteLine(average);
            //Console.ReadLine();
            /*
            Console.Title = "The Replicator of D’To";
            Console.ForegroundColor = ConsoleColor.Yellow;

            int[] array = new int[5];

            for (int index = 0; index <= 4; index++)
            {
                Console.WriteLine("give me a number");
                array[index] = Convert.ToInt32(Console.ReadLine());

            }
            int[] array2 = new int[5];
            for(int index = 0;index <= 4; index++)
            {
                array2[index] = array[index] * 10 +1;
                Console.WriteLine($"array you have given { array[index],14}");
                Console.WriteLine($"array i copied {array2[index],20}");
            }
            for (int index = 0; index <= 4; index++)
            {
            }
            Console.ReadLine();
            */
            /*
            int[] scores = new int[10];
            for(int index = 0; index < scores.Length; index++)
            {
                int score = scores[index];
                Console.WriteLine(score);
            }
            Console.ReadLine();
                        */
            /*
            int[] scores = new int[10];

            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.ReadLine();
            */
            /*
            Console.Title = "The Laws of Freach";
            Console.ForegroundColor = ConsoleColor.Cyan;
            int[] Biseyler = [ 1, 4, 6, 8, 10, 11, 17, 23, 24];
            int currentMinimum = int.MaxValue;
            float total = 0;
            for  (int index =0; index < Biseyler.Length; index++)
            {
                if (Biseyler[index] < currentMinimum)
                {
                    currentMinimum = Biseyler[index];
                    
                }
                total += Biseyler[index];
            }
                Console.WriteLine("current minimum is "+currentMinimum);
                float avarage = total / Biseyler.Length;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"current avarage is {avarage}");
                Console.ReadLine();
           */
            /*
            void CountToTen()
            {
                for (int current = 0; current <= 10; current++)
                {
                    Console.WriteLine(current);
                }
            }
            string text = Console.ReadLine();

            void CountToTwenty()
            {
                for (int current = 0; current <= 20; current++)
                {
                    Console.WriteLine(current);
                }
            }
            
            void DisplayText()
            { Console.WriteLine(text); }
            */
            /*
            void Count(int numberToCountTo)
            {
                for (int current = 1; current <= numberToCountTo; current++)
                    Console.WriteLine(current);
            }
            Count(1);
            */
            /*
            void CountBetween(int start, int end)
            {
                for (int current = start; current <= end; current++)
                {
                    Console.WriteLine(current);
                }
            }
            CountBetween(10, 15);
            */
            /*
            void NotPrimeCatcher(int startingPoint, int endingPoint)
            {
                for(int number = startingPoint; number < endingPoint; number++) 
                {
                    for (int i = 2; i <= number; i++)
                    {
                        
                        if (i != number && number % i == 0)
                        {
                            Console.WriteLine($"{number} not a prime number");
                            break;
                        }
                    }
                }
            }

            
            int ReadNumber()
            { 
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);                
                return number; 
            }
            */
            /*
            int firstNumber = ReadNumber();
            int secondNumber = ReadNumber();
            
            NotPrimeCatcher(firstNumber, secondNumber);
            */
            /*
            string GetUserName()
            {
                while (true) 
                {
                    Console.Write("What is your name?\n");
                    string name = Console.ReadLine();
                    if (name != "")
                        return name;
                    Console.WriteLine("Let's try that again");

                }
            }

            GetUserName();
            */

            /*
            int DoubleAndAddOne(int value)
            {
                return value * 2 + 1;
            }
            // int DoubleAndAddOne(int value) =>value * 2 + 1;
            /// <summary>
            /// Counts to the given number, starting at 1 and including the number provided.
            /// <summary>
            void Count(int numberToCountTo)
            {
                for (int index = 1; index <= numberToCountTo; index++)
                    Console.WriteLine();
            }
            */
            /*
            long AskForNumber(string text)
            {
                while(true)
                {
                    Console.WriteLine(text);
                    long givenNumber = Convert.ToInt64(Console.ReadLine());

                    if (givenNumber > int.MinValue && givenNumber < int.MaxValue)
                    {
                        return givenNumber;
                    }
                }
            }
            AskForNumber("How old are you ?");
            */
            /*
            int AskForNumberInRange(string text, int min, int max) 
            {
                
                while (true)
                {
                    Console.Write(text+"\n");
                    int givenNumber = Convert.ToInt32(Console.ReadLine());
                    if (givenNumber < max && givenNumber > min)
                        return givenNumber;
                    Console.WriteLine("i dont believe you");
                }
            }

            AskForNumberInRange("how old are you ", 5, 85);
            */

            /*
            Console.Title = "BUYING INVENTORY";

            Console.WriteLine($"The following items are available:\n1 – Rope\n2 – Torches\n3 – Climbing Equipmen\n4 – Clean Water\n5 – Machete\n6 – Canoe\n7 – Food Supplies");
            Console.WriteLine("Please enter a number from the item-menu");

            float userSelection = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("And what is your name ?");

            float wert;

            string buyersName = Console.ReadLine();

            string discount = "samet";
            float price = 1;



            string item;
            item = userSelection switch
            {
                1 => "Rope costs ",
                2 => "Torch costs ",
                3 => "Climbing Equipment costs ",
                4 => "Clean Water costs ",
                5 => "Machete costs ",
                6 => "Canoe costs ",
                7 => "Food Supplies ",
                _ => "Sorry, i dont have that option.."
            };
            wert = userSelection switch
            {
                1 => 7,
                2 => 16,
                3 => 24,
                4 => 2,
                5 => 20,
                6 => 200,
                7 => 2,

            };
            if (buyersName == discount)
            {
                wert = wert / 2;
            }
            Console.WriteLine(item + wert + " gold");
            Console.WriteLine("And how many do you need?");
            float wishedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(wishedNumber + " " + item + " " + (wert * wishedNumber) + " gold");
            */

            /*
            int Factorial(int number)
            {
                if (number == 1) return 1;
                return number * Factorial(number - 1);
            }
            int CountDown(int number)
            {
                if (number == 0) return 0 ;
                Console.WriteLine(number);
                return CountDown(number - 1);
                
            }
            CountDown(10);
            */
            /*
            Console.WriteLine("whats your G number?\n");
            double gNumber = Convert.ToDouble(Console.ReadLine());
            int gNumberTwo = (int)gNumber;
            Console.WriteLine($"Your G number is {gNumberTwo} !");
            */

            //long AskForNumber(string text)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(text);
            //        long givenNumber = Convert.ToInt64(Console.ReadLine());

            //        if (givenNumber > int.MinValue && givenNumber < int.MaxValue)
            //        {
            //            return givenNumber;
            //        }
            //    }
            //}
            //AskForNumber("How old are you ?");


            // Hesap Makinesi 
            /*
            Console.Title = "Hesap Makinesi";
            while (true)
            {

                Console.Write("Give me your first Number: ");
                decimal userGivenNumber_1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Give me your second Number: ");
                decimal userGivenNumber_2 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Choose from the given  operations \"+, -, /, *\": ");
                char userGivenOperation = Convert.ToChar(Console.ReadLine());
                if (userGivenOperation != '/' && userGivenOperation != '*' && userGivenOperation != '+' && userGivenOperation != '-')
                {
                    Console.WriteLine("You have given invalid Operation. Please try again ");
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("You have chosen the number " + userGivenNumber_1 + ", " + userGivenNumber_2 + " and the Operation \"" + userGivenOperation + "\".");
                Console.Write("Do you whish to continue?(Yes/No): ");
                string userGivenAnswer = (Console.ReadLine()).ToLower();
                
                if (userGivenAnswer == "yes")
                {
                    if (userGivenOperation == '/')
                        Console.WriteLine(userGivenNumber_1 / userGivenNumber_2);
                    else if (userGivenOperation == '*')
                        Console.WriteLine(userGivenNumber_1 * userGivenNumber_2);
                    else if (userGivenOperation == '+')
                        Console.WriteLine(userGivenNumber_1 + userGivenNumber_2);
                    else if (userGivenOperation == '-')
                        Console.WriteLine(userGivenNumber_1 - userGivenNumber_2);
                }
                else
                {
                    Console.WriteLine("Program Restarting.");
                    Console.ReadLine();
                    Console.Clear ();
                    continue;
                }



            }
            */
            /*
            int ReadNumber()
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                return number;
            }


            static void CountToWhatEver(int givenNumber, int whatEver)
            {
                for (int current = givenNumber; current <= whatEver; current++)
                Console.WriteLine(current);
            }


            Console.Write("Enter the starting Number: ");
            int userGivenNumber_One = ReadNumber();
            Console.Write("Enter the end Number: ");
            int userGivenNumber_Two = ReadNumber();

            CountToWhatEver(userGivenNumber_One, userGivenNumber_Two);
            Console.ReadLine();
            
            string GetUserName()
            {
                while (true)
                {
                    Console.WriteLine("What is your name? ");
                    string name = Console.ReadLine();
                    if (name != "")
                        return name;
                    Console.WriteLine("Try again");

                }
            }

            */
            /*
            //Taking a Number
            Console.Title = "Taking a Number";
            int AskForNumber(string text)
            {
                Console.WriteLine(text);
                int result = Convert.ToInt32(Console.ReadLine());
                return result;
            }

            Console.WriteLine(AskForNumber("how many legs does Loki have? "));
            Console.ReadLine();
            //// Wie kann ich das ergebnis von askfornumber allein verwenden?
            Console.Clear();

            Console.WriteLine(AskForNumberInRange("how many legs does Loki has", 1, 4));
            Console.ReadLine();
            */
            /*
            int meinMax = 100;

            for(int i = 0; i < 10; i++) 
            {
                
                int antwort = AskForNumberInRange("eh wurscht", i, meinMax);
                meinMax -= 10;
            }

            //// Wie kann ich das ergebnis von askfornumber allein verwenden?


            string ergebnis = ZamHängen("Haus", "Tier");

            string ergebnisZwei = ZamHängen2("Thor", "Loki");


            string ZamHängen2(string v1, string v2)
            {
                return v1 + v2;
            }

            */

            //Console.Write("Pilot, enter a number between 0 and 100: ");
            //int pilotsNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.Write("Defender, guess the pilot's number to atack his Airship: ");

            //while (true)
            //{
            //    int defendersGuess = Convert.ToInt32(Console.ReadLine());
            //        if (defendersGuess > pilotsNumber)
            //    {
            //        Console.Write("Too far Defender! try again!: ");
            //    }
            //        else if (defendersGuess < pilotsNumber)
            //    {
            //        Console.Write("Not far enough! try again!: ");
            //    }
            //        else
            //    {
            //        Console.WriteLine("Well done Defender! You shot down the Pilot and defended your city!");
            //        break;
            //    }

            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        Console.WriteLine($"{i}: Electric and Fire");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine($"{i}: Electric");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"{i}: Fire");
            //    }

            //    else 
            //    { 
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine($"{i}: Normal"); 
            //    }


            //}

            Console.Title = "Hunting the Manticore";
            int manticoreFullHealth = 10;
            int cityFullHealth = 15;
            int cityCurrentHealth = 15;
            int roundNumber = 1;
            int damageNormalHit = 1;
            int damageElementHit = 3;
            int damageDoubleElementHit = 10;
            int manticoreCurrentHealth = 10;
            int distanceOfManticore;
            int guessOfTheDefender;
            int damage;

            Console.Write("Pilot, enter how far you want to position the Manticore(between 0-100): ");

            while (true)
            {
                distanceOfManticore = Convert.ToInt32(Console.ReadLine());
                if (distanceOfManticore < 0 || distanceOfManticore > 100)
                {
                    Console.Clear();
                    Console.Write("Pilot! Enter a number between 0 and 100!: ");
                }
                else { break; }
            }

            Console.Clear();
            Console.WriteLine($"Now it's your turn Defender!" +
                $" Guess the distance between the City and the Manticore so we can bring him down!" +
                $" Citys future depends on your decisions! Believe in yourself!(between 0-100)\n");

            for (roundNumber = 1; roundNumber <= cityFullHealth; roundNumber++)
            {
                    Console.WriteLine(
                    $"STATUS: Round: {roundNumber}    " +
                    $"City: {cityCurrentHealth}/{cityFullHealth}  " +
                    $"Manticore: {manticoreCurrentHealth}/{manticoreFullHealth}");

                if ((roundNumber % 3 == 0 && roundNumber % 5 == 0))
                {
                    damage = damageDoubleElementHit;
                }
                else if ((roundNumber % 3 == 0 || roundNumber % 5 == 0))
                {
                    damage = damageElementHit;
                }
                else { damage = damageNormalHit; }

                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
                Console.Write($"Desired cannon range: ");
                guessOfTheDefender = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (guessOfTheDefender < 0 || guessOfTheDefender > 100)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Defender! We have no room for mistakes right now! Guess it between 0-100!: \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    roundNumber--;
                }
                else
                {
                    if (guessOfTheDefender < distanceOfManticore)
                    {
                        Console.WriteLine("That FELL SHORT!");
                    }
                    else if (guessOfTheDefender > distanceOfManticore)
                    {
                        Console.WriteLine("That OVERSHOT the Manticore!");
                    }
                    else if (guessOfTheDefender == distanceOfManticore)
                    {
                        Console.Write($"desired cannon range: {guessOfTheDefender}\n");
                        Console.WriteLine("That was a DIRECT HIT!");
                        manticoreCurrentHealth = manticoreCurrentHealth - damage;
                    }
                }
                cityCurrentHealth--;

                if (manticoreCurrentHealth <= 0 && cityCurrentHealth > 0)
                {
                    Console.WriteLine("You did it! You defended the City! You are a hero and your name will be remembered for ever!!");
                    break;
                }
                else if (cityCurrentHealth == 0 && manticoreCurrentHealth > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You failed! City has fallen because of YOU!" +
                        $" its time to share the same fate as the every other fallen civillian in the City.." +
                        $" Bäm!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if (cityCurrentHealth == 0 && manticoreCurrentHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"What was the point of this war" +
                    $" so many have been fallen.. for what?");
                    break;
                }
            }

            Console.ReadLine();










        }
    }
}
