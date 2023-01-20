
using MathGame1.Models;
using System.Linq;

namespace MathGame1
{
    public class Helpers
    {
        static int rounds = 5;
        //static List<Game> games = new();  //Field: Declared directly inside class, can be used by all methods in the class
        internal static List<Game> games = new List<Game>
        {
            //Prepoulated game data
            /*
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
            */
        };
        internal static void PrintGames()
        {
            //linq, using lamba expression, loops through list looking for  gametype or date etc.
            //var gamesToPrint = games.Where(x => x.Type == GameType.Division);
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2023,01,20));
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2023, 01, 20) && x.Score > 3);
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2023, 01, 20)).OrderByDescending(x => x.Date);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------");

            foreach (var game in games) //gamesToPrint to build from prepoulated list
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} out of {rounds}");
            }
            Console.WriteLine("-----------------\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            //games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore} out of {rounds}");
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);
            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            //validate, out variable with no outpute needed
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try Again");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name= Console.ReadLine();
            }
            return name;
        }

    }
}
