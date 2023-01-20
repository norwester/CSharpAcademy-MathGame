namespace MathGame1
{
    internal class GameMenu
    {
        int rounds = 5;
        GameEngine engine = new();
        internal void ShowMenu (string? name, DateTime date)  //internal so it can be accessed outside this class
        {
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}, it's {date.DayOfWeek}.  Lets become mathletes together!.\n");
            Console.WriteLine("Press any key to show menu\n");
            Console.ReadLine();
            
            bool IsGameOn = true;

            do
            {

                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from options below:
        V - View Previous Games
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        Q - Quit the program");
                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition Game");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction Game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                        engine.DivisionGame("Division Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        IsGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (IsGameOn);
        }
    }
}
