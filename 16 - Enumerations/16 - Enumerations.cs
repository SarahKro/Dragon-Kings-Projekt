namespace _16___Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enum Season { Winter, Spring, Summer, Autumn } // New types MUST go after other
            // code (or in another file)
            //enum Season                                               
            //{
            //    Winter,
            //    Spring,
            //    Summer,
            //    Fall  
            //}
            //Season current = Season.Winter;
            //Zimmer oda = Zimmer.Einzelzimmer;
            /*
            string antwortEins = Console.ReadLine();
            string antwortZwei = Console.ReadLine();
            string ergebnisZwei = ZamHängen2(antwortEins, antwortZwei);
            Console.WriteLine(ergebnisZwei);


            string ZamHängen2(string v1, string v2)
            {
                return v1 + v2;
            }
            */

            Console.WriteLine("there is a chest on your table, what do you want to do with it?");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine($"Choose {ChestState.Open} = 1, {ChestState.Close} = 2, {ChestState.Lock} = 3, {ChestState.Unlock} = 4, beenden = 5 ");
                string eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine(ProcessChestCommand(ChestState.Open));
                        break;
                        
                    case "2":
                        Console.WriteLine(ProcessChestCommand(ChestState.Close));
                        break;

                    case "3":
                        Console.WriteLine(ProcessChestCommand(ChestState.Lock));
                        break;

                    case "4":
                        Console.WriteLine(ProcessChestCommand(ChestState.Unlock));
                        break;

                    case "5":
                        Console.WriteLine($"Shutting down..");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("du hast ein scheiss eingegeben");
                        break;
                }
            }

            while (true)
            {
                string befehl = Console.ReadLine();
                string ergebnis = ProcessChestCommand(befehl);
                Console.WriteLine(ergebnis);
            }


            /*
            while (true)
            {
                string stateFunktion = Console.ReadLine();

                if (stateFunktion == "open")
                {
                    Console.WriteLine($"The chest is {ChestState.Open}. What do you want to do?");
                }
                else if (stateFunktion == "close")
                {
                    Console.WriteLine($"The chest is {ChestState.Closed}. What do you want to do?");
                }
                else if (stateFunktion == "lock")
                {
                    Console.WriteLine($"The chest is {ChestState.Locked}. What do you want to do?");
                }
                else if (stateFunktion == "unlock")
                {
                    Console.WriteLine($"The chest is {ChestState.Unlocked}. What do you want to do?");
                }
                else
                {
                    Console.WriteLine("Sorry, i am not capable of doing that");
                }

            }
          */

        }

        public static string ProcessChestCommand(string stateFunktion)
        {
            stateFunktion = stateFunktion.ToUpper();

            if (stateFunktion == ChestState.Open.ToString().ToUpper())
                return ProcessChestCommand(ChestState.Open);

            if (stateFunktion == ChestState.Close.ToString().ToUpper())
                return ProcessChestCommand(ChestState.Close);

            if (stateFunktion == ChestState.Lock.ToString().ToUpper())
                return ProcessChestCommand(ChestState.Lock);

            if (stateFunktion == ChestState.Unlock.ToString().ToUpper())
                return ProcessChestCommand(ChestState.Unlock);
            return "Sorry, i am not capable of doing that";
        }

        //Option_1
        static string defaultRetString = $"The chest is currently {saveState.ToString()}, you can't do that.. What do you want to do?";
        static ChestState saveState = ChestState.Open;
        public static string ProcessChestCommand(ChestState state)
        {
            switch (state)
            {
                case ChestState.Open:
                    if (saveState == ChestState.Locked)
                    {
                        return defaultRetString;
                    }

                    saveState = state;
                    return $"The chest is currently {saveState.ToString()}. What do you want to do?";

                case ChestState.Close:
                    if (saveState != ChestState.Open)
                    {
                        return defaultRetString;
                    }

                    saveState = ChestState.Closed;
                    return $"The chest is currently {saveState.ToString()}. What do you want to do?";

                case ChestState.Lock:
                    if (saveState != ChestState.Closed)
                    {
                        return defaultRetString;
                    }

                    saveState = ChestState.Locked;
                    return $"The chest is currently {saveState.ToString()}. What do you want to do?";

                case ChestState.Unlock:
                    if (saveState != ChestState.Locked)
                    {
                        return defaultRetString;
                    }

                    saveState = ChestState.Unlocked;
                    return $"The chest is currently {saveState.ToString()}. What do you want to do?";

                default:
                    return "Sorry, i am not capable of doing that";
            }
        }
        //Option_2
        public static string ProcessChestCommandSam(ChestState state)
        {
            string retString = $"The chest is currently {state.ToString()}. What do you want to do?";
            switch (state)
            {
                case ChestState.Open:
                    if (saveState == ChestState.Locked)
                    {
                        retString = defaultRetString;
                        state = saveState;
                    }
                    break;

                case ChestState.Closed:
                    if (saveState != ChestState.Open)
                    {
                        retString = defaultRetString;
                        state = saveState;
                    }
                    break;

                case ChestState.Locked:
                    if (saveState != ChestState.Closed)
                    {
                        retString = defaultRetString;
                        state = saveState;
                    }
                    break;

                case ChestState.Unlocked:
                    if (saveState != ChestState.Locked)
                    {
                        retString = defaultRetString;
                        state = saveState;
                    }
                    break;

                default:
                    retString = "Sorry, i am not capable of doing that";
                    state = saveState;
                    break;
            }

            saveState = state;
            return retString;

        }



        public enum ChestState { Open, Closed, Locked, Unlocked, Close, Lock, Unlock }

    }

}
