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

    if (Extern.GetAsyncKeyState(Extern.VK_W) < 0)
    {
        if (map.CheckMap(x, y - 1)) y--;
    }
    if (Extern.GetAsyncKeyState(Extern.VK_S) < 0)
    {
        if (map.CheckMap(x, y + 1)) y++;
    }
    if (Extern.GetAsyncKeyState(Extern.VK_A) < 0)
    {
        if (map.CheckMap(x - 1, y)) x--;
    }
    if (Extern.GetAsyncKeyState(Extern.VK_D) < 0)
    {
        if (map.CheckMap(x + 1, y)) x++;
    }
    if (Extern.GetAsyncKeyState(Extern.VK_ESCAPE) < 0)
    {
        Environment.Exit(0);
    }

    Thread.Sleep(5);
}