namespace AcademyNinja.GameObjects.Courses
{
    using System;
    using System.Collections.Generic;
    using AcademyNinja.GameObjects.Contracts;

    internal class SpecialCourse : Course, ISpecialCourse
    {
        public SpecialCourse(IBound bounds, int health, int bonusPoints) 
            : base(bounds, health, bonusPoints)
        {
        }

        public ICollection<IGift> Gifts { get; set; }

        public void AddSpecialGift(ICollection<IGift> giftsCollection, IGift gift)
        {
            giftsCollection.Add(gift);
        }
    }
}
