namespace AcademyNinja.GameObjects
{
    using System;
    using Contracts;

    internal class Course : Unit, ICourse
    {
        public Course(IBound bounds, int health) : base(bounds, health)
        {
        }

        public int Points { get; set; }
    }
}
