namespace AcademyNinja.GameObjects
{
    internal class Ninja : Unit, INinja
    {
        private const int MinimumLives = 0;
        private const int InitialLivesCount = 3;

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
