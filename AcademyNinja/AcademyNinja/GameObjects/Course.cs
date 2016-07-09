namespace AcademyNinja.GameObjects
{
    using System;
    using Contracts;

    internal class Course : Unit, ICourse
    {
        public Course(IBound bounds) : base(bounds)
        {
        }

        public int Points { get; set; }
    }
}
