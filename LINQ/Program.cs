using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a list of video game names
        List<string> videoGames = new List<string>
        {
            "The Witcher 3: Wild Hunt",
            "Minecraft",
            "Among Us",
            "Grand Theft Auto V",
            "The Last of Us Part II",
            "Fortnite",
            "Call of Duty: Warzone",
            "Animal Crossing: New Horizons",
            "Zelda: Breath of the Wild",
            "Halo Infinite"
        };

        // Step 2: Order the list by the length of the game name using LINQ
        var orderedGames = videoGames.OrderBy(game => game.Length).ToList();

        // Step 3: Print the ordered list
        Console.WriteLine("Video Games Ordered by Name Length:");
        foreach (var game in orderedGames)
        {
            Console.WriteLine($"{game} (Length: {game.Length})");
        }
    }
}

