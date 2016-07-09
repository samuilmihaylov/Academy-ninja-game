namespace AcademyNinja.GameObjects
{
    using Contracts;
    using System;

    internal class Unit : GameObject, IUnit
    {
        private const int MinimumHealth = 1;

        public Unit(IBound bounds) : base(bounds)
        {
        }

        public int Health { get; set; }

        public virtual bool IsAlive()
        {
            return this.Health < MinimumHealth;
        }
    }
}
