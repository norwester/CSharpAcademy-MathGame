
namespace MathGame1.Models;

internal class Game
{
    //Model class holds properties, these are characterists of the Game (the model)

    /*Long way to declare
    private int _score;
    public int Score { 
        get { return _score; } 
        set { _score = value; }
    }
    */

    //access modifier: public
    //type int
    //name Score
    //methods get; set;
    public int Score { get; set; }  
    public DateTime Date { get; set; }
    public GameType Type { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Division,
    Multiplication
}