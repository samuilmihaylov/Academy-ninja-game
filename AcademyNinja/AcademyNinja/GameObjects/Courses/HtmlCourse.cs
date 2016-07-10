namespace AcademyNinja.GameObjects.Courses
{
    using AcademyNinja.GameObjects.Contracts;

    internal class HtmlCourse : Course, ICourse
    {
        private const int DefaultHealthPoints = 20;
        private const int DefaultBonusPoints = 10;

        public HtmlCourse(IBound bounds) : this(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public HtmlCourse(IBound bounds, int health, int bonusPoints) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
