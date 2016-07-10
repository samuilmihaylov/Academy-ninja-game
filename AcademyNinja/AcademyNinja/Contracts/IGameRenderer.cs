namespace AcademyNinja.Contracts
{
    using AcademyNinja.Engine.Contracts;

    internal interface IGameRenderer
    {
        void DrawGameContext(IGameContext gameContext);
    }
}