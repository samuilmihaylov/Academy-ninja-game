namespace AcademyNinja.GameObjects.Contracts
{
    internal interface IBound
    {
        int Width { get; }
        int Height { get; }

        Position Position { get; }
    }
}
