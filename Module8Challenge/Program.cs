using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of VideoGame objects
            List<VideoGame> games = new List<VideoGame>();
            
            // Add at least five video games to the list
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5 });
            games.Add(new VideoGame { Name = "The Legend of Zelda", Genre = "Adventure", Rating = 4.8 });
            games.Add(new VideoGame { Name = "Minecraft", Genre = "Sandbox", Rating = 4.7 });
            games.Add(new VideoGame { Name = "Tetris", Genre = "Puzzle", Rating = 3.9 });
            games.Add(new VideoGame { Name = "Red Dead Redemption 2", Genre = "Action-Adventure", Rating = 4.9 });
            games.Add(new VideoGame { Name = "Fortnite", Genre = "Battle Royale", Rating = 3.8 });
            games.Add(new VideoGame { Name = "God of War", Genre = "Action-Adventure", Rating = 4.8 });

            // LINQ query to get games with rating 4 or higher
            var topRatedGames = (from game in games
                                where game.Rating >= 4
                                select game).ToList();

            // LINQ query to sort the top rated games by name
            var sortedGames = (from game in topRatedGames
                              orderby game.Name
                              select game).ToList();

            Console.WriteLine("Top Rated Video Games (Sorted by Name):");
            Console.WriteLine("--------------------------------------");
            
            // Print out the names of the games in the sorted list
            foreach (var game in sortedGames)
            {
                Console.WriteLine($"{game.Name} - Rating: {game.Rating}");
            }
        }
    }
}