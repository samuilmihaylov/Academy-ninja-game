namespace AcademyNinja.GameObjects.Contracts
{
    using System.Collections.Generic;

    internal interface ISpecialCourse
    {
        IList<ISkill> Skills { get; set; }
    }
}
