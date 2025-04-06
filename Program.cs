using UrbanEntrepreneur;

Console.Clear();
Console.CursorVisible = false;

var textGenerator = new GameText();
textGenerator.WelcomeMessage();
textGenerator.PlayerInfoMenu();

Console.Clear();
var map = new Map();
var x = 1;
var y = 1;
while (true)
{
    map.DisplayMap(x, y);
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey(true).Key;
        switch (key)
        {
            case ConsoleKey.W:
                if (map.CheckMap(x, y - 1)) y--;
                break;
            case ConsoleKey.S:
                if (map.CheckMap(x, y + 1)) y++;
                break;
            case ConsoleKey.A:
                if (map.CheckMap(x - 1, y)) x--;
                break;
            case ConsoleKey.D:
                if (map.CheckMap(x + 1, y)) x++;
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }
        while (Console.KeyAvailable) { Console.ReadKey(true); }
    }
}