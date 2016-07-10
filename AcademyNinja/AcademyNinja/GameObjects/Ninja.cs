namespace AcademyNinja.GameObjects
{
    using System.Collections.Generic;

    internal class Ninja : Unit, INinja
    {
        private const int MinimumLives = 0;
        private const int InitialLivesCount = 3;

        private readonly ICollection<IGift> gifts;

        public Ninja(IBound bounds, int health, int lives = InitialLivesCount) : base(bounds, health)
        {
            this.Lives = lives;
        }

        public int Lives { get; set; }

        public override bool IsAlive()
        {
            return this.Lives >= MinimumLives;
        }
    }
}
