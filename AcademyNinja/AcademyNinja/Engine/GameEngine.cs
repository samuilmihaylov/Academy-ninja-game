namespace AcademyNinja.Engine
{
    using AcademyNinja.Common;
    using AcademyNinja.Contracts;
    using AcademyNinja.Factories;
    using System.Collections.Generic;

    internal class GameEngine : IGameEngine
    {
        private const int CoursesInRow = 5;
        private const int CoursesInColumn = 5;

        private IGameRenderer renderer;
        private ICommandProvider commandProvider;
        private IUnitFactory unitsFactory;
        private IList<IList<ICourse>> courses;
        private INinja academyNinja;
        private IGameContext context;

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider, IUnitFactory unitsFactory)
        {
            this.renderer = gameRenderer;
            this.commandProvider = commandProvider;
            this.unitsFactory = unitsFactory;
            this.context = new GameContext();
            this.courses = new ICourse[CoursesInRow][];
        }

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider)
            : this(gameRenderer, commandProvider, new UnitFactory())
        {
        }

        public void InitializeGame()
        {
            this.InitCoursesCollecion();
            this.academyNinja = this.unitsFactory.CreateNinja();
            this.academyNinja.Bound.Position = new Position(
                ((Constants.WindowWidth - Constants.NinjaDrawingWidth) / 2),
                (Constants.WindowHeigth - Constants.NinjaDrawingHeigth));

            this.context.Player = this.academyNinja;
            this.context.Courses = this.courses;
        }

        public void StartGame()
        {
            this.renderer.DrawGameContext(this.context);

            //while (!this.IsGameFinished())
            //{
            //    //this.renderer.DrawGameContext(null);
            //    this.commandProvider.ListenForKeyPress();
            //    // Apply command
            //}
        }

        private bool IsGameFinished()
        {
            return false;
        }

        private void InitCoursesCollecion()
        {
            for (int rowIndex = 0; rowIndex < CoursesInRow; rowIndex++)
            {
                this.courses[rowIndex] = new ICourse[CoursesInColumn];
                for (int colIndex = 0; colIndex < CoursesInColumn; colIndex++)
                {
                    var nextCourse = this.unitsFactory.CreateCourse(CourseType.CSharp);
                    int offsetX = (colIndex * 5) + 5;
                    int offsetY = rowIndex + 1;
                    int x = (colIndex * Constants.CourseDrawingWidth) + offsetX;
                    int y = (rowIndex * Constants.CourseDrawingHeigth) + offsetY;
                    var position = new Position(x, y);
                    nextCourse.Bound.Position = position;
                    this.courses[rowIndex][colIndex] = nextCourse;
                }
            }
        }
    }
}
