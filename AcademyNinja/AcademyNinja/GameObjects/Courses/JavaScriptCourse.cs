namespace AcademyNinja.GameObjects.Courses
{
    internal class JavaScriptCourse : Course
    {
        private const int DefaultHealthPoints = 50;
        private const int DefaultBonusPoints = 40;

        public JavaScriptCourse(IBound bounds) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public JavaScriptCourse() : base(DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
