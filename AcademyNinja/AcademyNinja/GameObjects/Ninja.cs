namespace AcademyNinja.GameObjects
{
    using System;
    using Contracts;

    internal class Ninja : Unit, INinja
    {
        public Ninja(IBound bounds) : base(bounds)
        {
        }

        public int Lives { get; set; }
    }
}
