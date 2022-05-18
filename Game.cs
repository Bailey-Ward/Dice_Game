using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Game
{
    public static void check_dice(Player player, List<int> diceValues)
    {
        int score = 0;
        var matches = diceValues.GroupBy(x => x);
        //Score 3 of a kinds
        score += matches.Count(x => x.Count() == 3) * 3;
        //Score 4 of a kinds
        score += matches.Count(x => x.Count() == 4) * 6;
        //Score 5 of a kinds
        score += matches.Count(x => x.Count() == 5) * 12;

        if(score == 3)
        {
            Console.WriteLine("\nThree of a kind!");
        }
        else if(score == 6)
        {
            Console.WriteLine("\nFour of a kind!");
        }
        else if(score == 12)
        {
            Console.WriteLine("\nFive of a kind!!!!!!");
        }
        else
        {
            Console.WriteLine("\nNo matches!");
        }

        // change the player's score accordingly
        player.Player_scores(score);

    }
}
