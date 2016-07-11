namespace AcademyNinja.GameObjects
{
    using AcademyNinja.Contracts;

    internal class Unit : GameObject, IUnit
    {
        private const int MinimumHealth = 1;

        public Unit(IBound bounds, int health) : base(bounds)
        {
            this.Health = health;
        }

        public int Health { get; set; }

        public virtual bool IsAlive()
        {
            return this.Health < MinimumHealth;
        }
    }
}
