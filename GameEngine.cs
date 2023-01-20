using MathGame1.Models;

namespace MathGame1
{
    internal class GameEngine
    {
        int rounds = 5;
        internal void AdditionGame(string message)
        {
            var score = 0;
            int firstNumber;
            int secondNumber;
            var random = new Random();

            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);
             
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your score is {score} out of {i + 1}. Press any key to return to menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }
        internal void SubtractionGame(string message)
        {
            var score = 0;
            int firstNumber;
            int secondNumber;
            var random = new Random();

            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your score is {score} out of {i + 1}. Press any key to return to menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void DivisionGame(string message)
        {
            var score = 0;
            int firstNumber;
            int secondNumber;
            var random = new Random();

            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];
                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your score is {score} out of {i + 1} . Press any key to return to menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Division);
        }
        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var score = 0;
            int firstNumber;
            int secondNumber;
            var random = new Random();

            for (int i = 0; i < rounds; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your score is {score} out of {i + 1} . Press any key to return to menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }
    }
}
