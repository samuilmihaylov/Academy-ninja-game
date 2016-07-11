namespace AcademyNinja.GameObjects.Courses
{
    using AcademyNinja.Contracts;

    internal class CSharpCourse : Course, ICourse
    {
        private const int DefaultHealthPoints = 40;
        private const int DefaultBonusPoints = 30;

        public CSharpCourse(IBound bounds) : this(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public CSharpCourse(IBound bounds, int health, int bonusPoints) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
