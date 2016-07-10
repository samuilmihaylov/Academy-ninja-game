namespace AcademyNinja.Engine
{
    using CommandProvider;
    using Factories;
    using GameObjects;
    using GameObjects.Contracts;
    using UI;
    using Contracts;

    internal class GameEngine : IGameEngine
    {
        private IGameRenderer renderer;
        private ICommandProvider commandProvider;
        private ICourseFactory courseFactory;
        //private ICourse[][] courses;
        private INinja academyNinja;
        private IGameContext context;

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider, ICourseFactory courseFactory)
        {
            this.renderer = gameRenderer;
            this.commandProvider = commandProvider;
            this.courseFactory = courseFactory;
            this.context = new GameContext();
        }

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider)
            : this(gameRenderer, commandProvider, new CourseFactory())
        {
        }

        public void InitializeGame()
        {
            this.academyNinja = new Ninja(null, 1, 1);
            this.context.Player = academyNinja;
            this.renderer.DrawGameContext(this.context);
            // ninja init
            // courses array
        }

        public void StartGame()
        {
            while (!this.IsGameFinished())
            {
                //this.renderer.DrawGameContext(null);
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
