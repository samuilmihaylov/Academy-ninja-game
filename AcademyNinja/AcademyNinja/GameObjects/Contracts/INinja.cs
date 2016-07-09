namespace AcademyNinja.GameObjects
{
    using AcademyNinja.GameObjects.Contracts;

    internal interface INinja : IUnit
    {
        int Lives { get; set; }
    }
}
