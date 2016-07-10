namespace AcademyNinja
{
    using AcademyNinja.Engine;
    using AcademyNinja.UI;
    using Console;

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
