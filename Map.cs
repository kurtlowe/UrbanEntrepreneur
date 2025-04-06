namespace UrbanEntrepreneur;

internal class Map
{
    private readonly int _windowSize = 25;
    private readonly List<string> _data = [
        "╔═════════════════════════════════╗                                      ",
        "║  ^                              ║                                      ",
        "║      ╔═D═╗           ╔═D═╗      ║                                      ",
        "║      ║   ║           ║   ║      ║                                      ",
        "║      ╚═══╝    ^      ╚═══╝      ║                                      ",
        "║                             ^   ╚═════════════════════════════════════╗",
        "║  ^                                                               ~~~~^║",
        "║      ╔══════════ ══════════╗    ╔═════════════════════════════════════╝",
        "║      ║               ^     ║    ║                                      ",
        "║      ║  ~~~~~~~~~~~~~~~~   ║    ║                                      ",
        "║      ║  ~~~~~~~~~~~~~~~~   ║    ║                                      ",
        "║      ║  ~~~~~~~~~~~~~~~~   ║    ║                                      ",
        "║      ║    ^                ║    ║                                      ",
        "║      ╚══════════ ══════════╝    ║                                      ",
        "║                                 ║                                      ",
        "║               ^            ^    ║                                      ",
        "║      ╔═D═╗           ╔═D═╗      ║                                      ",
        "║      ║   ║           ║   ║      ║                                      ",
        "║      ╚═══╝   ^       ╚═══╝      ║                                      ",
        "║                                 ║                                      ",
        "╚═════════════════════════════════╝                                      ",
    ];

    public bool CheckMap(int x, int y)
    {
        if (x < 0 || x >= _data[0].Length || y < 0 || y >= _data.Count)
        {
            return false;
        }
        var c = _data[y][x];
        return c == ' ' || c == '~';
    }

    public void DisplayMap(int centerX, int centerY)
    {
        Console.SetCursorPosition(0, 0);
        var halfWindowSize = _windowSize / 2;
        var startX = centerX - halfWindowSize;
        var endX = centerX + halfWindowSize;
        var startY = centerY - halfWindowSize;
        var endY = centerY + halfWindowSize;

        for (var y = startY; y <= endY; y++)
        {
            for (var x = startX; x <= endX; x++)
            {
                if (x < 0 || x >= _data[0].Length || y < 0 || y >= _data.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(' ');
                }
                else
                {
                    var c = _data[y][x];
                    if (c == '╦' || c == '╩' || c == '╔' || c == '╗' || c == '╚' || c == '╝' || c == '═' || c == '║')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (c == '~') { Console.ForegroundColor = ConsoleColor.Blue; }
                    else if (c == '^') { Console.ForegroundColor = ConsoleColor.DarkGreen; }
                    else if (c == 'D') { Console.ForegroundColor = ConsoleColor.Gray; }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    if (centerX == x && centerY == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write('@');
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}