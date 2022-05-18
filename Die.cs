using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Die
{
    public static List<int> roll_dice()
    {
        List<int> roll = new List<int>();
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            roll.Add(random.Next(1, 7));
        }
        foreach (int i in roll)
        {
            Console.Write("|" + i + "|");
        }
        return roll;
    }            
}


