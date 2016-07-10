namespace AcademyNinja.GameObjects.Courses
{
    internal class CSSCourse : Course
    {
        private const int DefaultHealthPoints = 30;
        private const int DefaultBonusPoints = 20;

        public CSSCourse(IBound bounds) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public CSSCourse() : base(DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
