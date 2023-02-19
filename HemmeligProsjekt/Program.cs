namespace HemmeligProsjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.ShowWindow(Utils.MAXIMIZE);

            Game game = new Game();
            game.PlayGame();
        }
    }
}