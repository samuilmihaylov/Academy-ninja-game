namespace AcademyNinja.Engine
{
    using System;
    using CommandProvider;
    using Common;
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
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            // Attache methods for key informattion.
            this.commandProvider.KeyPressed += this.PerformMove;
        }

        private void PerformMove(object sender, KeyPressEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
