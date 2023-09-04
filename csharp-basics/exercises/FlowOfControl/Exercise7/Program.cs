using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Let's play Rock-Paper-Scissors!");
            Console.WriteLine("Enter your move (Rock, Paper, or Scissors): ");
            string userMove = Console.ReadLine().ToLower();

            Random random = new Random();
            string[] validMoves = { "rock", "paper", "scissors" };
            string computerMove = validMoves[random.Next(validMoves.Length)];

            Console.WriteLine("Computer's move: " + computerMove);

            string result = DetermineWinner(userMove, computerMove);
            Console.WriteLine(result);
        }

        static string DetermineWinner(string playerMove, string computerMove)
        {
            if (playerMove == computerMove)
            {
                return "It's a tie!";
            }
            else if ((playerMove == "rock" && computerMove == "scissors") ||
                     (playerMove == "paper" && computerMove == "rock") ||
                     (playerMove == "scissors" && computerMove == "paper"))
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }
    }
}
