namespace AcademyNinja.Engine
{
    using System;

    using CommandProvider;
    using Factories;
    using GameObjects;
    using GameObjects.Contracts;
    using UI;

    internal class GameEngine : IGameEngine
    {
        private IGameRenderer renderer;
        private ICommandProvider commandProvider;
        private ICourseFactory courseFactory;
        private ICourse[][] courses;
        private INinja academyNinja;

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider, ICourseFactory courseFactory)
        {
            this.renderer = gameRenderer;
            this.commandProvider = commandProvider;
            this.courseFactory = courseFactory;
        }

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider)
            : this(gameRenderer, commandProvider, new CourseFactory())
        {
        }

        public void InitializeGame()
        {
            throw new NotImplementedException("InitializeGame");
            // ninja init
            // courses array
        }

        public void StartGame()
        {
            throw new NotImplementedException("StartGame");

            while (!this.IsGameFinished())
            {
                this.renderer.DrawGameContext(null);
                this.commandProvider.ListenForKeyPress();
                // Appy command
            }
        }

        private bool IsGameFinished()
        {
            return false;
        }
    }
}
