namespace AcademyNinja.Engine
{
    using System.Collections.Generic;

    using Contracts;
    using Common.Validator;
    using Common;

    internal class GameContext : IGameContext
    {
        private IEnumerable<IEnumerable<IBoundable>> courses;
        private IBoundable player;
        private ICollection<IBoundable> shields;

        public IEnumerable<IEnumerable<IBoundable>> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.ObjectCannotBeNull, "Courses"));
                this.courses = value;
            }
        }

        public IBoundable Player
        {
            get
            {
                return this.player;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.ObjectCannotBeNull, "Player"));
                this.player = value;
            }
        }

        public ICollection<IBoundable> Shields
        {
            get
            {
                return this.shields;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.ObjectCannotBeNull, "Courses"));
                this.shields = value;
            }
        }
    }
}
