namespace AcademyNinja.Engine.Contracts
{
    using System.Collections.Generic;

    internal interface IGameContext
    {
        IEnumerable<IEnumerable<IBoundable>> Courses { get; set; }

        IBoundable Player { get; set; }

        ICollection<IBoundable> Shields { get; set; }
    }
}
