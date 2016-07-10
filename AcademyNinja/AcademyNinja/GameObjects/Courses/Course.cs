namespace AcademyNinja.GameObjects.Courses
{
    using AcademyNinja.GameObjects.Contracts;

    internal abstract class Course : Unit, ICourse
    {
        public Course(IBound bounds, int health, int bonusPoints) : base(bounds, health)
        {
            this.BonusPoints = bonusPoints;
        }

        public int BonusPoints { get; private set; }
    }
}
