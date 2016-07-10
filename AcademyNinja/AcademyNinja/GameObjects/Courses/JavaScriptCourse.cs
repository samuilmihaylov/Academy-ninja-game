namespace AcademyNinja.GameObjects.Courses
{
    using AcademyNinja.GameObjects.Contracts;

    internal class JavaScriptCourse : Course, ICourse
    {
        private const int DefaultHealthPoints = 50;
        private const int DefaultBonusPoints = 40;

        public JavaScriptCourse(IBound bounds) : this(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public JavaScriptCourse(IBound bounds, int health, int bonusPoints) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
