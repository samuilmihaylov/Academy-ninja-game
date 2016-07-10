namespace AcademyNinja.Engine.Contracts
{
    using System.Collections.Generic;

    internal interface IGameContext
    {
        ICollection<IBoundable[]> Courses { get; set; }

        IBoundable Player { get; set; }

        ICollection<IBoundable> Shields { get; set; }
    }
}
