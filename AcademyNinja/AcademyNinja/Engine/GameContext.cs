namespace AcademyNinja.Engine.Contracts
{
    using System.Collections.Generic;

    internal class GameContext : IGameContext
    {
        public IEnumerable<IEnumerable<IBoundable>> Courses { get; set; }

        public IBoundable Player { get; set; }

        public ICollection<IBoundable> Shields { get; set; }
    }
}
