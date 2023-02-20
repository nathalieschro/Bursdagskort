using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace HemmeligProsjekt
{
    public class IO
    {
        public static void PrintGifts()
        {
            List<string> Gifts = new List<string>()
            {
            "[1] Backstage tickets til Miley Cyrus",
            "[2] Eksklusivt møte med Charlie Miller", 
            "[3] Gratis tilgang til alle steam-spill",
            "[4] Betalt 365 dagers ferie",
            "[5] En all inclusive ferie til Bahamas for 4 personer",
            "[6] Fruktkurv"
            };

            foreach (string gift in Gifts)
            {
                Console.WriteLine(gift);
                Thread.Sleep(500);
            }
        }

        public static void PrintWelcomeMessagePart1()
        {
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Typewriter.Text("Chief");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(500);
            Typewriter.Text("RubberDuck",100);
            Console.ResetColor();
            Console.WriteLine("\n");
            Thread.Sleep(500);
            Typewriter.Text("Du har bursdag i dag");
            Console.WriteLine("\n");
            Thread.Sleep(500);
            Typewriter.Text("Velkommen til");
            Console.WriteLine("\n"); 
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Typewriter.Text("ROLL-A-DICE-AND-WIN-A-BIRTHDAY-GIFT");
            Console.WriteLine("\n");
            Console.ResetColor();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Typewriter.Text("I dette spillet får du muligheten til å vinne en gave");
            Console.WriteLine("\n");
            Console.ResetColor();
            Thread.Sleep(500);
        }

        public static void PrintAskToRoll()
        {
            Console.WriteLine("\n");
            Typewriter.Text("Vil du rrrrruuuuulllleeee terningen?");
        }
        public static bool InputYesOrNo()
        {
            Console.WriteLine("\n");
            Typewriter.Text("Skriv inn [j] for JA eller [n] for NEI");
            Console.WriteLine("\n");
            char input = Console.ReadKey(intercept: true).KeyChar;
            
            if (input == 'j')
            {
                return true;
            }

            return false;
        }

        public static void PrintAskToSelectGift()
        {
            Console.WriteLine("\n");
            Typewriter.Text("Hvilken premie vil du ha?");
            Console.WriteLine("\n");
        }

        public static int InputNumber ()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }


        public static void PrintTomasTriesToAvoidToPlay()
        {
            Console.WriteLine("\n");
            Typewriter.Text("Nei! Du må rulle terningen!");
            Console.WriteLine("\n");
            Thread.Sleep(900);
            Typewriter.Text("Når du skal være så vanskelig, ruller vi den for deg.");
            Thread.Sleep(2000);
        }

        public static void PrintRollDice()
        {
            Thread.Sleep(900);

            string[] dieFrames = new[]
            {
                @$"   ________  
  /\  *  * \  
 /  \   *   \  
/    \_______\  
\ *  /       /  
 \  /  * *  /  
  \/_______/  
                ",
                @$"    ________  
   /\       \  
  /  \   *   \  
 /  * \_______\  
 \ *  /       /  
  \  /  ***  /  
   \/_______/  
                ",
                @$"   ________  
  /\  *  * \  
 /  \  *  * \  
/ *  \_______\  
\ * */       /  
 \  /   *   /  
  \/_______/  
                ",
                @$"    ________  
   /\       \  
  /  \   *   \  
 /    \_______\  
 \ *  / * * * /  
  \  /   *   /  
   \/_______/  
                ",
                @$"   ________  
  /\  *    \  
 /  \ * *   \  
/    \_______\  
\ *  / * * * /  
 \  / *   * /  
  \/_______/  
                ",
                @$"   ________  
  /\       \  
 /  \  *  * \  
/ *  \_______\  
\ * */ * * * /  
 \  /   *   /  
  \/_______/  
                ",
                @$"    ________  
   /\ *     \  
  /  \ *   * \  
 /    \_______\  
 \ *  / * * * /  
  \  / *   * /  
   \/_______/  
                ",
                @$"    ________  
   /\ *     \  
  /  \ *   * \  
 / *  \_______\  
 \ * */ * * * /  
  \  / *   * /  
   \/_______/  
                ",
                @$"   ________  
  /\ *     \  
 /  \ *   * \  
/ *  \_______\  
\ * */  * *  /  
 \  / *   * /  
  \/_______/  
                "
};
            Console.Clear();
            Console.CursorVisible = false;
            int i = 0;
            while (!Console.KeyAvailable)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(dieFrames[i]);
                i = (i + 1) % dieFrames.Length;
                System.Threading.Thread.Sleep(100); // Pause for a short period to slow down the animation

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n    ___\r\n   //_\\\\_\r\n .\"\\\\    \".\r\n/          \\\r\n|           \\_\r\n|       ,--.-.)\r\n \\     /  o \\o\\\r\n /\\/\\  \\    /_/\r\n  (_.   `--'__)\r\n   |     .-'  \\\r\n   |  .-'.     )\r\n   | (  _/--.-'\r\n   |  `.___.'\r\n         (");
                Console.ResetColor();
                Console.Write($"\n -Press the any-key!!");
            }

            Console.ReadKey(true); // Clear the key that was pressed to exit the loop
            Console.CursorVisible = true;
            //Console.Clear();
            //Console.WriteLine(@"   ________");
            //Console.WriteLine(@"  /\  *  * \");
            //Console.WriteLine(@" /  \   *   \");
            //Console.WriteLine(@"/    \_______\");
            //Console.WriteLine(@"\ *  /       /");
            //Console.WriteLine(@" \  /  * *  /");
            //Console.WriteLine(@"  \/_______/");
            //Console.WriteLine("\n");
            //Typewriter.Text(@"Terning triller");
            //Thread.Sleep(500);
            //Console.Write(".");
            //Thread.Sleep(500);
            //Console.Write(".");
            //Thread.Sleep(500);
            //Console.Write(".");
            //Console.WriteLine("\n");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine(@"   ________");
            Console.WriteLine(@"  /\       \");
            Console.WriteLine(@" /  \   ()  \");
            Console.WriteLine(@"/    \_______\");
            Console.WriteLine(@"\ () /       /");
            Console.WriteLine(@" \  /   ()  /");
            Console.WriteLine(@"  \/_______/");
            Console.WriteLine("\n");
            Typewriter.Text("Terning rullet!");
            Console.WriteLine("\n");
            Thread.Sleep(1000);
            Typewriter.Text("Terningen trillet 0...");
            Console.WriteLine("\n");
            Typewriter.Text("Ingen premie vunnet");
            Thread.Sleep(4000);
            //Console.Clear();

            string[] squidwardTentacles = new[]
            {
            @"        .--'''''''''--.",
            @"     .'      .---.      '.",
            @"    /    .-----------.    \",
            @"   /        .-----.        \",
            @"   |       .-.   .-.       |",
            @"   |      /   \ /   \      |",
            @"    \    | .-. | .-. |    /",
            @"     '-._| | | | | | |_.-'",
            @"         | '-' | '-' |",
            @"          \___/ \___/",
            @"       _.-'  /   \  `-._",
            @"     .' _.--|     |--._ '.",
            @"     ' _...-|     |-..._ '",
            @"            |     |",
            @"            '.___.'",
            @"              | |",
            @"             _| |_",
            @"            /\( )/\",
            @"           /  ` '  \",
            @"          | |     | |",
            @"          '-'     '-'",
            @"          | |     | |",
            @"          | |     | |",
            @"          | |-----| |",
            @"       .`/  |     | |/`.",
            @"       |    |     |    |",
            @"       '._.'| .-. |'._.'",
            @"             \ | /",
            @"             | | |",
            @"             | | |",
            @"             | | |",
            @"            /| | |\",
            @"          .'_| | |_`.",
            @"          `. | | | .'",
            @"       .    /  |  \    .",
            @"      /o`.-'  / \  `-.`o\",
            @"     /o  o\ .'   `. /o  o\",
            @"     `.___.'       `.___.'",
        };


            int startX = (Console.WindowWidth - squidwardTentacles[0].Length) / 2;
            int startY = (Console.WindowHeight - squidwardTentacles.Length) / 2;
            //string[] colors = new[] { "Yellow", "DarkYellow", "Magenta", "DarkMagenta","Cyan", "DarkCyan" };
            int j = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (string item in squidwardTentacles)
            {
                if (j == 18) Console.ForegroundColor = ConsoleColor.Red;
                if (j == 24) Console.ForegroundColor = ConsoleColor.Cyan;

                Console.SetCursorPosition(startX, startY + j);
                Console.WriteLine(item);
                j++;

            }
            Console.ResetColor();


            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(@"        .--'''''''''--.");
            //Console.WriteLine(@"     .'      .---.      '.");
            //Thread.Sleep(100);
            //Console.WriteLine(@"    /    .-----------.    \");
            //Console.WriteLine(@"   /        .-----.        \");
            //Thread.Sleep(100);
            //Console.WriteLine(@"   |       .-.   .-.       |");
            //Console.WriteLine(@"   |      /   \ /   \      |");
            //Thread.Sleep(100);
            //Console.WriteLine(@"    \    | .-. | .-. |    /");
            //Console.WriteLine(@"     '-._| | | | | | |_.-'");
            //Thread.Sleep(100);
            //Console.WriteLine(@"         | '-' | '-' |");
            //Console.WriteLine(@"          \___/ \___/");
            //Thread.Sleep(100);
            //Console.WriteLine(@"       _.-'  /   \  `-._");
            //Console.WriteLine(@"     .' _.--|     |--._ '.");
            //Thread.Sleep(100);
            //Console.WriteLine(@"     ' _...-|     |-..._ '");
            //Console.WriteLine(@"            |     |");
            //Thread.Sleep(100);
            //Console.WriteLine(@"            '.___.'");
            //Console.WriteLine(@"              | |");
            //Thread.Sleep(100);
            //Console.WriteLine(@"             _| |_");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(@"            /\( )/\");
            //Thread.Sleep(100);
            //Console.WriteLine(@"           /  ` '  \");
            //Console.WriteLine(@"          | |     | |");
            //Thread.Sleep(100);            
            //Console.WriteLine(@"          '-'     '-'");
            //Console.WriteLine(@"          | |     | |");
            //Thread.Sleep(100);
            //Console.WriteLine(@"          | |     | |");
            //Console.WriteLine(@"          | |-----| |");
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Thread.Sleep(100);
            //Console.WriteLine(@"       .`/  |     | |/`.");
            //Console.WriteLine(@"       |    |     |    |");
            //Thread.Sleep(100);
            //Console.WriteLine(@"       '._.'| .-. |'._.'");
            //Console.WriteLine(@"             \ | /");
            //Thread.Sleep(100);
            //Console.WriteLine(@"             | | |");
            //Console.WriteLine(@"             | | |");
            //Thread.Sleep(100);
            //Console.WriteLine(@"             | | |");
            //Console.WriteLine(@"            /| | |\");
            //Thread.Sleep(100);
            //Console.WriteLine(@"          .'_| | |_`.");
            //Console.WriteLine(@"          `. | | | .'");
            //Thread.Sleep(100);
            //Console.WriteLine(@"       .    /  |  \    .");
            //Console.WriteLine(@"      /o`.-'  / \  `-.`o\");
            //Thread.Sleep(100);
            //Console.WriteLine(@"     /o  o\ .'   `. /o  o\");
            //Console.WriteLine(@"     `.___.'       `.___.'");
            //Thread.Sleep(2000);
            //Console.ResetColor();
            //Console.Clear();
        }

        public static void PrintConsolationPrize()
        {
            Typewriter.Text("Som takk for deltagelse får du en trøstepremie");
            Console.WriteLine("\n");
            Thread.Sleep(1100);
            Typewriter.Text("Du får den utlevert etter at spillet er ferdig");
            Thread.Sleep(3200);
        }

        public static void PrintWelcomeMessagePart2()
        {
            Thread.Sleep(1000);
            Console.Clear();
            Typewriter.Text("Fordi spillet er ikke ferdig helt enda...");
            Console.WriteLine("\n");
            Typewriter.Text("Siden du har bursdag i dag får du en siste sjanse");
            Console.WriteLine("\n");
            Thread.Sleep(900);
            Typewriter.Text("Du kan nå velge én av premiene fra første runde");
            Console.WriteLine("\n");
            Thread.Sleep(1000);
            PrintGifts();
        }

        public static void PrintUnknownError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Typewriter.Text("Beep boop, unknown error, prøv igjen");
            Console.ResetColor();
        }

        public static void PrintExcuseForNotGivingGift(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("\n");
                    Typewriter.Text("Ånei, Hans kjøpte visst den siste tilgjengelige billetten. Prøv igjen.");
                    break;
                case 2:
                    Console.WriteLine("\n");
                    Typewriter.Text("Charlie hadde ikke tid til å møte deg. Prøv igjen");
                    break;
                case 3:
                    Console.WriteLine("\n");
                    Typewriter.Text("Ehhh...Her var vi litt optimiske. Uhm. UTSOLGT sier Kristian. Prøv igjen");
                    break;
                case 4:
                    Console.WriteLine("\n");
                    Typewriter.Text("Du vil vel ikke ha ferie? Prøv igjen");
                    break;
                case 5:
                    Console.WriteLine("\n");
                    Typewriter.Text("For fint vær i Bahamas i disse dager. Prøv igjen.");
                    break;
            }
        }

        public static void PrintWonFruitBasket()
        {
            Console.WriteLine("\n");
            Typewriter.Text("Du vant en fruktkurv!");
            Console.WriteLine("\n");
            Typewriter.Text("Gratulerer, du er den eneste deltakeren som noensinne har valgt fruktkurven!");

        }

        public static void BirthdaySong()
        {
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }

        public static void PrintBirthdayCake()
        {         
            // Putting the cake in an array, for easier centering...
            string[] cake = new[] {
                @"                0   0                ",
                @"                |   |                ",
                @"            ____|___|____            ",
                @"         0  |~ ~ ~ ~ ~ ~|   0        ",
                @"         |  |           |   |        ",
                @"      ___|__|___________|___|__      ",
                @"      |/\/\/\/\/\/\/\/\/\/\/\/|      ",
                @"  0   |         TOMAS         |   0  ",
                @"  |   |/\/\/\/\/\/\/\/\/\/\/\/|   |  ",
                @" _|___|_______________________|___|__",
                @"|/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/|",
                @"|                                   |",
                @"|        GRATULERER MED DAGEN       |",
                @"| ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ |",
                @"|___________________________________|"
            };

            // Finding Nemo, i.e. center of console screen
            int startX = (Console.WindowWidth - cake[0].Length) / 2;
            int startY = (Console.WindowHeight - cake.Length) / 2;
            //string[] colors = new[] { "Yellow", "DarkYellow", "Magenta", "DarkMagenta","Cyan", "DarkCyan" };
            int i = 0;

            Console.Clear();

            foreach (string item in cake)
            {
                // TODO: iterate through the colors-array to get colors, instead of hardcoding, like this
                if (i == 2) Console.ForegroundColor = ConsoleColor.Yellow;
                if (i == 5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (i == 7) Console.ForegroundColor = ConsoleColor.Magenta;
                if (i == 9) Console.ForegroundColor = ConsoleColor.DarkMagenta;
                if (i == 11) Console.ForegroundColor = ConsoleColor.Cyan;
                if (i == 13) Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.SetCursorPosition(startX, startY + i);
                Console.WriteLine(item);
                i++;
            }
            // "hide" the default console end-of-program-text and hide the cursor.
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;

            //START: Original cake
            //Console.Clear();
            //Console.WriteLine(@"                0   0                ");
            //Console.WriteLine(@"                |   |                ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(@"            ____|___|____            ");
            //Console.WriteLine(@"         0  |~ ~ ~ ~ ~ ~|   0        ");
            //Console.WriteLine(@"         |  |           |   |        ");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine(@"      ___|__|___________|___|__      ");
            //Console.WriteLine(@"      |/\/\/\/\/\/\/\/\/\/\/\/|      ");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine(@"  0   |         TOMAS         |   0  ");
            //Console.WriteLine(@"  |   |/\/\/\/\/\/\/\/\/\/\/\/|   |  ");
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.WriteLine(@" _|___|_______________________|___|__");
            //Console.WriteLine(@"|/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/|");
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(@"|                                   |");
            //Console.WriteLine(@"|        GRATULERER MED DAGEN       |");
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine(@"| ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ |");
            //Console.WriteLine(@"|___________________________________|");
            //Console.ResetColor();
            //END: Original cake
        }
    }
}
