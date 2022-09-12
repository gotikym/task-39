using System;

internal class Program
{
    static void Main(string[] args)
    {
        Player[] players = { new Player("Ivan", 27), new Player("Mark", 18), new Player("Denis", 32) };
        
        ShowPlayers(players);
    }

    static void ShowPlayers(Player[] players)
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i].ShowInfo();
        }
    }
}

class Player
{
    private string _name;
    private int _age;

    public Player(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Имя: " + _name + "   Возраст: " + _age);
    }
}