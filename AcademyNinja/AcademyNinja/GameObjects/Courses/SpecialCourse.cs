namespace AcademyNinja.GameObjects.Courses
{
    using System.Collections.Generic;

    using AcademyNinja.Contracts;

    internal class SpecialCourse : Course, ISpecialCourse
    {
        private readonly List<IGift> gifts;

        private const int DefaultHealthPoints = 50;
        private const int DefaultBonusPoints = 70;

        public SpecialCourse(IBound bounds) : this(bounds, DefaultHealthPoints, DefaultBonusPoints)
        {

        }

        public SpecialCourse(IBound bounds, int health, int bonusPoints) : base(bounds, health, bonusPoints)
        {
            this.gifts = new List<IGift>();
        }

        public void AddGift(IGift gift)
        {
            // TODO : Validation
            this.gifts.Add(gift);
        }

        public void AddGifts(IEnumerable<IGift> gifts)
        {
            // TODO : Validation
            this.gifts.AddRange(gifts);
        }
    }
}
