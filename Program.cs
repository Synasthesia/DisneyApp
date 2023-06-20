namespace DisneyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoryBook storyBook = new StoryBook();

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You have create " + DisneyCharacter.charactersCreated + "" +
                    "Disney Characters!");
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Create a Princess and SideKick\n" +
                    "2. Create a Villain\n" +
                    "3. Interact with Characters\n" +
                    "4. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Princess princess = new Princess("", "", "", "");
                        princess.PrincessMenu();
                        storyBook.AddCharacter(princess);
                        princess.InitialDisplay();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Villain villain = new Villain("", "", "", "");
                        villain.VillainMenu();
                        storyBook.AddCharacter(villain);
                        Console.Clear();
                        villain.InitialDisplay();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Which Villain do you want to interact with:");
                        Console.WriteLine("Type in their name");
                        storyBook.DisplayAllVillains();
                        string userInput = Console.ReadLine();
                        Villain villainChoice = storyBook.GetVillain(userInput);
                        Console.Clear();
                        Console.WriteLine("Which Princess do you want to interact with:");
                        Console.WriteLine("Type in their name");
                        storyBook.DisplayAllPrincesses();
                        userInput = Console.ReadLine();
                        Princess princessChoice = storyBook.GetPrincess(userInput);

                        //interaction
                        princessChoice.Greeting();
                        princessChoice.SideKick.Greeting();
                        villainChoice.Greeting();
                        if (villainChoice.Enemy == princessChoice.Name)
                        {
                            villainChoice.IrritationLevel += 10;
                            villainChoice.DisplayIrritation();
                        }

                        Random random = new Random();
                        if (random.Next() % 2 == 0)
                        {
                            princessChoice.Sing();
                            villainChoice.Sing();
                            villainChoice.Attack();
                        }
                        Console.ReadLine();
                        break;
                    case "4":
                        isRunning = false;
                        break;

                }

            }
        }
    }
}