namespace UrbanEntrepreneur;

internal class GameText
{
    public void WelcomeMessage()
    {
        Console.Clear();
        var weedLeaf = "                        .\r\n                       .:.\r\n                       :|:\r\n                      .:|:.\r\n                      ::|::\r\n       :.             ::|::             .:\r\n       :|:.          .::|::.          .:|:\r\n       ::|:.         :::|:::         .:|:;\r\n       `::|:.        :::|:::        .:|::'\r\n        ::|::.       :::|:::       .::|:;\r\n        `::|::.      :::|:::      .::|::'\r\n         :::|::.     :::|:::     .::|::;\r\n         `:::|::.    :::|:::    .::|::;'\r\n`::.      `:::|::.   :::|:::   .::|::;'      .:;'\r\n `:::..     ¹::|::.  :::|:::  .::|::¹    ..::;'\r\n   `:::::.    ':|::. :::|::: .::|:'   ,::::;'\r\n     `:::::.    ':|:::::|:::::|:'   :::::;'\r\n       `:::::.:::::|::::|::::|::::.,:::;'\r\n          ':::::::::|:::|:::|:::::::;:'\r\n             ':::::::|::|::|:::::::''\r\n                  `::::::::::;'\r\n                 .:;'' ::: ``::.\r\n                      :':':\r\n                        ;";
        var welcomeLogo = " _   _      _                                                  \r\n| | | |_ __| |__   __ _ _ __                                   \r\n| | | | '__| '_ \\ / _` | '_ \\                                  \r\n| |_| | |  | |_) | (_| | | | |                                 \r\n \\___/|_|  |_.__/ \\__,_|_| |_|                                 \r\n _____       _                                                 \r\n| ____|_ __ | |_ _ __ ___ _ __  _ __ ___ _ __   ___ _   _ _ __ \r\n|  _| | '_ \\| __| '__/ _ | '_ \\| '__/ _ | '_ \\ / _ | | | | '__|\r\n| |___| | | | |_| | |  __| |_) | | |  __| | | |  __| |_| | |   \r\n|_____|_| |_|\\__|_|  \\___| .__/|_|  \\___|_| |_|\\___|\\__,_|_|   \r\n                         |_|                                   ";
        CenterText(weedLeaf, ConsoleColor.Green);
        CenterText(welcomeLogo);
        Console.ReadKey();
    }

    public void PlayerInfoMenu() 
    { 
        Console.Clear();
        Console.WriteLine("Welcome to Urban Entrepreneur! \r\n");
        Console.ReadKey();
    }

    public void CenterText(string textGroup, ConsoleColor col = ConsoleColor.White)
    {
        var lines = textGroup.Split("\r\n", StringSplitOptions.None);
        var textLength = lines.Max(p => p.Length);

        var leftPadding = (Console.WindowWidth - textLength) / 2;
        if (leftPadding < 0) leftPadding = 0;

        var buffer = new string(' ', leftPadding);
        Console.ForegroundColor = col;
        foreach (var line in lines)
        {
            Console.WriteLine(buffer + line);
        }
    }
}