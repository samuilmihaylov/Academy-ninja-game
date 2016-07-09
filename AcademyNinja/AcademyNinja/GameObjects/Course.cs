namespace AcademyNinja.GameObjects
{
    using Contracts;

    internal class Course : Unit, ICourse
    {
        public Course(IBound bounds, int health, int points) : base(bounds, health)
        {
            this.Points = points;
        }

        public int Points { get; }
    }
}
