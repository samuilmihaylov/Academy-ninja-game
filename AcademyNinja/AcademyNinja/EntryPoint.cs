namespace AcademyNinja
{
    using CommandProvider;
    using Engine;
    using UI;

    internal class EntryPoint
    {
        private static void Main()
        {
            var renderer = new ConsoleRenderer();
            var commandProvider = new ConsoleCommandProvider();
            var engine = new GameEngine(renderer, commandProvider);

            engine.InitializeGame();
            engine.StartGame();
        }
    }
}
