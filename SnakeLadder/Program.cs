using System;
namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Console.WriteLine("================================");
            int playerScore;
            playerScore = 0;
            Console.WriteLine("Initial Player Score : " + playerScore);
            playerScore = RollTheDie();
            Console.WriteLine("After rolling the die, score is " + playerScore);
            return;
        }
        static int RollTheDie()
        {
            Random random = new Random();
            int score = random.Next(1, 7);
            return score;
        }
    }
}