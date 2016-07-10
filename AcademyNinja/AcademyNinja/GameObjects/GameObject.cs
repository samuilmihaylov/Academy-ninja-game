﻿namespace AcademyNinja.GameObjects
{
    using AcademyNinja.GameObjects.Contracts;

    internal class GameObject : IGameObject
    {
        public GameObject(IBound bounds)
        {
            this.Bound = bounds;
        }

        public IBound Bound { get; set; }
    }
}
