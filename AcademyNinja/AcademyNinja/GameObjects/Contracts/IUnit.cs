namespace AcademyNinja.GameObjects.Contracts
{
    internal interface IUnit : IGameObject
    {
        int Health { get; set; }

        bool IsAlive();
    }
}
