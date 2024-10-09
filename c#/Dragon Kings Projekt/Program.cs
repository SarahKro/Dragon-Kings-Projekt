// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/*
Console.Write("What are you?\n");
string userDefinition = Console.ReadLine();
Console.WriteLine("Press a key if you want to continue.. " + userDefinition);
Console.ReadKey();

Console.WriteLine("press any key when you're ready to begin");
Console.ReadKey(true);
Console.Title = "hello world";
*/
/*
Console.WriteLine("We are under atack, quick! Just give me the infos i ask for! Nothing more and nothing less!\n");
Console.WriteLine("Which Row do you think, they are going to atack?\n");
//string givenRowString = Console.ReadLine();
//int givenRowInt = Convert.ToInt32(givenRowString);
int givenRowInt = Convert.ToInt32(Console.ReadLine());
givenRowInt = Math.Clamp(givenRowInt, 1, 8);

Console.WriteLine("and which Column?");
string givenColumnString = Console.ReadLine();
int givenColumnInt = Convert.ToInt32(givenColumnString);
givenColumnInt = Math.Clamp(givenRowInt, 1, 8);


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Quick! Deploy to:\n ({givenRowInt}, {givenColumnInt + 1})");

Console.WriteLine(" (" + givenRowInt + ", " + (givenColumnInt - 1) + ")");

Console.WriteLine($" ({givenRowInt + 1}, {givenColumnInt})");

Console.WriteLine($" ({givenRowInt - 1}, {givenColumnInt})");
Console.ReadKey(true);
*/



/*
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
*/
using System.Security.Cryptography.X509Certificates;
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
    1 => 7 ,
    2 => 16 ,
    3 => 24 ,
    4 => 2 ,
    5 => 20 ,
    6 => 200 ,
    7 => 2 ,
    
};
if (buyersName == discount)
{
    wert = wert / 2;
}
Console.WriteLine( item + wert + " gold" );
Console.WriteLine("And how many do you need?");
float wishedNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(wishedNumber+" " + item+ " " + ( wert * wishedNumber) + " gold");
*/

/*
int length = Convert.ToInt32(Console.ReadLine()); //Combined into one line!
int[] ak = new int[length];

Console.Clear();
for (int index = 0; index < length; index++)
{
    ak[index] = index;
    Console.WriteLine(ak[index]);

}
Console.WriteLine(ak[5..]);
Console.ReadLine();
*/
int[] array = new int[]
{
    4, 51, -7, 13, -89, 15, -8, 45, 90
};
int currentSmallest = int.MaxValue;
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
        currentSmallest = array[index];
        Console.WriteLine(currentSmallest);
        Console.ReadLine();
}
//Console.WriteLine(currentSmallest);
//Console.WriteLine(array.Length);
//Console.ReadLine();





