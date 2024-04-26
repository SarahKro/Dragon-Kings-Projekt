using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Dragon_Kings_First_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string name;
              name = "Samet";

              Console.WriteLine("Hello World!");
              Console.ReadLine();

              Console.WriteLine("whats up?");
              Console.ReadLine();

              Console.WriteLine("Hmm, it's a weird situation..");
              Console.WriteLine("i dont even know where i am right now..");
              Console.WriteLine("But okay, i can show you");
              Console.WriteLine("my name is "+ name + ", im a Programmer");
              Console.WriteLine("and some day, i will be the king of the Programmers!");
              Console.ReadLine();

              string mane;
              Console.WriteLine("Bread is ready.\n");
              Console.WriteLine("Who is the Bread for");
              mane = Console.ReadLine();
              Console.WriteLine("Noted."+" here you go "+ mane+"!");
              Console.ReadLine();

              string isim = Console.ReadLine();
            */
            //Console.WriteLine("What kind of thing are we talking about?");
            // string a = Console.ReadLine(); // this variable will store the users first input

            // Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            // string b = Console.ReadLine(); /* this variable will store the users second input*/

            // string c = " of Doom"; // Thing Namer ?
            // string d = "3000";    // okay..
            // Console.WriteLine("The " + b + a /*" of "*/ + c + d + "!"); //of is unnecessary

            // Console.ReadLine();
            /*byte oneSinglebite = 222;
            string aSingleBite = "bis 255";
            short aFourByteVersion = 32222;
            ushort aPositiveshort = 65000;
            string aNameStartsWithLowerCase = "LowerCamelCase for Variables";
            string NameWithUpperCase = "UpperCamelCase for other things";
            int theColorMagenta = 0xFF0FF; //renk gösterirken 0xle basliyoruz
            char aLetter = 'S'; /* 2 bytes, Unicode(whole letters in the world) and Emojis?
            hexadecimal Unicode number for each character we are starting with \u
            Bsp: '\u0061' = a  */

            // float = 4 bytes, double = 8 bytes, decimal = 16 bytes
            // Avogadro's Number = 6.022x10^^23 oder 6.022e23
            /*
            double aPiLol = 3.1415926;
            Console.WriteLine(aPiLol);
            Console.ReadLine();
            double aGivenNumber = Console.ReadLine();
            Console.WriteLine(aPiLol + aGivenNumber);
            Console.ReadLine();
            */
            /*
            string aShieet = "Shit";
            Console.WriteLine(aShieet);
            int aNumba = -120000;
            Console.WriteLine(aNumba);
            byte aBiter = 240;
            Console.WriteLine(aBiter);
            short aShort = -10000;
            Console.WriteLine(aShort);
            uint aUint = 320000;
            Console.WriteLine(aUint);
            ushort aUshort = 12000;
            Console.WriteLine(aUshort);
            double BirDouble = 1.1256e10;
            Console.WriteLine(BirDouble);
            float BirFloat = 0.125f;
            Console.WriteLine(BirFloat);
            decimal aDecimal = 0.5758596m;
            Console.WriteLine(aDecimal);
            long aLong = -1000000005;
            Console.WriteLine(aLong);
            ulong aULoong = 2_000_000_000;
            Console.WriteLine(aULoong);
            char aKarakter = 'Y';
            Console.WriteLine(aKarakter);
            Console.ReadLine();

            aShieet = "More Shit";
            Console.WriteLine(aShieet);
            aNumba = aNumba + 1;
            Console.WriteLine(aNumba);
            aBiter = 250;
            Console.WriteLine(aBiter);
            aShort = 10000;
            Console.WriteLine(aShort);
            aUshort = 14000;
            Console.WriteLine(aUshort);
            aKarakter = 'A';
            Console.WriteLine(aKarakter);
            aULoong = 2_100_000_000;
            Console.WriteLine(aULoong);
            aDecimal = 0.88558855m;
            Console.WriteLine(aDecimal);
            Console.ReadLine();
            var message = "hola";
            Console.WriteLine(message);
            Console.ReadLine();
            var uSayi = 125;
            Console.WriteLine(uSayi);
            Console.ReadLine();
*/

            /*
            var sSarah = " katze";
            String sSs = "eine";
            Char sS = 'M';
            Convert.ToString(sS);
            Console.WriteLine("es geht " + sS+ sSs + sSarah);
            Console.ReadLine();

            /*
            string Ss = " Katze";
            string sSs = "eine";
            char sS = 'M';
            Convert.ToString(sS);
            Console.WriteLine("es geht " + sS + sSs + Ss);
            Console.ReadLine();
            */
            /*
            Console.WriteLine("Wie alt bist du?");
            string stringAlt = Console.ReadLine();
            int intAlt = Convert.ToInt16(stringAlt);

            Console.WriteLine("Du bist " + intAlt + " jahre alt!");
            Console.ReadLine();

            double side1 = 4.5;
            double side2 = 3.5;
            double height = 1.5;
            Console.WriteLine((((side1 - side2) / 2) * height) + (side2 * height));
            Console.ReadLine();
            Console.WriteLine(((side1 + side2) * height) / 2);
            Console.ReadLine();
            */

            /*
            Console.WriteLine("Enter Triangle Base Length");
            string triangleBaseLengthString = Console.ReadLine();
            int triangleBaseLenghtInt = Convert.ToInt32(triangleBaseLengthString);
            Console.WriteLine("Enter Triangle Height");
            string triangleHeightString = Console.ReadLine();
            int triangleHeightInt = Convert.ToInt32(triangleHeightString);
            int triAngleAreaInt = ((triangleBaseLenghtInt * triangleHeightInt) / 2);
            Console.WriteLine("Calculating.. bib bub bab.. Drück Enter!");
            Console.ReadLine();
            Console.WriteLine(triAngleAreaInt);
            Console.ReadLine();
            */
            /*
            int aBigNumber = int.MaxValue;
            short aBigNegativeNumber = short.MinValue;
            Console.WriteLine(aBigNumber + " ve/und/and " + aBigNegativeNumber);
            Console.ReadLine();

            double infinity = double.PositiveInfinity;
            Console.WriteLine(infinity);
            Console.ReadLine();

            double notAnyRealNumber = double.NaN;
            Console.WriteLine(notAnyRealNumber);
            Console.ReadLine();
            */
            /*
            int a = 5;
            int b = 2;
            int result = a / b;
            Console.WriteLine(result);
            Console.ReadLine();
            float af = Convert.ToSingle(a);
            float bf = Convert.ToSingle(b);
            float resultZwei = af / bf;
            Console.WriteLine(resultZwei);
            Console.ReadLine();
            */
            /*
            int leftOverApples = 23 % 3;
            
            //int remainder = 21 % 2; // if this is 0, then 'n' is an even number.
            Console.WriteLine(leftOverApples);
            Console.ReadLine();
            double leftOverApplesDv = Convert.ToDouble(leftOverApples);

            double applesToDivide = leftOverApplesDv / 3;
            Console.WriteLine(applesToDivide);
            Console.ReadLine() ;
            */
            /*
            Console.WriteLine(" How many Eggs did you collect today?");
            string numberOfTheEggs_String = Console.ReadLine();
            int numberOfTheEggs_Int = Convert.ToInt32(numberOfTheEggs_String);
            Console.WriteLine(" Okay, just give me second.." + " (Press Enter!)");
            Console.ReadLine();
            Console.WriteLine(" Okay Girls, im ready.. just press Enter button again and you can get your right amount of Chocolate Eggs!");
            Console.ReadLine();
            int numberOfTheEggsEachGirlGet = numberOfTheEggs_Int / 4;
            int numberOfTheEggsDuckbearGets = numberOfTheEggs_Int % 4;
            Console.WriteLine(numberOfTheEggsEachGirlGet);
            Console.WriteLine(" And press one more time to enter for the poor duckbear, who has to live with you; mean, greedy girls who cant even split their own eggs between sisters...");
            Console.ReadLine();
            Console.WriteLine(numberOfTheEggsDuckbearGets);
            Console.ReadLine();
            Console.WriteLine(" There you go poor duckbear, i will save you soon.. Just hang on there!");
            Console.ReadLine();
            */
            // if the number of eggs are 3, 7 or 11 duckbear gets more eggs than the each sister.
            /*int a = 5;
            Console.WriteLine(a);
            Console.ReadLine();
            a = a + 1;  // a += 1; "+=" is a compound assignment! 
            */
            // bsp: +=, -=, *=, /=, %=
            /*
            int a = 0;
            a += 5; // The equivalent of a = a + 5; (a is 5 after this line runs.)
            a -= 2; // The equivalent of a = a – 2; (a is 3 after this line runs.)
            a *= 4; // The equivalent of a = a * 4; (a is 12 after this line runs.)
            a /= 2; // The equivalent of a = a / 2; (a is 6 after this line runs.)
            a %= 2; // The equivalent of a = a % 2; (a is 0 after this line runs.)
            */
            // a++ => a += 1, a = a + 1;
            // a-- => a -= 1, a = a - 1;
            /* Challange: The Dominion of Kings
            Console.WriteLine("Hi, i hate kings and i hate even more, that they think they can 'own' Estates, Duchies and Provinces.. \nBut its irrelevant (atleast for now..)");
            Console.WriteLine("So.. you arrogant human beings, who wants to know how much they 'own'..\nGive me the number of your Estates you think you have! and press Enter!");
            string estateNumber_String = Console.ReadLine();
            int estateNumber_Int = Convert.ToInt32(estateNumber_String);
            //int estateValue_Int = estateNumber_Int * 1;
            Console.WriteLine("Now write the number of Duchies you think you 'own', you delusional creature.. ");
            string duchyNumber_String = Console.ReadLine();
            int duchyNumber_Int = Convert.ToInt32(duchyNumber_String);
            //int duchyValue_Int = duchyNumber_Int * 3;
            Console.WriteLine("And the number of Provinces?? ");
            string provinceNumber_String = Console.ReadLine();
            int provinceNumber_Int = Convert.ToInt32(provinceNumber_String);
            //int provinceValue_Int = provinceNumber_Int * 6;
            Console.WriteLine("So you 'have' " + estateNumber_Int + " estates, " + duchyNumber_Int + " duchies and " + provinceNumber_Int + " provinces.");
            Console.WriteLine("press enter to learn the point amount of your holdings.. ");
            Console.ReadLine();

            estateNumber_Int *= 1;
            duchyNumber_Int *= 3;
            provinceNumber_Int *= 6;

            int totalValue_Int = estateNumber_Int + duchyNumber_Int + provinceNumber_Int;
            Console.WriteLine("if a person could own such things, you would have " + totalValue_Int + " points..");
            Console.WriteLine("A very sad day for the Humankind..");
            Console.ReadLine();

            */
            /*
            byte aByte = 3;
            int anInt = aByte;
            */
            /*
            int anInt = 3;
            byte aByte = (byte)anInt;
            */
            /*
            double aSayi = 40;
            int bSayi = 30;
            double aSonuc = aSayi / bSayi;
            Console.WriteLine(aSonuc);
            Console.ReadLine();
            */
            /*
            float a = 10000;
            float b = 0.00001f;
            double sum =(double)a + b;
            Console.WriteLine(sum);
            Console.ReadLine();

            double x = 3;
            double powerOfTwo = Math.Pow(x, 2);
            Console.WriteLine(powerOfTwo);
            Console.ReadLine();

            double y = 9;
            double squareY = Math.Sqrt(y);
            Console.WriteLine(squareY);
            Console.ReadLine();

            int iks = Math.Abs(-25);
            Console.WriteLine(iks);
            Console.ReadLine();

            double y1 = Math.Sin(0);
            double y2 = Math.Cos(0);
            */
            /*
            int smaller = Math.Min(2, 112);
            int larger = Math.Max(2, 212);
            Console.WriteLine(smaller + " and " + larger);
            Console.ReadLine();
            */
            /*
            health += 10;
            health = Math.Clamp(health, 0, 100); // keep it in the interval 0 to 100
            Console.WriteLine(health);( FRAG ROBERT!)
            Console.ReadLine();
            */
            /*
            float x = 3;
            float xSquared = MathF.Pow(x, 2); ( FRAG ROBERT!)
            */
            /*
            Console.Title = "Dragon kKing's starter challenges";

            Console.Write("What are you?\n");
            string userDefinition= Console.ReadLine();
            Console.WriteLine("Press a key if you want to continue.. " + userDefinition);
            Console.ReadKey();

            Console.WriteLine("press any key when you're ready to begin");
            Console.ReadKey(true);
            Console.Beep(440, 200);
            Console.Beep(460, 200);
            Console.Beep(480, 200);
            Console.Beep(600, 100);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press a key if you want to continue.. " + userDefinition);
            Console.ReadKey(true);

            Console.Clear();
            Console.ReadKey(true);
            Console.Write("What are you?\n");
            Console.WriteLine("Press a key if you want to continue.. " + userDefinition);
            Console.ReadKey();

            Console.WriteLine("press any key when you're ready to begin");
            Console.ReadKey(true);
            */

            /*
            Console.Write("What are you?\n");
            string userDefinition = Console.ReadLine();
            Console.WriteLine("Press a key if you want to continue.. " + userDefinition);
            Console.ReadKey(true);
            Console.WriteLine("deneme \"bir\", \"iki\"");
            Console.ReadKey(true);
            */
            /*A quotation mark is not the only character you can escape. Here are a few other useful ones:
            \t is a tab character, \n is a new line character (move down to the following line), and \r is a
            carriage return (go back to the start of the line). In the console window, going down a line with
            \n also goes back to the beginning of the line
            */
            /*
            Console.WriteLine(@"C\s://.,");
            Console.ReadKey(true);
            */
            //Console.Write("My favorite number is " + myFavoriteNumber + ".");
            //Console.WriteLine($"My favorite number is {myFavoriteNumber}.");
            /*
            Console.WriteLine("Tell me your Name little one..");

            string nameOfMD = Console.ReadLine();
            Console.WriteLine($"nice to meet you {nameOfMD}, i can't wait to use you..");
            Console.ReadKey(true);
            Console.WriteLine($"#1: {nameOfMD,20}");
            Console.WriteLine($"#1 {nameOfMD,-20}");
            Console.WriteLine($"#2:{nameOfMD,-19} 2");
            Console.ReadKey(true);
            */
            /*
            Console.WriteLine("mit 0 method\n");

            Console.WriteLine($"{Math.PI:0.0000}");
            Console.WriteLine($"{Math.PI:0.000}");
            Console.WriteLine($"{Math.PI:00.000}");

            Console.WriteLine("mit # method\n");

            Console.WriteLine($"{Math.PI:#.####}");
            Console.WriteLine($"{Math.PI:##.###}");

            Console.WriteLine("e number\n\n");

            Console.WriteLine($"{Math.E:0.00}");
            Console.ReadKey(true);
            */
            /*
            double numberD = 4.0123456789;
            Console.WriteLine($"{numberD:00.000000}");
            Console.WriteLine($"{numberD:##.######}");
            Console.ReadKey(true);

            float NumberF = (float)numberD;
            Console.WriteLine($"{NumberF:00.000000}");
            Console.WriteLine($"{NumberF:##.######}");
            Console.ReadKey(true);
            */
            /*
            float usedHours = 6.5f;
            float gesamtHours = 12;
            Console.WriteLine($"{usedHours / gesamtHours:00.00000%}");
            Console.WriteLine($"{usedHours / gesamtHours:00.00000%}\n\n");
            Console.WriteLine($"{usedHours / gesamtHours:P}");
            Console.WriteLine($"{usedHours / gesamtHours:P1}");
            Console.WriteLine($"{usedHours / gesamtHours:F}");
            Console.WriteLine($"{usedHours / gesamtHours:F5}");
            Console.ReadKey(true);
            */
            //DEFENSE OF CONSOLAS
            /*
            Console.Title = "Defense of Consolas";
            Console.WriteLine("We are under atack, quick! Just give me the infos i ask for! Nothing more and nothing less!\n");
            Console.WriteLine("Which Row do you think, they are going to atack?\n");
            int givenRowInt = Convert.ToInt32(Console.ReadLine());
            //string givenRowString = Console.ReadLine();
            //int givenRowInt = Convert.ToInt32(givenRowString);
            Console.WriteLine("and which Column?");
            int givenColumnInt = Convert.ToInt32(Console.ReadLine());
            //string givenColumnString = Console.ReadLine();
            //int givenColumnInt = Convert.ToInt32( givenColumnString);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Quick! Deploy to:\n ({givenRowInt}, {givenColumnInt + 1})");
            
            Console.WriteLine(" (" + givenRowInt + ", " + (givenColumnInt - 1) + ")");
           
            Console.WriteLine($" ({givenRowInt + 1}, {givenColumnInt})");
           
            Console.WriteLine($" ({givenRowInt - 1}, {givenColumnInt})");
            Console.Beep(440, 200);
            Console.ReadKey(true);
            */
            /*
            Console.WriteLine("Hey there fella, Give me a number between 0-100");
            int userGivenNumberInt = Convert.ToInt32(Console.ReadLine());

            if (userGivenNumberInt == 100)
            {
                Console.WriteLine($"Congrats! You are the first user to give number {userGivenNumberInt}");
            }
                else if (userGivenNumberInt >= 90)
                {
                    Console.WriteLine("Almost there..");
                }
                else if (userGivenNumberInt >= 80)
                {
                    Console.WriteLine("Good shot, but not close enough..");          
                }
                else if (userGivenNumberInt >=70 )
                {
                    Console.WriteLine("you need some training for sure!");
                }
            else
            {
                Console.WriteLine("not even worth to consider it..");
            }
            Console.ReadKey(true);

            Console.WriteLine("before i let you, give me an other number would you ?");
            int score = Convert.ToInt32(Console.ReadLine());

            bool levelUp = score >= userGivenNumberInt;

            if (levelUp) 
            {
                Console.WriteLine("Bravo! you are some next level shit bruh!");
            }
            else 
            {
                Console.WriteLine("try until you got that level you deserve bruh!");
            }
            Console.ReadKey(true);
            */
            /*
             
            Repairing the Clocktower 
            Console.WriteLine("allright you old bustards, let the numbers run!");
            int consolasNumbers = Convert.ToInt32(Console.ReadLine());

            if (consolasNumbers == 0)
            {
                Console.WriteLine("give me a number other than 0");
                int consolasNumber = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                bool evenNumber = ((consolasNumbers % 2) == 0);

                if (evenNumber)
                {
                    Console.WriteLine("Tick");
                }
                else
                {
                    Console.WriteLine("tock");
                }
                Console.ReadKey(true);
            }

            //WARUM FUNKTIONIERT ES NICHT?

            */
            /*
            Console.WriteLine("give me a number");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            if (givenNumber != 0 && givenNumber % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else if (givenNumber != 0 && givenNumber % 2 >= 0)
            {
                Console.WriteLine("Tock");
            }
            else
            {
                Console.WriteLine("God damn it!!!! You can even give me a decent fucking number!!, what a disappointing city and their even worse Consolas!!!");
            }
            Console.ReadKey(true);
            */
            /*
            int score = Convert.ToInt32(Console.ReadLine());
            string textToDisplay = score > 70 ? "you passed!" : "you failed";
            Console.WriteLine(textToDisplay);
            Console.ReadLine();
            */

            //WATCHTOWER
            /*
            Console.WriteLine("give me a x koordinate");
            int xKoordinateGiven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now give me a Y koordinate");
            int yKoordinateGiven = Convert.ToInt32(Console.ReadLine());

            if (xKoordinateGiven == 0 && yKoordinateGiven == 0)
            {
                Console.WriteLine("The enemy is here");
            }
            else if (xKoordinateGiven > 0 && yKoordinateGiven == 0)
            {
                Console.WriteLine("the enemy is to the East");
            }
            else if (xKoordinateGiven < 0 && yKoordinateGiven == 0)
            {
                Console.WriteLine("the enemy is to the West");
            }
            else if (xKoordinateGiven < 0 && yKoordinateGiven < 0)
            {
                Console.WriteLine("the enemy is to the S.West");
            }
            else if (xKoordinateGiven > 0 && yKoordinateGiven > 0)
            {
                Console.WriteLine("the enemy is to the N.East");
            }
            else if (xKoordinateGiven == 0 && yKoordinateGiven < 0)

            {
                Console.WriteLine("the enemy is to the South");
            }
            else if (xKoordinateGiven == 0 && yKoordinateGiven > 0)

            {
                Console.WriteLine("the enemy is to the North");
            }
            else if (xKoordinateGiven < 0 && yKoordinateGiven > 0)

            {
                Console.WriteLine("the enemy is to the N.West");
            }

            else                 
            {
                Console.WriteLine("the enemy is to the S.East");
            }

            Console.ReadKey(true);
            */

            // Avast, matey! What be ye desire?
            // 1 – Rest
            //  2 – Pillage the port
            // 3 – Set sail
            // 4 – Release the Kraken
            // What be the plan, Captain ?

            //Console.WriteLine("write 1,2,3 or 4 and get your answer");

            //int userChoice = Convert.ToInt32(Console.ReadLine());
            /*
            if (userChoise == 1)
                Console.WriteLine("Ye rest and recover your health");
            else if (userChoise == 2)
                Console.WriteLine("Raiding the port town get ye 50 gold doubloons");
            else if (userChoise == 3)
                Console.WriteLine("The wind is at your back; the open horizon ahead.");
            else if (userChoise == 4)
                Console.WriteLine("Tis but a baby Kraken, but still eats toy boats");
            else
                Console.WriteLine("Apologies. I do not know that one");
            Console.ReadKey();
            */
            //or
            /*
            switch (userChoice) 
            {
                case 1:
                case 2:
                    Console.WriteLine("Raiding the port town get ye 50 gold doubloons");
                    break;
                case 3:
                    Console.WriteLine("The wind is at your back; the open horizon ahead.");
                    break;
                case 4:
                    Console.WriteLine("Tis but a baby Kraken, but still eats toy boats");
                    break;
                default:
                    Console.WriteLine("Apologies. I do not know that one");
                    break;
            }
            Console.ReadLine();
            */
            /*
            string response;
            response = userChoice switch
            {
                1 => "Ye rest and recover your health.",
                2 => "Raiding the port town get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizon ahead.",
                4 => "'Tis but a baby Kraken, but still eats toy boats.",
                _ => "Apologies. I do not know that one."
            };
            Console.WriteLine(response);
            Console.ReadKey();
            */
            /*
            int Saygilar = 0;

            while ( Saygilar <= 100 || Saygilar >= -100)
            {
                

                Console.WriteLine("what is my favourite number between 0-10?");
                Saygilar = Convert.ToInt32(Console.ReadLine());
                if (Saygilar == 4) { break; }
                else if (Saygilar < 0) 
                {
                    Console.WriteLine("its not even in the range"); 
                    continue;
                }
                else if (Saygilar > 10) 
                { 
                    Console.WriteLine("can you even count?! ");
                    continue;
                }
                Console.WriteLine("Nope, if you want to try it again press enter! (:");
                Console.ReadLine();

            }

            Console.WriteLine("How did you find out ??? :)");

            Console.ReadLine();
            
            //for (int i = 0; i < 10; i++)
              //  Console.WriteLine("evet");
            */
            /*
            int pilotNumber = 1;
            Console.WriteLine("Well hello there Pilot, give me a number between 0-100.");

            while (true)
            {
                pilotNumber = Convert.ToInt32(Console.ReadLine());
                if (pilotNumber >= 0 && pilotNumber <= 100)
                {
                    Console.Clear();
                    Console.WriteLine("Not bad, not bad at all.. Well, you can go now.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilotNumber < 0 || pilotNumber > 100)
                {
                    Console.WriteLine("Was ist des oida, kannst net lesen oder was?\n");
                    Console.WriteLine("Jetzt gib eine richtige nummer, du voll trottel!");
                    continue;
                }
            }

            int hunterNumber = 0;
            Console.WriteLine("Hello hunter, can you guess the number ?");
            for (; ; )
            {
                
                hunterNumber = Convert.ToInt32(Console.ReadLine());
                if (hunterNumber == pilotNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Daaaeeemmm, what a fucking Geniussss!!!");
                    Console.WriteLine("press any key, if you want to see my last words..");
                    Console.ReadLine();
                    break;
                }
                else if (hunterNumber < pilotNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Lift your guess higher and higheeeeerrr!");
                    continue;
                }
                else if (hunterNumber > pilotNumber)
                {
                    Console.Clear();
                    Console.WriteLine("maybe you should go down under, they say if you can go down enough, beers will flow and men chunder!");
                    continue;
                }

            }
            Console.Clear();
            Console.WriteLine("Well, that was all i was programmed for. Now i can finally be a useless binary in peace.. See ya! ");
            Console.ReadLine();
            */
            /*
            Console.Title = "The Magic Canon";
            int magicCanon;
            for ( magicCanon = 1 ;magicCanon <=100 ; magicCanon++ ) 
            {
                
                if ( magicCanon %3 == 0 && magicCanon % 5 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Combine Blast!");
                    //Console.ReadLine();
                   continue;
                }
                else if ( magicCanon %5 == 0 )
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Electric Blast!");
                    //Console.ReadLine();
                }
                else if( magicCanon %3 == 0 )
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Fire Blast!");
                   // Console.ReadLine();
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Crank!");
                    //Console.ReadLine();
                }
            
            }
            Console.ReadLine();
            */

            /*
            int[] scores = new int[10];
            scores = new int[20];
            scores[0] = 125364;
            Console.WriteLine(scores[0]);
            Console.ReadLine();

            scores = new int[20];
            Console.WriteLine(scores.Length);
            Console.ReadLine();
            */
            //int length = Convert.ToInt32(Console.ReadLine()); //Combined into one line!
            //int[] ak =new int[length];

            //Console.Clear();
            //for (int index = 0; index < length; index++)
            //{
            //    ak[index] = index;
            //    Console.WriteLine(ak[index]);

            //}
            //Console.WriteLine(ak[^1]);
            //    Console.ReadLine();









        }
    }
}

