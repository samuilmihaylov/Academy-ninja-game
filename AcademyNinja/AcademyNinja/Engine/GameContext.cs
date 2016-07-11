namespace AcademyNinja.Engine
{
    using System.Collections.Generic;

    using Contracts;

    internal class GameContext : IGameContext
    {
        public IEnumerable<IEnumerable<IBoundable>> Courses { get; set; }

        public IBoundable Player { get; set; }

        public ICollection<IBoundable> Shields { get; set; }
    }
}
