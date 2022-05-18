using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Player
{
    private int _id;
    private string _name;
    private int _score;

    public int Id { get { return _id; } set { _id = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    public int Score { get { return _score; } set { _score = value; } }

    public Player(int id, string name, int score)
    {
        Id = id;
        Name = name;
        Score = score;
    }

    public void Player_scores(int score)
    {
        Score += score;
        if (Score > 50)
        {
            Score += score;



            Console.WriteLine(Name + " wins!");
            Console.WriteLine();
            Environment.Exit(0);
        }

    }


}
