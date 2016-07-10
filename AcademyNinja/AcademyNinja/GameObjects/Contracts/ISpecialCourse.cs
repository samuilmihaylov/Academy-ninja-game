namespace AcademyNinja.GameObjects.Contracts
{
    using System.Collections.Generic;

    internal interface ISpecialCourse : ICourse
    {
        void AddGift(IGift gift);

        void AddGifts(IEnumerable<IGift> gifts);
    }
}
