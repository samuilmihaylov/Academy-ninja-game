namespace AcademyNinja.Engine
{
    using AcademyNinja.Contracts;
    using AcademyNinja.Engine.Contracts;
    using AcademyNinja.Factories;
    using AcademyNinja.GameObjects;
    using AcademyNinja.GameObjects.Contracts;
    using AcademyNinja.Common;

    internal class GameEngine : IGameEngine
    {
        private const int CoursesInRow = 5;
        private const int CoursesInColumn = 5;

        private IGameRenderer renderer;
        private ICommandProvider commandProvider;
        private ICourseFactory courseFactory;
        private ICourse[][] courses;
        private INinja academyNinja;
        private IGameContext context;

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider, ICourseFactory courseFactory)
        {
            this.renderer = gameRenderer;
            this.commandProvider = commandProvider;
            this.courseFactory = courseFactory;
            this.context = new GameContext();
            this.courses = new ICourse[CoursesInRow][];
        }

        public GameEngine(IGameRenderer gameRenderer, ICommandProvider commandProvider)
            : this(gameRenderer, commandProvider, new CourseFactory())
        {
        }

        public void InitializeGame()
        {
            // Creating game objects.
            //this.academyNinja = new Ninja(null, 1, 1);
            this.InitCoursesCollecion();

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
                    var nextCourse = this.courseFactory.CreateCourse(CourseType.HTML);
                    int x = (colIndex * Constants.CourseDrawingWidth) + colIndex * 5;
                    int y = (rowIndex * Constants.CourseDrawingHeigth) + rowIndex;
                    var position = new Position(x, y);
                    nextCourse.Bound.Position = position;
                    this.courses[rowIndex][colIndex] = nextCourse;
                }
            }
        }
    }
}
