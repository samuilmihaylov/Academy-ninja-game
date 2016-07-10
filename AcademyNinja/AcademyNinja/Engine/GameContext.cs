namespace AcademyNinja.Engine.Contracts
{
    using AcademyNinja.GameObjects;
    using AcademyNinja.GameObjects.Contracts;
    using System.Collections.Generic;
    using System;

    internal class GameContext : IGameContext
    {
        public ICollection<IBoundable[]> Courses
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IBoundable Player
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<IBoundable> Shields
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
