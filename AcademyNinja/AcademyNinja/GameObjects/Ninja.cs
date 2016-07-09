namespace AcademyNinja.GameObjects
{
    using System;
    using Contracts;

    internal class Ninja : Unit, INinja
    {
        public Ninja(IBound bounds, int health) : base(bounds, health)
        {
        }

        public int Lives { get; set; }
    }
}
