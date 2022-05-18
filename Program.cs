

Console.WriteLine("Welcome to Three or More!");
Console.WriteLine("To score, you need to get a pair of 3, 4 or 5, and the first to score 50 points wins!");

Console.Write("\nEnter the number of players: ");
try
{
    int numberOfPlayers = int.Parse(Console.ReadLine());
    List<Player> players = new List<Player>();

    // user chooses the number of players
    // now we create that many number of 'Player' objects


    for (int i = 0; i < numberOfPlayers; i++)
    {
        int playerID = i + 1;
        Console.Write("Please enter the username for player " + playerID + ": ");
        string playerName = Console.ReadLine();

        players.Add(new Player(playerID, playerName, 0));
    }
    // by the end of this for loop, we have initialized our players

    while (true)
    {
        foreach (var player in players)
        {

            Console.WriteLine(player.Name + " has rolled: ");
            Game.check_dice(player, Die.roll_dice());
            Console.WriteLine("\n" + player.Name + " currently has a score of: " + player.Score);
            Console.ReadLine();
        }

    }
}
catch (FormatException)
{
    Console.WriteLine("This is not a number!");
}
