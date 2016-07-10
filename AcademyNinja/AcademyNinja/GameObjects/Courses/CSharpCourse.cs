namespace AcademyNinja.GameObjects.Courses
{
    internal class CSharpCourse : Course
    {
        private const int DefaultHealthPoints = 40;
        private const int DefaultBonusPoints = 30;

        public CSharpCourse(IBound bounds) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public CSharpCourse() : base(DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
