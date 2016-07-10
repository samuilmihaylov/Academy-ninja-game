namespace AcademyNinja.GameObjects.Courses
{
    internal class HtmlCourse : Course
    {
        private const int DefaultHealthPoints = 20;
        private const int DefaultBonusPoints = 10;

        public HtmlCourse(IBound bounds) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public HtmlCourse() : base(DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
