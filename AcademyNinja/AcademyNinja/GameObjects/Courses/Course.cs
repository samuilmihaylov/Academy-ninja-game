namespace AcademyNinja.GameObjects.Courses
{
    using Contracts;

    internal abstract class Course : Unit, ICourse
    {
        public Course(IBound bounds, int health, int bonusPoints) : base(bounds, health)
        {
            this.BonusPoints = bonusPoints;
        }

        public Course(int health, int points) : this(null, health, points)
        {
        }

        public int BonusPoints { get; private set; }
    }
}
