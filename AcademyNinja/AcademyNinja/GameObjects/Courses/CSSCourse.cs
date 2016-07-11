namespace AcademyNinja.GameObjects.Courses
{
    using AcademyNinja.Contracts;

    internal class CssCourse : Course, ICourse
    {
        private const int DefaultHealthPoints = 30;
        private const int DefaultBonusPoints = 20;

        public CssCourse(IBound bounds) : this(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }

        public CssCourse(IBound bounds, int health, int bonusPoints) : base(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {
        }
    }
}
