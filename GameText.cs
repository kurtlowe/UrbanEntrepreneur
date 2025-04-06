namespace UrbanEntrepreneur;

internal class GameText
{
    public void WelcomeMessage()
    {
        string weedLeaf = "                        .\r\n                       .:.\r\n                       :|:\r\n                      .:|:.\r\n                      ::|::\r\n       :.             ::|::             .:\r\n       :|:.          .::|::.          .:|:\r\n       ::|:.         :::|:::         .:|:;\r\n       `::|:.        :::|:::        .:|::'\r\n        ::|::.       :::|:::       .::|:;\r\n        `::|::.      :::|:::      .::|::'\r\n         :::|::.     :::|:::     .::|::;\r\n         `:::|::.    :::|:::    .::|::;'\r\n`::.      `:::|::.   :::|:::   .::|::;'      .:;'\r\n `:::..     ¹::|::.  :::|:::  .::|::¹    ..::;'\r\n   `:::::.    ':|::. :::|::: .::|:'   ,::::;'\r\n     `:::::.    ':|:::::|:::::|:'   :::::;'\r\n       `:::::.:::::|::::|::::|::::.,:::;'\r\n          ':::::::::|:::|:::|:::::::;:'\r\n             ':::::::|::|::|:::::::''\r\n                  `::::::::::;'\r\n                 .:;'' ::: ``::.\r\n                      :':':\r\n                        ;";
        string welcomeLogo = " _   _      _                                                  \r\n| | | |_ __| |__   __ _ _ __                                   \r\n| | | | '__| '_ \\ / _` | '_ \\                                  \r\n| |_| | |  | |_) | (_| | | | |                                 \r\n \\___/|_|  |_.__/ \\__,_|_| |_|                                 \r\n _____       _                                                 \r\n| ____|_ __ | |_ _ __ ___ _ __  _ __ ___ _ __   ___ _   _ _ __ \r\n|  _| | '_ \\| __| '__/ _ | '_ \\| '__/ _ | '_ \\ / _ | | | | '__|\r\n| |___| | | | |_| | |  __| |_) | | |  __| | | |  __| |_| | |   \r\n|_____|_| |_|\\__|_|  \\___| .__/|_|  \\___|_| |_|\\___|\\__,_|_|   \r\n                         |_|                                   ";
        Console.ForegroundColor = ConsoleColor.Green;
        CenterText(weedLeaf, welcomeLogo);
    }

    public void PlayerInfoMenu() 
    { 
         
    }

    public void CenterText(string weedLeaf, string welcomeLogo)
    {
        int windowWidth = Console.WindowWidth;
        int textLength = 50;
        int leftPadding = (windowWidth - textLength) / 2;
        if (leftPadding < 0) leftPadding = 0;

        foreach (var line in weedLeaf.Split("\r\n", StringSplitOptions.None))
        {
            Console.WriteLine(new string(' ', leftPadding) + line);
        }

        foreach (var line in welcomeLogo.Split("\r\n", StringSplitOptions.None))
        {
            Console.WriteLine(new string(' ', leftPadding) + line);
        }
    }
}