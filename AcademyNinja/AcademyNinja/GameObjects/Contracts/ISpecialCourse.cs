namespace AcademyNinja.GameObjects.Contracts
{
    using System.Collections.Generic;

    internal interface ISpecialCourse : ICourse
    {
        IList<ISkill> Skills { get; set; }
    }
}
