namespace AcademyNinja.GameObjects.Courses
{
    using System;
    using System.Collections.Generic;
    using AcademyNinja.GameObjects.Contracts;

    internal class SpecialCourse : Course, ISpecialCourse
    {
        public SpecialCourse(IBound bounds, int health, int bonusPoints) : base(bounds, health, bonusPoints)
        {
        }

        public IList<ISkill> Skills
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
