namespace Fish_Party
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool loopLogin = false;

            while (loopLogin)
            {

                Console.Clear();
                Console.WriteLine("--- PARTY FISH ---");
                Console.WriteLine("");
                Console.WriteLine("Please Log in to continue:");
                Console.Write("Username: ");
                string username = Console.ReadLine("");
                Console.Write("Password: ");
                string password = Console.ReadLine("");
                
                if (username == "Melollo")
                {

                }

            }

            bool loopMenu = true;

            while (loopMenu)
            {

                Console.Clear();
                Console.WriteLine("--- PARTY FISH ---");
                Console.WriteLine("");
                Console.WriteLine("Choose an option by inputting the corresponding number:");
                Console.WriteLine("1. Fish's Game");
                Console.WriteLine("2. Exit");
                Console.WriteLine("");
                string choice = Console.ReadLine("");

                if (choice == "1")
                {
                    FishsGame();
                }
                else if (choice == "2")
                {
                    System.Environment.Exit(0);
                }

            }

        }

        FishsGame()
        {

            bool loopMenu = true;

            while (loopMenu)
            {

                Console.Clear;
                Console.WriteLine("<-- FISH'S GAME --");
                Console.WriteLine("");
                Console.WriteLine("The ULTIMATE Fishing Competition!");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Choose an option by inputting the corresponding number:");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2 - Achievements");
                Console.WriteLine("3 - Rules & Instructions");
                Console.WriteLine("4 - Credits");
                Console.WriteLine("5 - Go Back to Menu");
                Console.WriteLine("");
                string choice = Console.ReadLine();

                if (choice == 1)
                {



                }
                else if (choice == 2)
                {

                    Console.Clear();
                    Console.WriteLine("<- Achievements -");
                    Console.WriteLine("");
                    Console.WriteLine("*There are no Achievements here yet...");
                    // catch the smallest possible fish
                    // catch the biggest possible fish
                    // catch a total of 10 fishes / catch a total of 100 fishes
                    // play one whole game from start to finish
                    // pet a fish
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("[Press RETURN to return]");
                    string wait = Console.ReadLine("");

                }
                else if (choice == 3)
                {

                    Console.Clear();
                    Console.WriteLine("<- Rules & Instructions -");
                    Console.WriteLine("");
                    Console.WriteLine("Summary: Up to three players can play the game together, competing in who can catch the shark. To catch the shark, you must first reach the end of the bridge by catching other fishes.");
                    Console.WriteLine("");
                    Console.WriteLine("1. Cast your rod to catch a fish.");
                    Console.WriteLine("2. Move steps on the bridge according to the weight of the fish. The larger the weight, the more steps. If you catch something else than a fish, you move backwards.");
                    Console.WriteLine("3. Be the first to reach the end of the bridge to catch the big shark. The first person to catch is wins.");
                    Console.WriteLine("");
                    Console.WriteLine("*No fishes are harmed during this game, all fishes are put back safely into the sea, and the fishes choose to bite the fake, non-harmful lure :]");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("[Press RETURN to return]");
                    string wait = Console.ReadLine("");

                }
                else if (choice == 4)
                {

                    Console.Clear();
                    Console.WriteLine("<- Credits -");
                    Console.WriteLine("");
                    Console.WriteLine("Melvin Piirimets / Melollo - Creator");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("[Press RETURN to return]");
                    string wait = Console.ReadLine("");

                }
                else if (choice == 5)
                {

                    loopMenu = false;

                }

            }

        }

    }
}
