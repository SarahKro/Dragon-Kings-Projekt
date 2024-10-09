using System.ComponentModel.Design;

namespace _16___Enumerations_Wiederholung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"As you can see, there is a {ChestState.Locked} chest on the table.What do you want to do?");
            while (true)
            {
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == ChestState.Open.ToString().ToLower())
                {
                    if (saveState == ChestState.Locked)
                    {
                        Console.WriteLine($"The chest is {saveState}.You can't do that! Do something else.");
                    }

                    else if (saveState == ChestState.Open)
                    {
                        Console.WriteLine($"The chest is already {saveState}.What do you want to do?");
                    }

                    else
                    {
                        Console.WriteLine($"The chest is {ChestState.Open}.What do you want to do?");
                        saveState = ChestState.Open;
                    }
                }

                else if (userAnswer == ChestState.Close.ToString().ToLower())
                {
                    if (saveState == ChestState.Locked || saveState == ChestState.Unlocked)
                    {
                        Console.WriteLine($"The chest is {saveState}.You can't do that! Do something else.");
                    }

                    else if (saveState == ChestState.Closed)
                    {
                        Console.WriteLine($"The chest is already {saveState}.What do you want to do?");
                    }

                    else
                    {
                        Console.WriteLine($"The chest is {ChestState.Closed}.What do you want to do?");
                        saveState = ChestState.Closed;
                    }
                }

                else if (userAnswer == ChestState.Lock.ToString().ToLower())
                {
                    if (saveState == ChestState.Open)
                    {
                        Console.WriteLine($"The chest is {saveState}.You can't do that! Do something else.");
                    }

                    else if (saveState == ChestState.Locked)
                    {
                        Console.WriteLine($"The chest is already {saveState}.What do you want to do?");
                    }

                    else
                    {
                        Console.WriteLine($"The chest is {ChestState.Locked}.What do you want to do?");
                        saveState = ChestState.Locked;

                    }
                }

                else if (userAnswer == ChestState.Unlock.ToString().ToLower())
                {
                    if(saveState == ChestState.Open)
                    {
                        Console.WriteLine($"The chest is {saveState}.You can't do that! Do something else.");
                    }

                    else if (saveState == ChestState.Unlocked || saveState == ChestState.Closed)
                    {
                        Console.WriteLine($"The chest is already {saveState}.What do you want to do?");
                    }

                    else
                    {
                        Console.WriteLine($"The chest is {ChestState.Unlocked}.What do you want to do?");
                        saveState = ChestState.Unlocked;
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid answer! You can only type {ChestState.Open}, {ChestState.Close}, {ChestState.Lock} or {ChestState.Unlock}.");
                }

            }
        }
        
        static ChestState saveState = ChestState.Locked;

        enum ChestState { Open, Close, Unlock, Lock, Closed, Locked, Unlocked }
    }
}
