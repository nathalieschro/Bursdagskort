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
                Thread.Sleep(900);
            }
        }

        public static void PrintWelcomeMessagePart1()
        {
            Console.Beep();
            Typewriter.Text("Chief RubberDuck");
            Console.WriteLine("\n");
            Thread.Sleep(1100);
            Typewriter.Text("Du har bursdag i dag");
            Console.WriteLine("\n");
            Thread.Sleep(1100);
            Typewriter.Text("Velkommen til");
            Console.WriteLine("\n"); 
            Thread.Sleep(1100);
            Console.ForegroundColor= ConsoleColor.Magenta;
            Typewriter.Text("ROLL-A-DICE-AND-WIN-A-BIRTHDAY-GIFT");
            Console.WriteLine("\n");
            Console.ResetColor();
            Thread.Sleep(1100);
            Console.ForegroundColor = ConsoleColor.Green;
            Typewriter.Text("I dette spillet får du muligheten til å vinne en gave");
            Console.WriteLine("\n");
            Console.ResetColor();
            Thread.Sleep(900);
        }

        public static void PrintAskToRoll()
        {
            Console.WriteLine("\nVil du rrrrruuuuulllleeee terningen?");
        }

        public static void PrintAskToSelectGift()
        {
            Console.WriteLine("\nHvilken gave vil du ha?");
        }

        public static int InputNumber ()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public static bool InputYesOrNo()
        {
            Console.WriteLine("\nSkriv inn [j] for JA og [n] for NEIN");
            char input = Console.ReadKey(intercept: true).KeyChar;
            
            if (input == 'j')
            {
                return true;
            }

            return false;
        }

        public static void PrintTomasTriesToAvoidToPlay()
        {
            Console.WriteLine("Nei! Du må rulle terningen!\n");
            Thread.Sleep(900);
            Console.WriteLine("Når du skal være så vanskelig, ruller vi den for deg.");
            Thread.Sleep(2000);
        }

        public static void PrintRollDice()
        {
            Thread.Sleep(900);
            Console.Clear();
            Console.WriteLine(@"   ________");
            Console.WriteLine(@"  /\  *  * \");
            Console.WriteLine(@" /  \   *   \");
            Console.WriteLine(@"/    \_______\");
            Console.WriteLine(@"\ *  /       /");
            Console.WriteLine(@" \  /  * *  /");
            Console.WriteLine(@"  \/_______/");
            Console.WriteLine(@"Terning triller");
            Thread.Sleep(1000);

            Console.WriteLine(@"   ________");
            Console.WriteLine(@"  /\       \");
            Console.WriteLine(@" /  \   ()  \");
            Console.WriteLine(@"/    \_______\");
            Console.WriteLine(@"\ () /       /");
            Console.WriteLine(@" \  /   ()  /");
            Console.WriteLine(@"  \/_______/");

            Console.WriteLine("Terning rullet!");
            Thread.Sleep(1000);
            Console.WriteLine("Terningen trillet 0...");
            Thread.Sleep(4000);
            Console.Clear();

            Console.WriteLine(@"        .--'''''''''--.");
            Console.WriteLine(@"     .'      .---.      '.");
            Thread.Sleep(100);
            Console.WriteLine(@"    /    .-----------.    \");
            Console.WriteLine(@"   /        .-----.        \");
            Thread.Sleep(100);
            Console.WriteLine(@"   |       .-.   .-.       |");
            Console.WriteLine(@"   |      /   \ /   \      |");
            Thread.Sleep(100);
            Console.WriteLine(@"    \    | .-. | .-. |    /");
            Console.WriteLine(@"     '-._| | | | | | |_.-'");
            Thread.Sleep(100);
            Console.WriteLine(@"         | '-' | '-' |");
            Console.WriteLine(@"          \___/ \___/");
            Thread.Sleep(100);
            Console.WriteLine(@"       _.-'  /   \  `-._");
            Console.WriteLine(@"     .' _.--|     |--._ '.");
            Thread.Sleep(100);
            Console.WriteLine(@"     ' _...-|     |-..._ '");
            Console.WriteLine(@"            |     |");
            Thread.Sleep(100);
            Console.WriteLine(@"            '.___.'");
            Console.WriteLine(@"              | |");
            Thread.Sleep(100);
            Console.WriteLine(@"             _| |_");
            Console.WriteLine(@"            /\( )/\");
            Thread.Sleep(100);
            Console.WriteLine(@"           /  ` '  \");
            Console.WriteLine(@"          | |     | |");
            Thread.Sleep(100);
            Console.WriteLine(@"          '-'     '-'");
            Console.WriteLine(@"          | |     | |");
            Thread.Sleep(100);
            Console.WriteLine(@"          | |     | |");
            Console.WriteLine(@"          | |-----| |");
            Thread.Sleep(100);
            Console.WriteLine(@"       .`/  |     | |/`.");
            Console.WriteLine(@"       |    |     |    |");
            Thread.Sleep(100);
            Console.WriteLine(@"       '._.'| .-. |'._.'");
            Console.WriteLine(@"             \ | /");
            Thread.Sleep(100);
            Console.WriteLine(@"             | | |");
            Console.WriteLine(@"             | | |");
            Thread.Sleep(100);
            Console.WriteLine(@"             | | |");
            Console.WriteLine(@"            /| | |\");
            Thread.Sleep(100);
            Console.WriteLine(@"          .'_| | |_`.");
            Console.WriteLine(@"          `. | | | .'");
            Thread.Sleep(100);
            Console.WriteLine(@"       .    /  |  \    .");
            Console.WriteLine(@"      /o`.-'  / \  `-.`o\");
            Thread.Sleep(100);
            Console.WriteLine(@"     /o  o\ .'   `. /o  o\");
            Console.WriteLine(@"     `.___.'       `.___.'");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void PrintConsolationPrize()
        {
            Console.WriteLine("Som takk for deltagelse får du en trøstepremie\n");
            Thread.Sleep(1100);
            Console.WriteLine("Du får den utlevert etter at spillet er ferdig\n");
            Thread.Sleep(3200);
        }

        public static void PrintWelcomeMessagePart2()
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Men spillet er ikke ferdig...\n");
            Thread.Sleep(900);
            Console.WriteLine("Du kan velge én av premiene fra første runde\n");
            Thread.Sleep(1000);
            PrintGifts();
        }

        public static void PrintUnknownError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Beep boop, unknown error, prøv igjen");
            Console.ResetColor();
        }

        public static void PrintExcuseForNotGivingGift(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("\nÅnei, Hans kjøpte visst den siste tilgjengelige billetten. Prøv igjen.");
                    break;
                case 2:
                    Console.WriteLine("\nCharlie hadde ikke tid til å møte deg. Prøv igjen");
                    break;
                case 3:
                    Console.WriteLine("\nEhhh...Her var vi litt optimiske. Uhm. UTSOLGT sier Kristian. Prøv igjen");
                    break;
                case 4:
                    Console.WriteLine("\nDu vil vel ikke ha ferie? Prøv igjen");
                    break;
                case 5:
                    Console.WriteLine("\nFor fint vær i Bahamas i disse dager. Prøv igjen.");
                    break;
            }
        }

        public static void PrintWonFruitBasket()
        {
            Console.WriteLine("\nDu vant en fruktkurv!\n");
            Console.WriteLine("Gratulerer, du er den eneste deltakeren som noensinne har valgt fruktkurven!\n");

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
            Console.Clear();
            Console.WriteLine(@"                0   0                ");
            Console.WriteLine(@"                |   |                ");
            Console.WriteLine(@"            ____|___|____            ");
            Console.WriteLine(@"         0  |~ ~ ~ ~ ~ ~|   0        ");
            Console.WriteLine(@"         |  |           |   |        ");
            Console.WriteLine(@"      ___|__|___________|___|__      ");
            Console.WriteLine(@"      |/\/\/\/\/\/\/\/\/\/\/\/|      ");
            Console.WriteLine(@"  0   |         TOMAS         |   0  ");
            Console.WriteLine(@"  |   |/\/\/\/\/\/\/\/\/\/\/\/|   |  ");
            Console.WriteLine(@" _|___|_______________________|___|__");
            Console.WriteLine(@"|/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/|");
            Console.WriteLine(@"|                                   |");
            Console.WriteLine(@"|        GRATULERER MED DAGEN       |");
            Console.WriteLine(@"| ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ |");
            Console.WriteLine(@"|___________________________________|");
            Console.ResetColor();
        }
    }
}
