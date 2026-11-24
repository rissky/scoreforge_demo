using System;
using System.Collections.Generic;

namespace ScoreForge
{

    /// <summary>
    /// ScoreForge — Session 1 Starter Application.
    /// Displays a hardcoded list of esports players ready for Git orientation
    /// and future sprints (File I/O, Bubble Sort, LINQ, and Export).
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. Print the application header banner
                Console.WriteLine("=== SCOREFORGE LEADERBOARD ===");

                // 2. Hardcoded starter dataset (replaced by File I/O in Session 2)
                List<PlayerScore> scores = new List<PlayerScore>
                {
                    new PlayerScore { PlayerName = "Kira", Points = 420 },
                    new PlayerScore { PlayerName = "Devon", Points = 610 },
                    new PlayerScore { PlayerName = "Sana", Points = 350 },
                    new PlayerScore { PlayerName = "Tariq", Points = 780 },
                    new PlayerScore { PlayerName = "Mia", Points = 505 }
                };

                // 3. Loop through every PlayerScore in insertion order and display it
                foreach (PlayerScore player in scores)
                {
                    Console.WriteLine($"{player.PlayerName} - {player.Points} pts");
                }
            }
            catch (Exception ex)
            {
                // Defensive catch block so unexpected runtime errors print cleanly
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}