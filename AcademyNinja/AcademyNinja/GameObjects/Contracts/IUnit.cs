namespace AcademyNinja.GameObjects.Contracts
{
    internal interface IUnit
    {
        int Health { get; set; }
        bool IsAlive();
    }
}
