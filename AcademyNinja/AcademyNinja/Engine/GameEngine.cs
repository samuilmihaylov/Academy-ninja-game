namespace AcademyNinja.Engine
{
    using System;

    using CommandProvider;
    using UI;

    internal class GameEngine : IGameEngine
    {
        private IGameRenderer renderer;
        private ICommandProvider commandProvider;

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider)
        {
            this.renderer = gameRenderer;
            this.commandProvider = commandProvider;
        }

        public void InitializeGame()
        {
            throw new NotImplementedException("InitializeGame");
        }

        public void StartGame()
        {
            throw new NotImplementedException("StartGame");
        }
    }
}
