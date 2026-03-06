using System;

class PingPongGame
{
    static void Main(string[] args)
    {
        int player1Score = 0;
        int player2Score = 0;
        int rounds = 5;

        Console.WriteLine("Welcome to the Ping Pong Game!");
        Console.WriteLine("First to reach 5 points wins!");

        for (int i = 0; i < rounds; i++)
        {
            Console.WriteLine($"\nRound {i + 1}:");
            Console.WriteLine("Player 1, press Enter to score...");
            Console.ReadLine();
            player1Score++;
            Console.WriteLine("Player 1 scores! Current score: {player1Score} - {player2Score}");

            Console.WriteLine("Player 2, press Enter to score...");
            Console.ReadLine();
            player2Score++;
            Console.WriteLine("Player 2 scores! Current score: {player1Score} - {player2Score}");

            if (player1Score >= 5)
            {
                Console.WriteLine("Player 1 wins!");
                return;
            }
            else if (player2Score >= 5)
            {
                Console.WriteLine("Player 2 wins!");
                return;
            }
        }

        Console.WriteLine("Game Over! Final Score: ");
        Console.WriteLine($"Player 1: {player1Score}, Player 2: {player2Score}");
        if (player1Score > player2Score)
            Console.WriteLine("Player 1 wins the game!");
        else if (player2Score > player1Score)
            Console.WriteLine("Player 2 wins the game!");
        else
            Console.WriteLine("It's a tie!");
    }
}