namespace AcademyNinja.GameObjects.Contracts
{
    using System.Collections.Generic;

    internal interface ISpecialCourse : ICourse
    {
        ICollection<IGift> Gifts { get; set; }

        void AddSpecialGift(ICollection<IGift> gifts, IGift gift);
    }
}
